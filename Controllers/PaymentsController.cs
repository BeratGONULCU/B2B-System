using System.Security.Claims;
using System.Text.RegularExpressions;
using AvmB2B.Api.Data;
using AvmB2B.Api.DTOs.Payments;
using AvmB2B.Api.Entities;
using AvmB2B.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AvmB2B.Api.Services.Payments;
using Microsoft.Data.SqlClient;

namespace AvmB2B.Api.Controllers;

// flutter build web --release --dart-define=API_BASE_URL=https://cari.avmakaryakit.com/api

[ApiController]
[Authorize]
[Route("api/payments")]
public class PaymentsController : ControllerBase
{
    private readonly PetrolDbContext _context;
    private readonly IEncryptionService _encryptionService;
    private readonly IKuveytTurkPaymentService _kuveytTurkPaymentService;

    private const string DefaultPaymentBankCode = "KuveytTurk";

    public PaymentsController(
        PetrolDbContext context,
        IEncryptionService encryptionService,
        IKuveytTurkPaymentService kuveytTurkPaymentService)
    {
        _context = context;
        _encryptionService = encryptionService;
        _kuveytTurkPaymentService = kuveytTurkPaymentService;
    }

    [HttpGet("installment-options")]
    public async Task<IActionResult> GetInstallmentOptions([FromQuery] decimal amount = 0)
    {
        var userType = User.FindFirst("userType")?.Value;

        if (userType != "Cari" && userType != "Admin")
            return Forbid();

        if (amount < 0)
            return BadRequest("Tutar negatif olamaz.");

        var posAccount = await _context.B2BPosAccounts
            .AsNoTracking()
            .FirstOrDefaultAsync(x =>
                x.BankCode == DefaultPaymentBankCode &&
                x.IsActive
            );

        if (posAccount == null)
            return BadRequest("Kuveyt Türk için aktif POS hesabı bulunamadı.");

        var data = new[]
        {
        new
        {
            ruleId = (int?)null,
            posAccountId = posAccount.Id,

            bankCode = posAccount.BankCode,
            bankName = posAccount.BankName,

            installment = 1,
            title = "Tek Çekim",

            minAmount = (decimal?)null,
            maxAmount = (decimal?)null,
            commissionRate = (decimal?)0,

            amount,
            commissionAmount = 0m,
            totalAmount = amount,
            installmentAmount = amount,

            isActive = true
        }
    };

        return Ok(data);
    }

    [HttpPost("start-3d")]
    public async Task<IActionResult> Start3D([FromBody] StartPaymentRequest request)
    {
        if (request.Amount <= 0)
            return BadRequest("Tutar 0'dan büyük olmalı.");

        var userType = User.FindFirst("userType")?.Value;
        var tokenCariKod = User.FindFirst("cariKod")?.Value;

        var actorUserIdText = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        var actorUsername =
            User.FindFirst(ClaimTypes.Name)?.Value ??
            User.Identity?.Name ??
            User.FindFirst("name")?.Value ??
            "B2B";

        int? actorUserId = int.TryParse(actorUserIdText, out var parsedUserId)
            ? parsedUserId
            : null;

        string cariKod;

        if (userType == "Cari")
        {
            if (string.IsNullOrWhiteSpace(tokenCariKod))
                return Forbid();

            cariKod = tokenCariKod;
        }
        else if (userType == "Admin")
        {
            if (string.IsNullOrWhiteSpace(request.CariKod))
                return BadRequest("Admin ödeme başlatırken cariKod göndermeli.");

            cariKod = request.CariKod.Trim();
        }
        else
        {
            return Forbid();
        }

        var cariExists = await _context.CariKartListesis
            .AsNoTracking()
            .AnyAsync(x => x.Kod == cariKod && x.Sil == 0);

        if (!cariExists)
            return NotFound("Cari bulunamadı.");

        var cariLock = await _context.B2BCariLocks
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.CariKod == cariKod && x.IsLocked);

        if (cariLock != null)
        {
            var reason = string.IsNullOrWhiteSpace(cariLock.Reason)
                ? "Bu cari için ödeme işlemleri geçici olarak durdurulmuştur."
                : cariLock.Reason;

            return BadRequest(reason);
        }

        var bankCode = DefaultPaymentBankCode;

        if (!string.IsNullOrWhiteSpace(request.BankCode) &&
            !string.Equals(request.BankCode.Trim(), bankCode, StringComparison.OrdinalIgnoreCase))
        {
            return BadRequest("Ödeme yalnızca Kuveyt Türk POS hesabı üzerinden alınabilir.");
        }

        // Sistem kuralı: taksitli ödeme kapalı, sadece tek çekim.
        if (request.Installment != 1)
            return BadRequest("Taksitli ödeme kapalıdır. Yalnızca tek çekim ödeme alınabilir.");

        const int installment = 1;

        if (request.ExpireMonth < 1 || request.ExpireMonth > 12)
            return BadRequest("Son kullanma ayı geçersiz.");

        var expireYear = request.ExpireYear;

        if (expireYear >= 0 && expireYear <= 99)
            expireYear += 2000;

        if (expireYear < 1900 || expireYear > 3100)
            return BadRequest("Son kullanma yılı geçersiz.");

        var expireLastDay = new DateTime(
            expireYear,
            request.ExpireMonth,
            DateTime.DaysInMonth(expireYear, request.ExpireMonth)
        );

        if (expireLastDay < DateTime.Today)
            return BadRequest("Kart son kullanma tarihi geçmiş.");

        var bankExpireYear = expireYear % 100;
        var bankExpireMonth = request.ExpireMonth;

        // Kuveyt Türk tek çekimde 0 bekliyor.
        // Biz sistem içinde tek çekimi 1 tutuyoruz ama bankaya 0 göndereceğiz.
        var bankInstallment = installment <= 1 ? 0 : installment;

        if (string.IsNullOrWhiteSpace(request.CardHolderName))
            return BadRequest("Kart sahibi adı boş olamaz.");

        var cleanCvv = new string(
            (request.Cvv ?? "")
                .Where(char.IsDigit)
                .ToArray()
        );

        if (cleanCvv.Length < 3 || cleanCvv.Length > 4)
            return BadRequest("Geçerli bir CVC giriniz.");

        var posAccount = await _context.B2BPosAccounts
            .AsNoTracking()
            .FirstOrDefaultAsync(x =>
                x.BankCode == bankCode &&
                x.IsActive
            );

        if (posAccount == null)
            return BadRequest("Seçilen banka için aktif POS hesabı bulunamadı.");

        var paymentNo = $"PAY-{DateTime.Now:yyyyMMddHHmmss}-{Random.Shared.Next(1000, 9999)}";
        var orderNumber = $"{DateTime.Now:yyMMddHHmmss}{Random.Shared.Next(1000, 9999)}";

        var cleanCardNo = new string(
            (request.CardNumber ?? "")
                .Where(char.IsDigit)
                .ToArray()
        );

        if (cleanCardNo.Length < 15 || cleanCardNo.Length > 19)
            return BadRequest("Kart numarası geçersiz.");

        var cardBin = cleanCardNo.Length >= 6
            ? cleanCardNo.Substring(0, 6)
            : null;

        var cardLast4 = cleanCardNo.Length >= 4
            ? cleanCardNo.Substring(cleanCardNo.Length - 4)
            : null;

        var maskedCardNo = cardBin != null && cardLast4 != null
            ? $"{cardBin}******{cardLast4}"
            : null;

        var payment = new B2BPayment
        {
            PaymentNo = paymentNo,
            CariKod = cariKod,
            Amount = request.Amount,
            Currency = "TRY",
            Status = "Pending",

            BankCode = bankCode,
            PosAccountId = posAccount.Id,
            Installment = installment,

            OrderNumber = orderNumber,

            CardBin = cardBin,
            CardLast4 = cardLast4,
            MaskedCardNo = maskedCardNo,

            CreatedByUserId = actorUserId,
            CreatedByUsername = actorUsername,
            CreatedByUserType = userType,

            CreatedAt = DateTime.Now
        };

        _context.B2BPayments.Add(payment);
        await _context.SaveChangesAsync();

        _context.B2BPaymentLogs.Add(new B2BPaymentLog
        {
            PaymentId = payment.Id,
            Direction = "StartRequest",
            LogType = "Request",
            RawData = System.Text.Json.JsonSerializer.Serialize(new
            {
                request.Amount,
                CariKod = cariKod,
                BankCode = bankCode,
                Installment = installment,
                MaskedCardNo = maskedCardNo
            }),
            CreatedAt = DateTime.Now
        });

        await _context.SaveChangesAsync();

        try
        {
            var merchantPassword = _encryptionService.Decrypt(posAccount.MerchantPasswordEncrypted);

            var customerId = posAccount.CustomerId?.Trim();

            if (string.IsNullOrWhiteSpace(customerId))
            {
                payment.Status = "Failed";
                payment.ErrorMessage = "Kuveyt Türk CustomerId / Müşteri No tanımlı değil.";
                payment.UpdatedAt = DateTime.Now;

                await _context.SaveChangesAsync();

                return BadRequest("Kuveyt Türk CustomerId / Müşteri No tanımlı değil.");
            }
            var returnUrl = posAccount.ReturnUrl;

            if (string.IsNullOrWhiteSpace(returnUrl))
            {
                returnUrl = $"{Request.Scheme}://{Request.Host}/api/payments/3d-callback";
            }

            var callbackUrl = $"{returnUrl}?paymentNo={payment.PaymentNo}";

            var clientIp = GetSafeClientIp(HttpContext);

            var identityTaxNumber = NormalizeIdentityTaxNumber(
                request.IdentityTaxNumber,
                posAccount.TestPlatform
            );

            if (string.IsNullOrWhiteSpace(identityTaxNumber))
            {
                payment.Status = "Failed";
                payment.ErrorMessage = "Vergi/T.C. kimlik numarası zorunludur.";
                payment.UpdatedAt = DateTime.Now;

                await _context.SaveChangesAsync();

                return BadRequest("Vergi/T.C. kimlik numarası zorunludur.");
            }

            _context.B2BPaymentLogs.Add(new B2BPaymentLog
            {
                PaymentId = payment.Id,
                Direction = "KuveytTurkSaleRequestDebug",
                LogType = "Debug",
                RawData = System.Text.Json.JsonSerializer.Serialize(new
                {
                    Auth = new
                    {
                        BankCode = posAccount.BankCode,
                        posAccount.MerchantId,
                        posAccount.MerchantUser,
                        CustomerIdLength = customerId?.Length,
                        PasswordLength = merchantPassword?.Length,
                        posAccount.TestPlatform
                    },
                    Sale = new
                    {
                        request.Amount,
                        Installment = installment,
                        ExpireMonth = request.ExpireMonth,
                        ExpireYear = expireYear,
                        CardBin = cardBin,
                        CardLast4 = cardLast4,
                        OrderNumber = payment.OrderNumber,
                        OrderNumberLength = payment.OrderNumber?.Length,
                        CallbackUrl = callbackUrl,
                        ClientIp = clientIp,
                        IdentityTaxNumberLength = identityTaxNumber.Length
                    }
                }),
                CreatedAt = DateTime.Now
            });

            await _context.SaveChangesAsync();

            var cariInfo = await GetPaymentCariInfoAsync(cariKod);

            var phoneNumber = NormalizePhoneNumber(request.PhoneNumber);

            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                phoneNumber = NormalizePhoneNumber(cariInfo.Cep);

                if (string.IsNullOrWhiteSpace(phoneNumber))
                    phoneNumber = NormalizePhoneNumber(cariInfo.Tel);
            }

            var saleResponse = await _kuveytTurkPaymentService.Start3DAsync(
    new KuveytTurk3DStartRequest
    {
        TestPlatform = posAccount.TestPlatform,

        MerchantId = posAccount.MerchantId,
        CustomerId = customerId,
        UserName = posAccount.MerchantUser,
        Password = merchantPassword,

        CardNumber = cleanCardNo,
        CardHolderName = request.CardHolderName.Trim(),
        CardType = NormalizeKuveytTurkCardType(request.CardType, cleanCardNo),
        ExpireMonth = bankExpireMonth,
        ExpireYear = bankExpireYear,
        Cvv = cleanCvv,

        Amount = request.Amount,
        Installment = bankInstallment,

        OrderNumber = payment.OrderNumber,
        ReturnUrl = callbackUrl,
        ClientIp = clientIp,

        Description = $"B2B Odeme {payment.PaymentNo} - {cariInfo.CariKod}",

        IdentityTaxNumber = identityTaxNumber,

        Email = string.IsNullOrWhiteSpace(cariInfo.Email)
        ? "muhasebe@avmakaryakit.com"
        : cariInfo.Email.Trim(),

        PhoneNumber = string.IsNullOrWhiteSpace(phoneNumber)
        ? "5075183344"
        : phoneNumber,

        AddressLine = "köprübaşı mh 4030 sk. no:1/205 Serdivan/SAKARYA",
        City = "Sakarya",
        PostCode = "54130",
        StateCode = "54"
    }
);

            payment.RedirectType = saleResponse.Status;
            payment.RedirectData = saleResponse.RawResponse;
            payment.UpdatedAt = DateTime.Now;

            if (!saleResponse.IsSuccess)
            {
                payment.Status = "Failed";
                payment.ErrorMessage = saleResponse.Message;
            }

            _context.B2BPaymentLogs.Add(new B2BPaymentLog
            {
                PaymentId = payment.Id,
                Direction = "KuveytTurkSaleResponse",
                LogType = "Response",
                IsSuccess = saleResponse.IsSuccess,
                ErrorCode = saleResponse.ResponseCode,
                ErrorMessage = saleResponse.IsSuccess ? null : saleResponse.Message,
                RawData = MaskSensitiveJson(System.Text.Json.JsonSerializer.Serialize(new
                {
                    saleResponse.Status,
                    saleResponse.IsRedirectHtml,
                    saleResponse.ResponseCode,
                    saleResponse.Message,
                    RequestXml = saleResponse.DebugRequestXml,
                    RawResponse = saleResponse.IsRedirectHtml
                        ? "***REDIRECT_HTML_MASKED***"
                        : saleResponse.RawResponse
                })),
                CreatedAt = DateTime.Now
            });

            await _context.SaveChangesAsync();

            return Ok(new
            {
                payment.Id,
                payment.PaymentNo,
                payment.OrderNumber,
                payment.CariKod,
                payment.Amount,
                payment.Currency,
                payment.Status,
                redirectType = payment.RedirectType,
                redirectData = payment.RedirectData
            });
        }
        catch (Exception ex)
        {
            payment.Status = "Failed";
            payment.ErrorMessage = ex.Message;
            payment.UpdatedAt = DateTime.Now;

            _context.B2BPaymentLogs.Add(new B2BPaymentLog
            {
                PaymentId = payment.Id,
                Direction = "KuveytTurkSaleError",
                LogType = "Error",
                IsSuccess = false,
                ErrorMessage = ex.Message,
                RawData = MaskSensitiveJson(ex.ToString()),
                CreatedAt = DateTime.Now
            });

            await _context.SaveChangesAsync();

            return BadRequest($"Kuveyt Türk ödeme başlatma hatası: {ex.Message}");
        }
    }

    // Dikkat: Sadece lokal/test için. İş bitince kaldır.
    [Authorize]
    [HttpPost("admin/pos-accounts/set-kuveyt-test")]
    public async Task<IActionResult> SetKuveytTestPosAccount()
    {
        var userType = User.FindFirst("userType")?.Value;

        if (userType != "Admin")
            return Forbid();

        var posAccount = await _context.B2BPosAccounts
            .FirstOrDefaultAsync(x => x.BankCode == DefaultPaymentBankCode);

        if (posAccount == null)
        {
            posAccount = new B2BPosAccount
            {
                BankCode = DefaultPaymentBankCode,
                BankName = "Kuveyt Türk Sanal POS",
                CreatedAt = DateTime.Now,
                IsActive = true
            };

            _context.B2BPosAccounts.Add(posAccount);
        }

        posAccount.BankName = "Kuveyt Türk Sanal POS";
        posAccount.MerchantId = "57902";
        posAccount.MerchantUser = "TEPKVT2021";

        // Kuveyt Türk Password
        posAccount.MerchantPasswordEncrypted = _encryptionService.Encrypt("api123");

        // Kuveyt Türk CustomerId buraya yazılıyor.
        // CP.VPOS Kuveyt Türk tarafında merchantStorekey = CustomerId gibi kullanılıyor.
        posAccount.MerchantStoreKeyEncrypted = _encryptionService.Encrypt("97228291");

        posAccount.TestPlatform = true;
        posAccount.IsActive = true;
        posAccount.ReturnUrl = "https://cari.avmakaryakit.com/api/payments/3d-callback";
        // Muhasebe tarafı için sadece varsayılan tip/açıklama verilebilir.
        // Karşı kart kodu manuel/hardcoded set edilmeyecek.
        posAccount.AccountingCardType ??= "istkart";
        posAccount.AccountingDescription ??= "K.KARTI";

        // Burası özellikle boş bırakılıyor.
        // Doğru işletme kart/hesap kodu DB'den veya admin ekrandan girilecek.
        // posAccount.AccountingCardCode = "KART0012";  // YAZMA
        posAccount.UpdatedAt = DateTime.Now;


        await _context.SaveChangesAsync();

        return Ok(new
        {
            success = true,
            message = "Kuveyt Türk test POS bilgileri güncellendi.",
            posAccount.Id,
            posAccount.BankCode,
            posAccount.BankName,
            posAccount.MerchantId,
            posAccount.MerchantUser,
            posAccount.TestPlatform,
            posAccount.ReturnUrl,
            posAccount.IsActive
        });
    }

    [AllowAnonymous]
    [AcceptVerbs("GET", "POST")]
    [Route("3d-callback")]
    public async Task<IActionResult> ThreeDCallback([FromQuery] string? paymentNo)
    {
        Dictionary<string, object> pairs;

        if (Request.HasFormContentType)
        {
            var form = await Request.ReadFormAsync();
            pairs = form.Keys.ToDictionary(k => k, k => (object)form[k].ToString());
        }
        else
        {
            pairs = Request.Query.Keys.ToDictionary(k => k, k => (object)Request.Query[k].ToString());
        }
        NormalizeKuveytTurkCallbackPayload(pairs);

        if (string.IsNullOrWhiteSpace(paymentNo))
            paymentNo = Request.Query["paymentNo"].ToString();

        if (string.IsNullOrWhiteSpace(paymentNo) && pairs.TryGetValue("paymentNo", out var paymentNoFromPairs))
            paymentNo = paymentNoFromPairs?.ToString();

        if (string.IsNullOrWhiteSpace(paymentNo))
        {
            return HtmlResult("Ödeme callback hatası", "paymentNo bulunamadı.");
        }

        var payment = await _context.B2BPayments
            .FirstOrDefaultAsync(x => x.PaymentNo == paymentNo);

        if (payment == null)
        {
            return HtmlResult("Ödeme callback hatası", "Ödeme kaydı bulunamadı.");
        }

        var now = DateTime.Now;

        payment.CallbackReceivedAt = now;
        payment.UpdatedAt = now;

        _context.B2BPaymentLogs.Add(new B2BPaymentLog
        {
            PaymentId = payment.Id,
            Direction = "ThreeDCallbackRaw",
            LogType = "Request",
            IsSuccess = true,
            RawData = MaskSensitiveJson(System.Text.Json.JsonSerializer.Serialize(new
            {
                PaymentNo = payment.PaymentNo,
                Query = Request.Query.ToDictionary(x => x.Key, x => x.Value.ToString()),
                FormOrQueryData = pairs
            })),
            CreatedAt = now
        });

        await _context.SaveChangesAsync();

        var posAccount = await _context.B2BPosAccounts
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == payment.PosAccountId && x.IsActive);

        if (posAccount == null)
        {
            payment.Status = "Failed";
            payment.ErrorMessage = "POS hesabı bulunamadı.";
            payment.UpdatedAt = DateTime.Now;

            await _context.SaveChangesAsync();

            return HtmlResult("Ödeme başarısız", "POS hesabı bulunamadı.");
        }

        try
        {
            if (payment.BankCode.Equals(DefaultPaymentBankCode, StringComparison.OrdinalIgnoreCase))
            {
                var merchantPassword = _encryptionService.Decrypt(posAccount.MerchantPasswordEncrypted);
                var customerId = posAccount.CustomerId?.Trim();

                if (string.IsNullOrWhiteSpace(customerId))
                {
                    payment.Status = "Failed";
                    payment.ErrorMessage = "Kuveyt Türk CustomerId / Müşteri No tanımlı değil.";
                    payment.UpdatedAt = DateTime.Now;

                    await _context.SaveChangesAsync();

                    return HtmlResult("Ödeme başarısız", "Kuveyt Türk CustomerId / Müşteri No tanımlı değil.");
                }
                var bankInstallment = payment.Installment <= 1 ? 0 : payment.Installment;

                var confirmResponse = await _kuveytTurkPaymentService.Confirm3DAsync(
                    new KuveytTurk3DConfirmRequest
                    {
                        TestPlatform = posAccount.TestPlatform,

                        MerchantId = posAccount.MerchantId,
                        CustomerId = customerId,
                        UserName = posAccount.MerchantUser,
                        Password = merchantPassword,

                        OrderNumber = payment.OrderNumber,
                        Amount = payment.Amount,
                        Installment = bankInstallment,

                        CurrencyCode = string.IsNullOrWhiteSpace(posAccount.CurrencyCode)
                            ? "0949"
                            : posAccount.CurrencyCode.Trim(),

                        TransactionSecurity = posAccount.TransactionSecurity ?? 3,

                        Description = $"B2B Odeme {payment.PaymentNo}",
                        ResponseData = pairs
                    }
                );

                payment.RedirectType = confirmResponse.Status;
                payment.RedirectData = confirmResponse.Message;
                payment.BankResponseCode = confirmResponse.ResponseCode;
                payment.BankResponseMessage = confirmResponse.Message;
                payment.BankTransactionId = confirmResponse.TransactionId;
                payment.AuthCode = confirmResponse.AuthCode;
                payment.HostRefNo = confirmResponse.HostRefNo;
                payment.UpdatedAt = DateTime.Now;

                if (confirmResponse.IsSuccess)
                {
                    payment.Status = "Paid";
                    payment.ErrorMessage = null;
                    payment.PaidAt = now;

                    await _context.SaveChangesAsync();

                    try
                    {
                        await InsertCariHrkForPaidPaymentAsync(payment, posAccount, now);
                    }
                    catch (Exception accountingEx)
                    {
                        payment.ErrorMessage =
                            "Ödeme başarılı fakat cari hareket kaydı oluşturulamadı: " + accountingEx.Message;

                        payment.UpdatedAt = DateTime.Now;

                        _context.B2BPaymentLogs.Add(new B2BPaymentLog
                        {
                            PaymentId = payment.Id,
                            Direction = "CariHrkInsertError",
                            LogType = "Error",
                            IsSuccess = false,
                            ErrorMessage = accountingEx.Message,
                            RawData = MaskSensitiveJson(accountingEx.ToString()),
                            CreatedAt = DateTime.Now
                        });

                        await _context.SaveChangesAsync();
                    }
                }
                else
                {
                    payment.Status = "Failed";
                    payment.ErrorMessage = confirmResponse.Message;
                }

                _context.B2BPaymentLogs.Add(new B2BPaymentLog
                {
                    PaymentId = payment.Id,
                    Direction = "KuveytTurkSale3DResponseFull",
                    LogType = "Response",
                    IsSuccess = confirmResponse.IsSuccess,
                    ErrorCode = confirmResponse.ResponseCode,
                    ErrorMessage = confirmResponse.IsSuccess ? null : confirmResponse.Message,
                    RawData = MaskSensitiveJson(System.Text.Json.JsonSerializer.Serialize(new
                    {
                        confirmResponse.Status,
                        confirmResponse.ResponseCode,
                        confirmResponse.Message,
                        confirmResponse.MerchantOrderId,
                        confirmResponse.OrderId,
                        confirmResponse.ProvisionNumber,
                        confirmResponse.TransactionId,
                        DebugProvisionRequestXml = confirmResponse.DebugProvisionRequestXml,
                        RawAuthenticationResponseXml = confirmResponse.RawAuthenticationResponseXml,
                        RawProvisionResponseXml = confirmResponse.RawProvisionResponseXml
                    })),
                    CreatedAt = DateTime.Now
                });

                await _context.SaveChangesAsync();

                if (confirmResponse.IsSuccess)
                {
                    return HtmlResult(
                        "Ödeme başarılı.",
                        "Payment No: " + payment.PaymentNo + ". Bu pencereyi kapatabilirsiniz."
                    );
                }

                return HtmlResult(
                    "Ödeme başarısız.",
                    string.IsNullOrWhiteSpace(confirmResponse.Message)
                        ? "İşlem sırasında bir hata oluştu."
                        : confirmResponse.Message
                );
            }

            var virtualPosAuth = BuildVirtualPosAuth(posAccount);

            var sale3DResponse = CP.VPOS.VPOSClient.Sale3DResponse(
                new CP.VPOS.Models.Sale3DResponseRequest
                {
                    responseArray = pairs
                },
                virtualPosAuth
            );

            var responseStatus = sale3DResponse.statu.ToString();
            var responseMessage = sale3DResponse.message;

            var procReturnCode = GetPairValue(pairs, "ProcReturnCode");
            var errMsg = GetPairValue(pairs, "ErrMsg");
            var bankInternalMessage = GetPairValue(pairs, "BankInternalResponseMessage");
            var bankInternalSubmessage = GetPairValue(pairs, "BankInternalResponseSubmessage");
            var authCode = GetPairValue(pairs, "AuthCode");
            var hostRefNo = GetPairValue(pairs, "HostRefNum");
            var rrn = GetPairValue(pairs, "RRN");

            var isSuccess = IsQnbPaymentSuccess(pairs, responseStatus, responseMessage);

            payment.RedirectType = responseStatus;
            payment.RedirectData = responseMessage;
            payment.BankResponseCode = procReturnCode;
            payment.BankResponseMessage = string.Join(" | ", new[]
            {
        errMsg,
        bankInternalMessage,
        bankInternalSubmessage
    }.Where(x => !string.IsNullOrWhiteSpace(x)));

            payment.AuthCode = authCode;
            payment.HostRefNo = !string.IsNullOrWhiteSpace(hostRefNo) ? hostRefNo : rrn;
            payment.UpdatedAt = DateTime.Now;

            if (isSuccess)
            {
                payment.Status = "Paid";
                payment.ErrorMessage = null;
                payment.PaidAt = DateTime.Now;

                await _context.SaveChangesAsync();

                try
                {
                    await InsertCariHrkForPaidPaymentAsync(payment, posAccount, DateTime.Now);
                }
                catch (Exception accountingEx)
                {
                    payment.ErrorMessage =
                        "Ödeme başarılı fakat cari hareket kaydı oluşturulamadı: " + accountingEx.Message;

                    payment.UpdatedAt = DateTime.Now;

                    _context.B2BPaymentLogs.Add(new B2BPaymentLog
                    {
                        PaymentId = payment.Id,
                        Direction = "CariHrkInsertError",
                        LogType = "Error",
                        IsSuccess = false,
                        ErrorMessage = accountingEx.Message,
                        RawData = MaskSensitiveJson(accountingEx.ToString()),
                        CreatedAt = DateTime.Now
                    });

                    await _context.SaveChangesAsync();
                }
            }
            else
            {
                payment.Status = "Failed";

                payment.ErrorMessage = !string.IsNullOrWhiteSpace(payment.BankResponseMessage)
                    ? payment.BankResponseMessage
                    : responseMessage;
            }

            _context.B2BPaymentLogs.Add(new B2BPaymentLog
            {
                PaymentId = payment.Id,
                Direction = "Sale3DResponseFull",
                LogType = "Response",
                IsSuccess = isSuccess,
                RawData = MaskSensitiveJson(System.Text.Json.JsonSerializer.Serialize(new
                {
                    ResponseStatus = responseStatus,
                    ResponseMessage = responseMessage,
                    FullResponse = sale3DResponse
                })),
                ErrorMessage = isSuccess ? null : responseMessage,
                CreatedAt = DateTime.Now
            });

            await _context.SaveChangesAsync();

            if (isSuccess)
            {
                return HtmlResult(
                    "Ödeme başarılı.",
                    "Payment No: " + payment.PaymentNo + ". Bu pencereyi kapatabilirsiniz."
                );
            }

            var userMessage = !string.IsNullOrWhiteSpace(payment.BankResponseMessage)
                ? payment.BankResponseMessage
                : responseMessage;

            if (string.IsNullOrWhiteSpace(userMessage))
                userMessage = "İşlem sırasında bir hata oluştu.";

            return HtmlResult("Ödeme başarısız.", userMessage);
        }
        catch (Exception ex)
        {
            payment.Status = "Failed";
            payment.ErrorMessage = ex.Message;
            payment.UpdatedAt = DateTime.Now;

            _context.B2BPaymentLogs.Add(new B2BPaymentLog
            {
                PaymentId = payment.Id,
                Direction = "ThreeDCallbackError",
                LogType = "Error",
                IsSuccess = false,
                ErrorMessage = ex.Message,
                RawData = MaskSensitiveJson(ex.ToString()),
                CreatedAt = DateTime.Now
            });

            await _context.SaveChangesAsync();

            return HtmlResult("Ödeme callback hatası.", ex.Message);
        }
    }

    [HttpPost("card-rule-check")]
    public IActionResult CheckCardRule([FromBody] CardRuleCheckRequest request)
    {
        var userType = User.FindFirst("userType")?.Value;

        if (userType != "Cari" && userType != "Admin")
            return Forbid();

        return Ok(new
        {
            allowed = true,
            message = "Tek çekim ödemelerde tüm banka kartları kullanılabilir."
        });
    }
    public class CardRuleCheckRequest
    {
        public int Installment { get; set; }
        public string? CardPrefix { get; set; }
    }


    // Dikkat: Bu endpoint’i canlıya bırakma. Lokal/test işi bitince kaldır veya sadece Development ortamında çalışacak hale getiririz
    [Authorize]
    [HttpPost("admin/pos-accounts/encrypt-existing")]
    public async Task<IActionResult> EncryptExistingPosAccounts()
    {
        var userType = User.FindFirst("userType")?.Value;

        if (userType != "Admin")
            return Forbid();

        var posAccounts = await _context.B2BPosAccounts
            .Where(x => x.IsActive)
            .ToListAsync();

        foreach (var pos in posAccounts)
        {
            if (!string.IsNullOrWhiteSpace(pos.MerchantPasswordEncrypted))
            {
                pos.MerchantPasswordEncrypted = _encryptionService.Encrypt(
                    _encryptionService.Decrypt(pos.MerchantPasswordEncrypted)
                );
            }

            if (!string.IsNullOrWhiteSpace(pos.MerchantStoreKeyEncrypted))
            {
                pos.MerchantStoreKeyEncrypted = _encryptionService.Encrypt(
                    _encryptionService.Decrypt(pos.MerchantStoreKeyEncrypted)
                );
            }

            pos.UpdatedAt = DateTime.Now;
        }

        await _context.SaveChangesAsync();

        return Ok(new
        {
            success = true,
            message = "Aktif POS hesaplarının credential alanları encrypt edildi.",
            count = posAccounts.Count
        });
    }

    [HttpGet]
    public async Task<IActionResult> GetPayments(
        [FromQuery] string? cariKod,
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 50)
    {
        if (page < 1) page = 1;
        if (pageSize < 1) pageSize = 50;
        if (pageSize > 500) pageSize = 500;

        var userType = User.FindFirst("userType")?.Value;
        var tokenCariKod = User.FindFirst("cariKod")?.Value;

        var query = _context.B2BPayments
            .AsNoTracking()
            .AsQueryable();

        if (userType == "Cari")
        {
            if (string.IsNullOrWhiteSpace(tokenCariKod))
                return Forbid();

            query = query.Where(x => x.CariKod == tokenCariKod);
        }
        else if (userType == "Admin")
        {
            if (!string.IsNullOrWhiteSpace(cariKod))
                query = query.Where(x => x.CariKod == cariKod);
        }
        else
        {
            return Forbid();
        }

        var totalCount = await query.CountAsync();

        var data = await query
            .OrderByDescending(x => x.Id)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .Select(x => new
            {
                x.Id,
                x.PaymentNo,
                x.CariKod,
                x.Amount,
                x.Currency,
                x.Status,
                x.BankCode,
                x.OrderNumber,
                x.BankTransactionId,
                x.ErrorMessage,
                x.CreatedAt,
                x.UpdatedAt
            })
            .ToListAsync();

        return Ok(new
        {
            page,
            pageSize,
            totalCount,
            data
        });
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetPaymentById(int id)
    {
        var userType = User.FindFirst("userType")?.Value;
        var tokenCariKod = User.FindFirst("cariKod")?.Value;

        var payment = await _context.B2BPayments
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);

        if (payment == null)
            return NotFound("Ödeme bulunamadı.");

        if (userType == "Cari")
        {
            if (payment.CariKod != tokenCariKod)
                return Forbid();
        }
        else if (userType != "Admin")
        {
            return Forbid();
        }

        return Ok(payment);
    }

    private static string NormalizeKuveytTurkCardType(string? requestedCardType, string cardNumber)
    {
        var value = (requestedCardType ?? "").Trim();

        if (!string.IsNullOrWhiteSpace(value))
        {
            if (value.Equals("Troy", StringComparison.OrdinalIgnoreCase) ||
                value.Equals("TROY", StringComparison.OrdinalIgnoreCase))
                return "Troy";

            if (value.Equals("Visa", StringComparison.OrdinalIgnoreCase) ||
                value.Equals("VISA", StringComparison.OrdinalIgnoreCase))
                return "VISA";

            if (value.Equals("MasterCard", StringComparison.OrdinalIgnoreCase) ||
                value.Equals("MASTER", StringComparison.OrdinalIgnoreCase) ||
                value.Equals("MASTERCARD", StringComparison.OrdinalIgnoreCase))
                return "MasterCard";
        }

        var digits = new string((cardNumber ?? "").Where(char.IsDigit).ToArray());

        if (digits.StartsWith("9792") || digits.StartsWith("65") || digits.StartsWith("36"))
            return "Troy";

        if (digits.StartsWith("4"))
            return "VISA";

        if (digits.StartsWith("5") || digits.StartsWith("2"))
            return "MasterCard";

        return "MasterCard";
    }

    private static string NormalizeIdentityTaxNumber(string? value, bool isTestPlatform)
    {
        var digits = new string((value ?? "").Where(char.IsDigit).ToArray());

        if (digits.Length == 10 || digits.Length == 11)
            return digits;

        if (isTestPlatform)
            return "11111111110";

        return "";
    }
    private const string ServerPublicIp = "78.189.16.216";

    private static string GetSafeClientIp(HttpContext httpContext)
    {
        // Cloudflare üzerinden geliyorsa gerçek kullanıcı IP'si genelde buradadır.
        var cfIp = httpContext.Request.Headers["CF-Connecting-IP"].FirstOrDefault();

        if (IsValidPublicIpv4(cfIp))
            return cfIp!.Trim();

        // Proxy / tunnel arkasında geliyorsa ilk IP alınır.
        var forwardedFor = httpContext.Request.Headers["X-Forwarded-For"].FirstOrDefault();

        if (!string.IsNullOrWhiteSpace(forwardedFor))
        {
            var firstIp = forwardedFor
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .FirstOrDefault()
                ?.Trim();

            if (IsValidPublicIpv4(firstIp))
                return firstIp!;
        }

        var realIp = httpContext.Request.Headers["X-Real-IP"].FirstOrDefault();

        if (IsValidPublicIpv4(realIp))
            return realIp!.Trim();

        var ip = httpContext.Connection.RemoteIpAddress;

        if (ip != null)
        {
            if (ip.IsIPv4MappedToIPv6)
                ip = ip.MapToIPv4();

            var ipText = ip.ToString();

            if (IsValidPublicIpv4(ipText))
                return ipText;
        }

        // Son çare: server public IP.
        // 127.0.0.1 veya 192.168.x.x Kuveyt'e gönderilmesin.
        return ServerPublicIp;
    }

    private static bool IsValidPublicIpv4(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return false;

        value = value.Trim();

        if (!System.Net.IPAddress.TryParse(value, out var ip))
            return false;

        if (ip.AddressFamily != System.Net.Sockets.AddressFamily.InterNetwork)
            return false;

        var parts = value.Split('.');

        if (parts.Length != 4)
            return false;

        var a = int.Parse(parts[0]);
        var b = int.Parse(parts[1]);

        // Local / private / loopback IP'leri Kuveyt'e göndermiyoruz.
        if (a == 10)
            return false;

        if (a == 127)
            return false;

        if (a == 192 && b == 168)
            return false;

        if (a == 172 && b >= 16 && b <= 31)
            return false;

        if (a == 0)
            return false;

        return true;
    }

    private async Task InsertCariHrkForPaidPaymentAsync(
    B2BPayment payment,
    B2BPosAccount posAccount,
    DateTime now)
    {
        var belNo = Limit(payment.PaymentNo, 30);

        var accountingUser = Limit(
            payment.CreatedByUsername ?? "B2B",
            50
        );

        var accountingCardType = Limit(
            string.IsNullOrWhiteSpace(posAccount.AccountingCardType)
                ? "istkart"
                : posAccount.AccountingCardType,
            50
        );

        var accountingCardCode = Limit(
            posAccount.AccountingCardCode,
            50
        );

        if (string.IsNullOrWhiteSpace(accountingCardCode))
        {
            throw new Exception(
                $"POS hesabı için muhasebe kart kodu tanımlı değil. BankCode: {posAccount.BankCode}"
            );
        }

        var ack = Limit(
            string.IsNullOrWhiteSpace(posAccount.AccountingDescription)
                ? "K.KARTI"
                : posAccount.AccountingDescription,
            200
        );

        var tarih = now.Date;
        var saat = now.ToString("HH:mm:ss");

        await _context.Database.ExecuteSqlInterpolatedAsync($@"
IF NOT EXISTS (
    SELECT 1
    FROM dbo.carihrk WITH (UPDLOCK, HOLDLOCK)
    WHERE islmhrk = 'IKK'
      AND belno = {belNo}
      AND sil = 0
)
BEGIN
    DECLARE @CarHrkId INT;
    DECLARE @CariId INT;
    DECLARE @FirmaNo INT;

    SELECT TOP 1
        @CariId = id,
        @FirmaNo = ISNULL(firmano, 1)
    FROM dbo.Cari_Kart_Listesi WITH (NOLOCK)
    WHERE kod = {payment.CariKod}
      AND sil = 0;

    IF @CariId IS NULL
    BEGIN
        THROW 51050, 'Cari_Kart_Listesi içinde ödeme yapılacak cari bulunamadı.', 1;
    END;

    SELECT @CarHrkId = ISNULL(MAX(carhrkid), 0) + 1
    FROM dbo.carihrk WITH (UPDLOCK, HOLDLOCK);

    INSERT INTO dbo.carihrk
    (
        carhrkid,
        firmano,
        gctip,
        masterid,

        islmtip,
        islmtipad,
        islmhrk,
        islmhrkad,

        yerad,
        yertip,
        cartip,
        carkod,

        borc,
        alacak,
        bakiye,

        tarih,
        saat,

        olususer,
        olustarsaat,

        vadetar,
        belno,
        ack,

        varno,
        kur,
        dataok,
        pro,
        varok,

        adaid,

        deguser,
        degtarsaat,

        sil,
        parabrm,

        karsihestip,
        karsiheskod,

        kdvyuz,

        fisaktip,
        fisfattip,
        fisfatid,
        marsatid,

        fisid,

        permasmasid,
        fatstkhrkid,
        carvardmasid,

        fis_cariborc_id,
        tahodeid,
        fis_alc_id,
        car_id,
        cartip_id,

        FisStkAnaid,
        FatStkAnaid,

        Poshrk_id,
        kasahrk_id,
        Bankahrk_id,
        isthrk_id,

        devir,
        CariAvans,
        Entegre,
        TransferStartId,
        TransferStopId,
        FatKapTip,

        Karsi_KartTip,
        Karsi_KartKod
    )
    VALUES
    (
        @CarHrkId,
        @FirmaNo,
        'C',
        @CariId,

        'ODE',
        N'ÖDEME',
        'IKK',
        N'KREDİ KART İLE ÖDEME',

        N'İŞLETME KREDİ KART',
        'istkart',
        'carikart',
        {payment.CariKod},

        {payment.Amount},
        0,
        0,

        {tarih},
        {saat},

        {accountingUser},
        {now},

        {tarih},
        {belNo},
        {ack},

        0,
        1,
        0,
        1,
        1,

        0,

        {accountingUser},
        {now},

        0,
        'TL',

        {accountingCardType},
        {accountingCardCode},

        0,

        '',
        'KENDI',
        0,
        0,

        NULL,

        0,
        0,
        0,

        NULL,
        NULL,
        NULL,
        NULL,
        NULL,

        NULL,
        NULL,

        NULL,
        NULL,
        NULL,
        NULL,

        0,
        0,
        1,
        0,
        0,
        'FAT',

        {accountingCardType},
        {accountingCardCode}
    );
END
");
    }

    private static string Limit(string? value, int maxLength)
    {
        if (string.IsNullOrWhiteSpace(value))
            return "";

        value = value.Trim();

        return value.Length <= maxLength
            ? value
            : value[..maxLength];
    }

    private static string ResolveBankCode(string bankCode)
    {
        return bankCode switch
        {
            "QNBpay" => CP.VPOS.Services.BankService.QNBpay,
            "QNBFinansbank" => CP.VPOS.Services.BankService.QNBFinansbank,

            "KuveytTurk" => CP.VPOS.Services.BankService.KuveytTurk,
            "KuveytTürk" => CP.VPOS.Services.BankService.KuveytTurk,
            "KuveytTurkKatilim" => CP.VPOS.Services.BankService.KuveytTurk,

            "ZiraatBankasi" => CP.VPOS.Services.BankService.ZiraatBankasi,
            "GarantiBBVA" => CP.VPOS.Services.BankService.GarantiBBVA,
            "Akbank" => CP.VPOS.Services.BankService.Akbank,
            "Halkbank" => CP.VPOS.Services.BankService.Halkbank,
            "IsBankasi" => CP.VPOS.Services.BankService.IsBankasi,
            "YapiKrediBankasi" => CP.VPOS.Services.BankService.YapiKrediBankasi,
            _ => bankCode
        };
    }

    private static bool IsPaymentSuccess(string? responseStatus, string? responseMessage)
    {
        if (string.IsNullOrWhiteSpace(responseStatus))
            return false;

        if (responseStatus.Equals("Success", StringComparison.OrdinalIgnoreCase) ||
            responseStatus.Equals("Successful", StringComparison.OrdinalIgnoreCase) ||
            responseStatus.Equals("Approved", StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }

        if (!string.IsNullOrWhiteSpace(responseMessage))
        {
            var msg = responseMessage.ToLowerInvariant();

            if (msg.Contains("başarılı") ||
                msg.Contains("basarili") ||
                msg.Contains("approved") ||
                msg.Contains("success"))
            {
                return true;
            }
        }

        return false;
    }

    private CP.VPOS.Models.VirtualPOSAuth BuildVirtualPosAuth(B2BPosAccount posAccount)
    {
        return new CP.VPOS.Models.VirtualPOSAuth
        {
            bankCode = ResolveBankCode(posAccount.BankCode),
            merchantID = posAccount.MerchantId,
            merchantUser = posAccount.MerchantUser,
            merchantPassword = _encryptionService.Decrypt(posAccount.MerchantPasswordEncrypted),
            merchantStorekey = _encryptionService.Decrypt(posAccount.MerchantStoreKeyEncrypted),
            testPlatform = posAccount.TestPlatform
        };
    }

    private static string? GetPairValue(Dictionary<string, object> pairs, string key)
    {
        if (pairs.TryGetValue(key, out var value))
            return value?.ToString();

        var match = pairs.FirstOrDefault(x =>
            x.Key.Equals(key, StringComparison.OrdinalIgnoreCase));

        return match.Value?.ToString();
    }

    private static bool IsQnbPaymentSuccess(
        Dictionary<string, object> pairs,
        string? responseStatus,
        string? responseMessage)
    {
        var procReturnCode = GetPairValue(pairs, "ProcReturnCode");
        var txnResult = GetPairValue(pairs, "TxnResult");
        var threeDStatus = GetPairValue(pairs, "3DStatus");
        var d3Stat = GetPairValue(pairs, "D3Stat");

        var bankApproved =
            procReturnCode == "00" &&
            (
                txnResult?.Equals("Success", StringComparison.OrdinalIgnoreCase) == true ||
                txnResult?.Equals("Approved", StringComparison.OrdinalIgnoreCase) == true
            );

        var threeDSuccess =
            threeDStatus == "1" ||
            d3Stat?.Equals("Y", StringComparison.OrdinalIgnoreCase) == true;

        return bankApproved && threeDSuccess;
    }

    private static void NormalizeKuveytTurkCallbackPayload(Dictionary<string, object> pairs)
    {
        if (!pairs.TryGetValue("AuthenticationResponse", out var authResponseObj))
            return;

        var rawValue = authResponseObj?.ToString();

        if (string.IsNullOrWhiteSpace(rawValue))
            return;

        var trimmed = rawValue.Trim();

        // ASP.NET Core Request.Form zaten form-urlencoded veriyi decode eder.
        // Değer zaten XML ise ASLA tekrar UrlDecode yapma.
        // Özellikle MD içindeki '+' karakterlerini bozma.
        if (trimmed.StartsWith("<", StringComparison.OrdinalIgnoreCase))
        {
            pairs["AuthenticationResponse"] = trimmed;
            return;
        }

        // Sadece gerçekten encoded gelmişse decode et.
        var decodedValue = System.Net.WebUtility.UrlDecode(trimmed);

        if (string.IsNullOrWhiteSpace(decodedValue))
            return;

        decodedValue = decodedValue.Trim();

        if (decodedValue.StartsWith("<", StringComparison.OrdinalIgnoreCase))
        {
            pairs["AuthenticationResponse"] = decodedValue;
        }
    }

    private static ContentResult HtmlResult(string title, string message)
    {
        var safeTitle = System.Net.WebUtility.HtmlEncode(title);
        var safeMessage = System.Net.WebUtility.HtmlEncode(message);

        var html =
            "<!doctype html>" +
            "<html lang=\"tr\">" +
            "<head>" +
            "<meta charset=\"utf-8\">" +
            "<meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">" +
            "<title>" + safeTitle + "</title>" +
            "<style>" +
            "body { font-family: Arial, sans-serif; background: #f5f6f8; padding: 40px; }" +
            ".box { max-width: 560px; margin: 0 auto; background: white; border-radius: 12px; padding: 28px; box-shadow: 0 8px 24px rgba(0,0,0,.08); }" +
            "h2 { margin-top: 0; }" +
            "p { line-height: 1.5; }" +
            "</style>" +
            "</head>" +
            "<body>" +
            "<div class=\"box\">" +
            "<h2>" + safeTitle + "</h2>" +
            "<p>" + safeMessage + "</p>" +
            "</div>" +
            "</body>" +
            "</html>";

        return new ContentResult
        {
            Content = html,
            ContentType = "text/html; charset=utf-8",
            StatusCode = 200
        };
    }

    private static string MaskCardNumber(string? cardNumber)
    {
        if (string.IsNullOrWhiteSpace(cardNumber))
            return "";

        var digits = new string(cardNumber.Where(char.IsDigit).ToArray());

        if (digits.Length < 10)
            return "****";

        var bin = digits.Substring(0, 6);
        var last4 = digits.Substring(digits.Length - 4);

        return $"{bin}******{last4}";
    }

    private static string? MaskSensitiveJson(string? raw)
    {
        if (string.IsNullOrWhiteSpace(raw))
            return raw;

        var result = raw;

        result = System.Text.RegularExpressions.Regex.Replace(
            result,
            @"(?i)(""cardNumber""\s*:\s*"")[^""]+("")",
            "$1***MASKED***$2"
        );

        result = System.Text.RegularExpressions.Regex.Replace(
            result,
            @"(?i)(""cardCVV""\s*:\s*"")[^""]+("")",
            "$1***MASKED***$2"
        );

        result = System.Text.RegularExpressions.Regex.Replace(
            result,
            @"(?i)(""cvv""\s*:\s*"")[^""]+("")",
            "$1***MASKED***$2"
        );

        result = System.Text.RegularExpressions.Regex.Replace(
            result,
            @"\b\d{6}\d{5,9}\d{4}\b",
            match => MaskCardNumber(match.Value)
        );

        return result;
    }

    private sealed class PaymentCariInfo
    {
        public string CariKod { get; set; } = "";
        public string? Unvan { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? Tel { get; set; }
        public string? Cep { get; set; }
        public string? Email { get; set; }
    }

    private static string NormalizePhoneNumber(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return "";

        var digits = new string(value.Where(char.IsDigit).ToArray());

        if (digits.StartsWith("90") && digits.Length == 12)
            digits = digits[2..];

        if (digits.StartsWith("0") && digits.Length == 11)
            digits = digits[1..];

        return digits;
    }

    private async Task<PaymentCariInfo> GetPaymentCariInfoAsync(string cariKod)
    {
        var cari = await _context.CariKartListesis
            .AsNoTracking()
            .Where(x => x.Kod == cariKod && x.Sil == 0)
            .Select(x => new PaymentCariInfo
            {
                CariKod = x.Kod,
                Unvan = x.Unvan,
                Ad = x.Ad,
                Soyad = x.Soyad,
                Tel = x.Tel,
                Cep = x.Cep,
                Email = x.Mail
            })
            .FirstOrDefaultAsync();

        if (cari == null)
            throw new Exception($"Cari bulunamadı veya silinmiş: {cariKod}");

        return cari;
    }
}

