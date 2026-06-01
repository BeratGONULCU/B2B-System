using System.Security.Claims;
using AvmB2B.Api.Data;
using AvmB2B.Api.Entities;
using AvmB2B.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AvmB2B.Api.Controllers;

[ApiController]
[Authorize]
[Route("api/admin/management")]
public class AdminManagementController : ControllerBase
{
    private readonly PetrolDbContext _context;
    private readonly IEncryptionService _encryptionService;

    public AdminManagementController(
        PetrolDbContext context,
        IEncryptionService encryptionService)
    {
        _context = context;
        _encryptionService = encryptionService;
    }

    private bool IsAdmin()
    {
        return User.FindFirst("userType")?.Value == "Admin";
    }

    private int? GetUserId()
    {
        var userIdText = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (int.TryParse(userIdText, out var userId))
            return userId;

        return null;
    }

    /* ---------------------------------------------------------- */
    /* BANKA / POS HESAPLARI */
    /* ---------------------------------------------------------- */

    [HttpGet("pos-accounts")]
    public async Task<IActionResult> GetPosAccounts()
    {
        if (!IsAdmin())
            return Forbid();

        var data = await _context.B2BPosAccounts
            .AsNoTracking()
            .OrderByDescending(x => x.IsActive)
            .ThenBy(x => x.BankName)
            .Select(x => new
            {
                x.Id,
                x.BankCode,
                x.BankName,

                x.CustomerId,
                x.MerchantId,
                x.MerchantUser,

                HasMerchantPassword = !string.IsNullOrWhiteSpace(x.MerchantPasswordEncrypted),
                HasMerchantStoreKey = !string.IsNullOrWhiteSpace(x.MerchantStoreKeyEncrypted),

                x.TestPlatform,
                x.IsActive,
                x.ReturnUrl,

                x.PayGateUrl,
                x.ProvisionGateUrl,
                x.ApiVersion,
                x.CurrencyCode,
                x.TransactionSecurity,

                x.AccountingCardType,
                x.AccountingCardCode,
                x.AccountingDescription,

                x.CreatedAt,
                x.UpdatedAt
            })
            .ToListAsync();

        return Ok(data);
    }

    [HttpPost("pos-accounts")]
    public async Task<IActionResult> CreatePosAccount([FromBody] PosAccountSaveRequest request)
    {
        if (!IsAdmin())
            return Forbid();

        if (string.IsNullOrWhiteSpace(request.BankCode))
            return BadRequest("Banka kodu boş olamaz.");

        if (string.IsNullOrWhiteSpace(request.BankName))
            return BadRequest("Banka adı boş olamaz.");

        if (string.IsNullOrWhiteSpace(request.MerchantId))
            return BadRequest("MerchantId boş olamaz.");

        var bankCode = request.BankCode.Trim();

        var exists = await _context.B2BPosAccounts
            .AnyAsync(x => x.BankCode == bankCode);

        if (exists)
            return Conflict("Bu banka kodu için POS hesabı zaten var.");

        var posAccount = new B2BPosAccount
        {
            BankCode = bankCode,
            BankName = request.BankName.Trim(),

            CustomerId = request.CustomerId?.Trim(),

            MerchantId = request.MerchantId.Trim(),
            MerchantUser = request.MerchantUser?.Trim(),

            MerchantPasswordEncrypted = string.IsNullOrWhiteSpace(request.MerchantPassword)
        ? null
        : _encryptionService.Encrypt(request.MerchantPassword.Trim()),

            MerchantStoreKeyEncrypted = string.IsNullOrWhiteSpace(request.MerchantStoreKey)
        ? null
        : _encryptionService.Encrypt(request.MerchantStoreKey.Trim()),

            TestPlatform = request.TestPlatform,
            IsActive = request.IsActive,

            ReturnUrl = request.ReturnUrl?.Trim(),

            PayGateUrl = string.IsNullOrWhiteSpace(request.PayGateUrl)
        ? "https://sanalpos.kuveytturk.com.tr/ServiceGateWay/Home/ThreeDModelPayGate"
        : request.PayGateUrl.Trim(),

            ProvisionGateUrl = string.IsNullOrWhiteSpace(request.ProvisionGateUrl)
        ? "https://sanalpos.kuveytturk.com.tr/ServiceGateWay/Home/ThreeDModelProvisionGate"
        : request.ProvisionGateUrl.Trim(),

            ApiVersion = string.IsNullOrWhiteSpace(request.ApiVersion)
        ? "TDV2.0.0"
        : request.ApiVersion.Trim(),

            CurrencyCode = string.IsNullOrWhiteSpace(request.CurrencyCode)
        ? "0949"
        : request.CurrencyCode.Trim(),

            TransactionSecurity = request.TransactionSecurity ?? 3,

            AccountingCardType = request.AccountingCardType?.Trim(),
            AccountingCardCode = request.AccountingCardCode?.Trim(),
            AccountingDescription = request.AccountingDescription?.Trim(),

            CreatedAt = DateTime.Now
        };

        _context.B2BPosAccounts.Add(posAccount);
        await _context.SaveChangesAsync();

        return Ok(new
        {
            message = "POS hesabı oluşturuldu.",
            posAccount.Id,
            posAccount.BankCode,
            posAccount.BankName
        });
    }

    [HttpPut("pos-accounts/{id:int}")]
    public async Task<IActionResult> UpdatePosAccount(
        int id,
        [FromBody] PosAccountSaveRequest request)
    {
        if (!IsAdmin())
            return Forbid();

        var posAccount = await _context.B2BPosAccounts
            .FirstOrDefaultAsync(x => x.Id == id);

        if (posAccount == null)
            return NotFound("POS hesabı bulunamadı.");

        if (string.IsNullOrWhiteSpace(request.BankCode))
            return BadRequest("Banka kodu boş olamaz.");

        if (string.IsNullOrWhiteSpace(request.BankName))
            return BadRequest("Banka adı boş olamaz.");

        if (string.IsNullOrWhiteSpace(request.MerchantId))
            return BadRequest("MerchantId boş olamaz.");

        var bankCode = request.BankCode.Trim();

        var bankCodeExists = await _context.B2BPosAccounts
            .AnyAsync(x => x.Id != id && x.BankCode == bankCode);

        if (bankCodeExists)
            return Conflict("Bu banka kodu başka bir POS hesabında kullanılıyor.");

        posAccount.BankCode = bankCode;
        posAccount.BankName = request.BankName.Trim();
        posAccount.MerchantId = request.MerchantId.Trim();
        posAccount.MerchantUser = request.MerchantUser?.Trim();
        posAccount.TestPlatform = request.TestPlatform;
        posAccount.IsActive = request.IsActive;
        posAccount.ReturnUrl = request.ReturnUrl?.Trim();
        posAccount.UpdatedAt = DateTime.Now;

        if (request.CustomerId != null)
            posAccount.CustomerId = request.CustomerId.Trim();

        if (request.PayGateUrl != null)
            posAccount.PayGateUrl = request.PayGateUrl.Trim();

        if (request.ProvisionGateUrl != null)
            posAccount.ProvisionGateUrl = request.ProvisionGateUrl.Trim();

        if (request.ApiVersion != null)
            posAccount.ApiVersion = string.IsNullOrWhiteSpace(request.ApiVersion)
                ? "TDV2.0.0"
                : request.ApiVersion.Trim();

        if (request.CurrencyCode != null)
            posAccount.CurrencyCode = string.IsNullOrWhiteSpace(request.CurrencyCode)
                ? "0949"
                : request.CurrencyCode.Trim();

        if (request.TransactionSecurity.HasValue)
            posAccount.TransactionSecurity = request.TransactionSecurity.Value;

        if (request.AccountingCardType != null)
            posAccount.AccountingCardType = request.AccountingCardType.Trim();

        if (request.AccountingCardCode != null)
            posAccount.AccountingCardCode = request.AccountingCardCode.Trim();

        if (request.AccountingDescription != null)
            posAccount.AccountingDescription = request.AccountingDescription.Trim();

        if (!string.IsNullOrWhiteSpace(request.MerchantPassword))
        {
            posAccount.MerchantPasswordEncrypted =
                _encryptionService.Encrypt(request.MerchantPassword.Trim());
        }

        if (!string.IsNullOrWhiteSpace(request.MerchantStoreKey))
        {
            posAccount.MerchantStoreKeyEncrypted =
                _encryptionService.Encrypt(request.MerchantStoreKey.Trim());
        }

        await _context.SaveChangesAsync();

        return Ok(new
        {
            message = "POS hesabı güncellendi.",
            posAccount.Id,
            posAccount.BankCode,
            posAccount.BankName
        });
    }

    [HttpDelete("pos-accounts/{id:int}")]
    public async Task<IActionResult> DeletePosAccount(int id)
    {
        if (!IsAdmin())
            return Forbid();

        var posAccount = await _context.B2BPosAccounts
            .FirstOrDefaultAsync(x => x.Id == id);

        if (posAccount == null)
            return NotFound("POS hesabı bulunamadı.");

        posAccount.IsActive = false;
        posAccount.UpdatedAt = DateTime.Now;

        await _context.SaveChangesAsync();

        return Ok(new { message = "POS hesabı pasifleştirildi." });
    }

    /* ---------------------------------------------------------- */
    /* TAKSİT KURALLARI */
    /* ---------------------------------------------------------- */

    [HttpGet("installment-rules")]
    public async Task<IActionResult> GetInstallmentRules([FromQuery] int? posAccountId = null)
    {
        if (!IsAdmin())
            return Forbid();

        var query = _context.B2BPosInstallmentRules
            .AsNoTracking()
            .AsQueryable();

        if (posAccountId.HasValue)
            query = query.Where(x => x.PosAccountId == posAccountId.Value);

        var data = await query
            .Join(
                _context.B2BPosAccounts.AsNoTracking(),
                rule => rule.PosAccountId,
                pos => pos.Id,
                (rule, pos) => new
                {
                    rule.Id,
                    rule.PosAccountId,
                    pos.BankCode,
                    pos.BankName,
                    rule.Installment,
                    rule.MinAmount,
                    rule.MaxAmount,
                    rule.CommissionRate,
                    rule.IsActive,
                    rule.CreatedAt,
                    rule.UpdatedAt
                }
            )
            .OrderBy(x => x.BankName)
            .ThenBy(x => x.Installment)
            .ToListAsync();

        return Ok(data);
    }

    [HttpPost("installment-rules")]
    public async Task<IActionResult> CreateInstallmentRule([FromBody] InstallmentRuleSaveRequest request)
    {
        if (!IsAdmin())
            return Forbid();

        var validationResult = await ValidateInstallmentRuleRequest(request);

        if (validationResult != null)
            return validationResult;

        var exists = await _context.B2BPosInstallmentRules
            .AnyAsync(x =>
                x.PosAccountId == request.PosAccountId &&
                x.Installment == request.Installment);

        if (exists)
            return Conflict("Bu POS hesabı için aynı taksit kuralı zaten var.");

        var rule = new B2BPosInstallmentRule
        {
            PosAccountId = request.PosAccountId,
            Installment = request.Installment,
            MinAmount = request.MinAmount,
            MaxAmount = request.MaxAmount,
            CommissionRate = request.CommissionRate,
            IsActive = request.IsActive,
            CreatedAt = DateTime.Now
        };

        _context.B2BPosInstallmentRules.Add(rule);
        await _context.SaveChangesAsync();

        return Ok(new
        {
            message = "Taksit kuralı oluşturuldu.",
            rule.Id
        });
    }

    [HttpPut("installment-rules/{id:int}")]
    public async Task<IActionResult> UpdateInstallmentRule(
        int id,
        [FromBody] InstallmentRuleSaveRequest request)
    {
        if (!IsAdmin())
            return Forbid();

        var rule = await _context.B2BPosInstallmentRules
            .FirstOrDefaultAsync(x => x.Id == id);

        if (rule == null)
            return NotFound("Taksit kuralı bulunamadı.");

        var validationResult = await ValidateInstallmentRuleRequest(request);

        if (validationResult != null)
            return validationResult;

        var exists = await _context.B2BPosInstallmentRules
            .AnyAsync(x =>
                x.Id != id &&
                x.PosAccountId == request.PosAccountId &&
                x.Installment == request.Installment);

        if (exists)
            return Conflict("Bu POS hesabı için aynı taksit kuralı zaten var.");

        rule.PosAccountId = request.PosAccountId;
        rule.Installment = request.Installment;
        rule.MinAmount = request.MinAmount;
        rule.MaxAmount = request.MaxAmount;
        rule.CommissionRate = request.CommissionRate;
        rule.IsActive = request.IsActive;
        rule.UpdatedAt = DateTime.Now;

        await _context.SaveChangesAsync();

        return Ok(new
        {
            message = "Taksit kuralı güncellendi.",
            rule.Id
        });
    }

    [HttpDelete("installment-rules/{id:int}")]
    public async Task<IActionResult> DeleteInstallmentRule(int id)
    {
        if (!IsAdmin())
            return Forbid();

        var rule = await _context.B2BPosInstallmentRules
            .FirstOrDefaultAsync(x => x.Id == id);

        if (rule == null)
            return NotFound("Taksit kuralı bulunamadı.");

        rule.IsActive = false;
        rule.UpdatedAt = DateTime.Now;

        await _context.SaveChangesAsync();

        return Ok(new { message = "Taksit kuralı pasifleştirildi." });
    }

    private async Task<IActionResult?> ValidateInstallmentRuleRequest(
        InstallmentRuleSaveRequest request)
    {
        if (request.PosAccountId <= 0)
            return BadRequest("POS hesabı seçimi zorunludur.");

        var posExists = await _context.B2BPosAccounts
            .AnyAsync(x => x.Id == request.PosAccountId);

        if (!posExists)
            return NotFound("POS hesabı bulunamadı.");

        if (request.Installment < 1 || request.Installment > 15)
            return BadRequest("Taksit sayısı 1 ile 15 arasında olmalı.");

        if (request.MinAmount < 0)
            return BadRequest("Minimum tutar negatif olamaz.");

        if (request.MaxAmount.HasValue && request.MaxAmount.Value < request.MinAmount)
            return BadRequest("Maksimum tutar minimum tutardan küçük olamaz.");

        if (request.CommissionRate.HasValue && request.CommissionRate.Value < 0)
            return BadRequest("Komisyon oranı negatif olamaz.");

        return null;
    }

    /* ---------------------------------------------------------- */
    /* CARİ KİLİTLERİ */
    /* ---------------------------------------------------------- */

    [HttpGet("cari-locks")]
    public async Task<IActionResult> GetCariLocks(
        [FromQuery] string? search = null,
        [FromQuery] bool onlyLocked = false,
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 50)
    {
        if (!IsAdmin())
            return Forbid();

        if (page < 1) page = 1;
        if (pageSize < 1) pageSize = 50;
        if (pageSize > 500) pageSize = 500;

        var query =
            from l in _context.B2BCariLocks.AsNoTracking()
            join c in _context.CariKartListesis.AsNoTracking()
                on l.CariKod equals c.Kod into cariJoin
            from c in cariJoin.DefaultIfEmpty()
            select new
            {
                l.Id,
                l.CariKod,
                CariUnvan = c != null ? c.Unvan : null,
                CariAd = c != null ? c.Ad : null,
                CariSoyad = c != null ? c.Soyad : null,
                l.IsLocked,
                l.Reason,
                l.LockedByUserId,
                l.LockedAt,
                l.UnlockedByUserId,
                l.UnlockedAt
            };

        if (onlyLocked)
            query = query.Where(x => x.IsLocked);

        if (!string.IsNullOrWhiteSpace(search))
        {
            var s = search.Trim();

            query = query.Where(x =>
                x.CariKod.Contains(s) ||
                (x.CariUnvan != null && x.CariUnvan.Contains(s)) ||
                (x.CariAd != null && x.CariAd.Contains(s)) ||
                (x.CariSoyad != null && x.CariSoyad.Contains(s)));
        }

        var totalCount = await query.CountAsync();

        var data = await query
            .OrderByDescending(x => x.IsLocked)
            .ThenByDescending(x => x.LockedAt)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return Ok(new
        {
            page,
            pageSize,
            totalCount,
            data
        });
    }

    [HttpPost("cari-locks")]
    public async Task<IActionResult> LockCari([FromBody] CariLockSaveRequest request)
    {
        if (!IsAdmin())
            return Forbid();

        if (string.IsNullOrWhiteSpace(request.CariKod))
            return BadRequest("Cari kod boş olamaz.");

        var cariKod = request.CariKod.Trim();

        var cariExists = await _context.CariKartListesis
            .AsNoTracking()
            .AnyAsync(x => x.Kod == cariKod && x.Sil == 0);

        if (!cariExists)
            return NotFound("Cari bulunamadı.");

        var userId = GetUserId();

        var lockRecord = await _context.B2BCariLocks
            .FirstOrDefaultAsync(x => x.CariKod == cariKod);

        if (lockRecord == null)
        {
            lockRecord = new B2BCariLock
            {
                CariKod = cariKod,
                IsLocked = true,
                Reason = request.Reason?.Trim(),
                LockedByUserId = userId,
                LockedAt = DateTime.Now
            };

            _context.B2BCariLocks.Add(lockRecord);
        }
        else
        {
            lockRecord.IsLocked = true;
            lockRecord.Reason = request.Reason?.Trim();
            lockRecord.LockedByUserId = userId;
            lockRecord.LockedAt = DateTime.Now;
            lockRecord.UnlockedByUserId = null;
            lockRecord.UnlockedAt = null;
        }

        await _context.SaveChangesAsync();

        return Ok(new
        {
            message = "Cari ödeme işlemlerine kapatıldı.",
            lockRecord.CariKod,
            lockRecord.IsLocked,
            lockRecord.Reason
        });
    }

    [HttpPut("cari-locks/{cariKod}")]
    public async Task<IActionResult> UpdateCariLock(
        string cariKod,
        [FromBody] CariLockUpdateRequest request)
    {
        if (!IsAdmin())
            return Forbid();

        if (string.IsNullOrWhiteSpace(cariKod))
            return BadRequest("Cari kod boş olamaz.");

        var normalizedCariKod = cariKod.Trim();

        var lockRecord = await _context.B2BCariLocks
            .FirstOrDefaultAsync(x => x.CariKod == normalizedCariKod);

        if (lockRecord == null)
            return NotFound("Cari kilit kaydı bulunamadı.");

        var userId = GetUserId();

        if (request.IsLocked)
        {
            lockRecord.IsLocked = true;
            lockRecord.Reason = request.Reason?.Trim();
            lockRecord.LockedByUserId = userId;
            lockRecord.LockedAt = DateTime.Now;
            lockRecord.UnlockedByUserId = null;
            lockRecord.UnlockedAt = null;
        }
        else
        {
            lockRecord.IsLocked = false;
            lockRecord.Reason = request.Reason?.Trim();
            lockRecord.UnlockedByUserId = userId;
            lockRecord.UnlockedAt = DateTime.Now;
        }

        await _context.SaveChangesAsync();

        return Ok(new
        {
            message = request.IsLocked
                ? "Cari ödeme işlemlerine kapatıldı."
                : "Cari ödeme işlemlerine açıldı.",
            lockRecord.CariKod,
            lockRecord.IsLocked,
            lockRecord.Reason
        });
    }

    [HttpDelete("cari-locks/{cariKod}")]
    public async Task<IActionResult> UnlockCari(string cariKod)
    {
        if (!IsAdmin())
            return Forbid();

        if (string.IsNullOrWhiteSpace(cariKod))
            return BadRequest("Cari kod boş olamaz.");

        var normalizedCariKod = cariKod.Trim();

        var lockRecord = await _context.B2BCariLocks
            .FirstOrDefaultAsync(x => x.CariKod == normalizedCariKod);

        if (lockRecord == null)
            return NotFound("Cari kilit kaydı bulunamadı.");

        lockRecord.IsLocked = false;
        lockRecord.UnlockedByUserId = GetUserId();
        lockRecord.UnlockedAt = DateTime.Now;

        await _context.SaveChangesAsync();

        return Ok(new
        {
            message = "Cari ödeme işlemlerine açıldı.",
            lockRecord.CariKod,
            lockRecord.IsLocked
        });
    }

    /* ---------------------------------------------------------- */
    /* ÖDEME YÖNETİMİ */
    /* ---------------------------------------------------------- */

    [HttpGet("payments")]
    public async Task<IActionResult> GetPaymentsForManagement(
        [FromQuery] string? status = null,
        [FromQuery] string? cariKod = null,
        [FromQuery] string? bankCode = null,
        [FromQuery] DateTime? startDate = null,
        [FromQuery] DateTime? endDate = null,
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 50)
    {
        if (!IsAdmin())
            return Forbid();

        if (page < 1) page = 1;
        if (pageSize < 1) pageSize = 50;
        if (pageSize > 500) pageSize = 500;

        var query = _context.B2BPayments
            .AsNoTracking()
            .AsQueryable();

        if (!string.IsNullOrWhiteSpace(status))
        {
            var normalizedStatus = status.Trim();

            query = query.Where(x => x.Status == normalizedStatus);
        }

        if (!string.IsNullOrWhiteSpace(cariKod))
        {
            var normalizedCariKod = cariKod.Trim();

            query = query.Where(x => x.CariKod == normalizedCariKod);
        }

        if (!string.IsNullOrWhiteSpace(bankCode))
        {
            var normalizedBankCode = bankCode.Trim();

            query = query.Where(x => x.BankCode == normalizedBankCode);
        }

        if (startDate.HasValue)
            query = query.Where(x => x.CreatedAt >= startDate.Value);

        if (endDate.HasValue)
            query = query.Where(x => x.CreatedAt <= endDate.Value);

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
                x.PosAccountId,
                x.Installment,
                x.OrderNumber,
                x.BankTransactionId,
                x.CardBin,
                x.CardLast4,
                x.MaskedCardNo,
                x.BankResponseCode,
                x.BankResponseMessage,
                x.AuthCode,
                x.HostRefNo,
                x.ErrorMessage,
                x.CreatedAt,
                x.UpdatedAt,
                x.PaidAt,
                x.CallbackReceivedAt
            })
            .ToListAsync();

        var summary = await query
            .GroupBy(x => x.Status)
            .Select(g => new
            {
                status = g.Key,
                count = g.Count(),
                totalAmount = g.Sum(x => x.Amount)
            })
            .ToListAsync();

        return Ok(new
        {
            page,
            pageSize,
            totalCount,
            summary,
            data
        });
    }
}

/* ---------------------------------------------------------- */
/* REQUEST MODELLERİ */
/* ---------------------------------------------------------- */

public class PosAccountSaveRequest
{
    public string BankCode { get; set; } = string.Empty;
    public string BankName { get; set; } = string.Empty;

    public string? CustomerId { get; set; }

    public string MerchantId { get; set; } = string.Empty;
    public string? MerchantUser { get; set; }

    public string? MerchantPassword { get; set; }
    public string? MerchantStoreKey { get; set; }

    public bool TestPlatform { get; set; } = true;
    public bool IsActive { get; set; } = true;

    public string? ReturnUrl { get; set; }

    public string? PayGateUrl { get; set; }
    public string? ProvisionGateUrl { get; set; }
    public string? ApiVersion { get; set; }
    public string? CurrencyCode { get; set; }
    public int? TransactionSecurity { get; set; }

    public string? AccountingCardType { get; set; }
    public string? AccountingCardCode { get; set; }
    public string? AccountingDescription { get; set; }
}

public class InstallmentRuleSaveRequest
{
    public int PosAccountId { get; set; }
    public int Installment { get; set; } = 1;

    public decimal MinAmount { get; set; } = 0;
    public decimal? MaxAmount { get; set; }

    public decimal? CommissionRate { get; set; }

    public bool IsActive { get; set; } = true;
}

public class CariLockSaveRequest
{
    public string CariKod { get; set; } = string.Empty;
    public string? Reason { get; set; }
}

public class CariLockUpdateRequest
{
    public bool IsLocked { get; set; }
    public string? Reason { get; set; }
}