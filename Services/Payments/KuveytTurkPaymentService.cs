using System.Globalization;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace AvmB2B.Api.Services.Payments;

public sealed class KuveytTurkPaymentService : IKuveytTurkPaymentService
{
    private readonly HttpClient _httpClient;

    private const string TestThreeDModelPayGateUrl =
        "https://boatest.kuveytturk.com.tr/boa.virtualpos.services/Home/ThreeDModelPayGate";

    private const string TestThreeDModelProvisionGateUrl =
        "https://boatest.kuveytturk.com.tr/boa.virtualpos.services/Home/ThreeDModelProvisionGate";

    private const string LiveThreeDModelPayGateUrl =
        "https://sanalpos.kuveytturk.com.tr/ServiceGateWay/Home/ThreeDModelPayGate";

    private const string LiveThreeDModelProvisionGateUrl =
        "https://sanalpos.kuveytturk.com.tr/ServiceGateWay/Home/ThreeDModelProvisionGate";

    public KuveytTurkPaymentService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<KuveytTurk3DStartResponse> Start3DAsync(
        KuveytTurk3DStartRequest request,
        CancellationToken cancellationToken = default)
    {
        var amountText = FormatAmountForKuveyt(request.Amount);
        var xml = BuildStart3DXml(request, amountText);

        WriteDebugXmlFile("kuveyt-paygate-request.xml", xml);

        // Geçici debug için.
        // Kart/CVV/HashData maskeli şekilde controller'a döndürülebilir.
        var maskedRequestXml = MaskSensitiveXml(xml);

        var url = request.TestPlatform
            ? TestThreeDModelPayGateUrl
            : LiveThreeDModelPayGateUrl;

        var rawResponse = await PostXmlAsync(url, xml, cancellationToken);

        var isRedirectHtml = IsRedirectHtml(rawResponse);

        if (isRedirectHtml)
        {
            return new KuveytTurk3DStartResponse
            {
                IsSuccess = true,
                IsRedirectHtml = true,
                Status = "RedirectHTML",
                Message = "3D doğrulama ekranı oluşturuldu.",
                RawResponse = rawResponse,
                DebugRequestXml = maskedRequestXml
            };
        }

        var responseCode = TryGetXmlValue(rawResponse, "ResponseCode");
        var responseMessage = TryGetXmlValue(rawResponse, "ResponseMessage");

        if (string.IsNullOrWhiteSpace(responseMessage))
            responseMessage = rawResponse;

        return new KuveytTurk3DStartResponse
        {
            IsSuccess = false,
            IsRedirectHtml = false,
            Status = "Error",
            ResponseCode = responseCode,
            Message = responseMessage,
            RawResponse = rawResponse,
            DebugRequestXml = maskedRequestXml
        };
    }

    public async Task<KuveytTurk3DConfirmResponse> Confirm3DAsync(
        KuveytTurk3DConfirmRequest request,
        CancellationToken cancellationToken = default)
    {
        var authenticationResponse = GetPairValue(request.ResponseData, "AuthenticationResponse");

        if (string.IsNullOrWhiteSpace(authenticationResponse))
        {
            return new KuveytTurk3DConfirmResponse
            {
                IsSuccess = false,
                Status = "Error",
                Message = "AuthenticationResponse bulunamadı."
            };
        }

        authenticationResponse = DecodeXmlIfNeeded(authenticationResponse);

        XDocument authDoc;

        try
        {
            authDoc = XDocument.Parse(authenticationResponse);
        }
        catch (Exception ex)
        {
            return new KuveytTurk3DConfirmResponse
            {
                IsSuccess = false,
                Status = "Error",
                Message = "AuthenticationResponse XML okunamadı: " + ex.Message,
                RawAuthenticationResponseXml = authenticationResponse
            };
        }

        var authResponseCode = GetXmlValue(authDoc, "ResponseCode");
        var authResponseMessage = GetXmlValue(authDoc, "ResponseMessage");
        var merchantOrderId = GetXmlValue(authDoc, "MerchantOrderId");
        var md = GetXmlValue(authDoc, "MD");

        if (authResponseCode != "00")
        {
            return new KuveytTurk3DConfirmResponse
            {
                IsSuccess = false,
                Status = "Error",
                ResponseCode = authResponseCode,
                Message = string.IsNullOrWhiteSpace(authResponseMessage)
                    ? "3D doğrulama başarısız."
                    : authResponseMessage,
                MerchantOrderId = merchantOrderId,
                RawAuthenticationResponseXml = authenticationResponse
            };
        }

        var vposMessage = authDoc
            .Descendants()
            .FirstOrDefault(x => x.Name.LocalName == "VPosMessage");

        if (vposMessage == null)
        {
            return new KuveytTurk3DConfirmResponse
            {
                IsSuccess = false,
                Status = "Error",
                ResponseCode = authResponseCode,
                Message = "VPosMessage bulunamadı.",
                MerchantOrderId = merchantOrderId,
                RawAuthenticationResponseXml = authenticationResponse
            };
        }

        if (string.IsNullOrWhiteSpace(md))
        {
            return new KuveytTurk3DConfirmResponse
            {
                IsSuccess = false,
                Status = "Error",
                ResponseCode = authResponseCode,
                Message = "MD bilgisi bulunamadı.",
                MerchantOrderId = merchantOrderId,
                RawAuthenticationResponseXml = authenticationResponse
            };
        }

        var provisionMerchantId = string.IsNullOrWhiteSpace(request.MerchantId)
            ? GetXmlValue(vposMessage, "MerchantId") ?? ""
            : request.MerchantId;

        var provisionCustomerId = string.IsNullOrWhiteSpace(request.CustomerId)
            ? GetXmlValue(vposMessage, "CustomerId") ?? ""
            : request.CustomerId;

        var provisionOrderNumber = request.OrderNumber;

        var provisionAmount = FormatAmountForKuveyt(request.Amount);

        var provisionInstallmentCount = request.Installment.ToString(CultureInfo.InvariantCulture);

        var provisionCurrencyCode = string.IsNullOrWhiteSpace(request.CurrencyCode)
            ? "0949"
            : request.CurrencyCode;

        var provisionTransactionSecurity = request.TransactionSecurity.ToString(CultureInfo.InvariantCulture);

        var provisionXml = BuildProvisionXml(
            request,
            provisionMerchantId,
            provisionCustomerId,
            provisionOrderNumber,
            provisionAmount,
            provisionInstallmentCount,
            provisionCurrencyCode,
            provisionTransactionSecurity,
            md
        );

        var maskedProvisionXml = MaskSensitiveXml(provisionXml);

        var provisionUrl = request.TestPlatform
            ? TestThreeDModelProvisionGateUrl
            : LiveThreeDModelProvisionGateUrl;

        var provisionRawResponse = await PostXmlAsync(provisionUrl, provisionXml, cancellationToken);

        XDocument provisionDoc;

        try
        {
            provisionDoc = XDocument.Parse(provisionRawResponse);
        }
        catch (Exception ex)
        {
            return new KuveytTurk3DConfirmResponse
            {
                IsSuccess = false,
                Status = "Error",
                Message = "Provision XML okunamadı: " + ex.Message,
                MerchantOrderId = merchantOrderId,
                RawAuthenticationResponseXml = authenticationResponse,
                RawProvisionResponseXml = provisionRawResponse
            };
        }

        var provisionResponseCode = GetXmlValue(provisionDoc, "ResponseCode");
        var provisionResponseMessage = GetXmlValue(provisionDoc, "ResponseMessage");
        var provisionNumber = GetXmlValue(provisionDoc, "ProvisionNumber");
        var orderId = GetXmlValue(provisionDoc, "OrderId");

        var isSuccess = provisionResponseCode == "00";

        var transactionId = string.Join("|", new[]
        {
            provisionNumber,
            orderId
        }.Where(x => !string.IsNullOrWhiteSpace(x)));

        return new KuveytTurk3DConfirmResponse
        {
            IsSuccess = isSuccess,
            Status = isSuccess ? "Success" : "Error",
            ResponseCode = provisionResponseCode,
            Message = isSuccess
        ? "İşlem başarıyla tamamlandı."
        : string.IsNullOrWhiteSpace(provisionResponseMessage)
            ? "Provision işlemi başarısız."
            : provisionResponseMessage,
            MerchantOrderId = merchantOrderId,
            OrderId = orderId,
            ProvisionNumber = provisionNumber,
            TransactionId = transactionId,
            AuthCode = provisionNumber,
            HostRefNo = orderId,
            RawAuthenticationResponseXml = authenticationResponse,
            RawProvisionResponseXml = provisionRawResponse,
            DebugProvisionRequestXml = maskedProvisionXml
        };
    }

    private static string MaskSensitiveXml(string xml)
    {
        if (string.IsNullOrWhiteSpace(xml))
            return xml;

        xml = ReplaceBetween(xml, "<CardNumber>", "</CardNumber>", "****MASKED****");
        xml = ReplaceBetween(xml, "<CardCVV2>", "</CardCVV2>", "***");
        xml = ReplaceBetween(xml, "<HashData>", "</HashData>", "***HASH_MASKED***");

        return xml;
    }

    private static string ReplaceBetween(string source, string start, string end, string replacement)
    {
        if (string.IsNullOrEmpty(source))
            return source;

        var startIndex = source.IndexOf(start, StringComparison.OrdinalIgnoreCase);

        if (startIndex < 0)
            return source;

        startIndex += start.Length;

        var endIndex = source.IndexOf(end, startIndex, StringComparison.OrdinalIgnoreCase);

        if (endIndex < 0)
            return source;

        return source[..startIndex] + replacement + source[endIndex..];
    }



    private static string BuildStart3DXml(KuveytTurk3DStartRequest request, string amountText)
    {
        var merchantId = request.MerchantId.Trim();
        var customerId = request.CustomerId.Trim();
        var userName = request.UserName.Trim();
        var password = request.Password.Trim();
        var orderNumber = request.OrderNumber.Trim();
        var returnUrl = request.ReturnUrl.Trim();

        var expireYear = (request.ExpireYear % 100).ToString("00");
        var expireMonth = request.ExpireMonth.ToString("00");

        var installmentCount = request.Installment > 1
            ? request.Installment.ToString(CultureInfo.InvariantCulture)
            : "0";

        var phoneSubscriber = NormalizePhoneSubscriber(request.PhoneNumber);
        var identityTaxNumber = NormalizeIdentityTaxNumber(request.IdentityTaxNumber);

        var hashedPassword = SHA1Base64Utf8(password);

        var hashData = SHA1Base64Iso88599(
            merchantId +
            orderNumber +
            amountText +
            returnUrl +
            returnUrl +
            userName +
            hashedPassword
        );

        var doc = new XDocument(
            new XDeclaration("1.0", "utf-8", null),
            new XElement("KuveytTurkVPosMessage",
                new XAttribute(XNamespace.Xmlns + "xsi", "http://www.w3.org/2001/XMLSchema-instance"),
                new XAttribute(XNamespace.Xmlns + "xsd", "http://www.w3.org/2001/XMLSchema"),

                new XElement("APIVersion", "TDV2.0.0"),
                new XElement("OkUrl", returnUrl),
                new XElement("FailUrl", returnUrl),
                new XElement("HashData", hashData),

                new XElement("MerchantId", merchantId),
                new XElement("CustomerId", customerId),
                new XElement("UserName", userName),

                new XElement("CardNumber", request.CardNumber),
                new XElement("CardExpireDateYear", expireYear),
                new XElement("CardExpireDateMonth", expireMonth),
                new XElement("CardCVV2", request.Cvv),
                new XElement("CardHolderName", request.CardHolderName),
                new XElement("CardType", NormalizeCardType(request.CardType, request.CardNumber)),

                new XElement("BatchID", "0"),
                new XElement("TransactionType", "Sale"),
                new XElement("InstallmentCount", installmentCount),
                new XElement("Amount", amountText),
                new XElement("DisplayAmount", amountText),
                new XElement("CurrencyCode", "0949"),
                new XElement("MerchantOrderId", orderNumber),
                new XElement("Description", MaxLength(request.Description, 100)),
                new XElement("TransactionSecurity", "3"),

                new XElement("IdentityTaxNumber", identityTaxNumber),

                new XElement("DeviceData",
                    new XElement("DeviceChannel", "02"),
                    new XElement("ClientIP", string.IsNullOrWhiteSpace(request.ClientIp) ? "78.189.16.216" : request.ClientIp)),

                new XElement("CardHolderData",
                    new XElement("BillAddrCity", MaxLength(request.City, 50)),
                    new XElement("BillAddrCountry", "792"),
                    new XElement("BillAddrLine1", MaxLength(request.AddressLine, 150)),
                    new XElement("BillAddrPostCode", request.PostCode),
                    new XElement("BillAddrState", request.StateCode),
                    new XElement("IdentityTaxNumber", identityTaxNumber),
                    new XElement("Email", request.Email),
                    new XElement("MobilePhone",
                        new XElement("Cc", "90"),
                        new XElement("Subscriber", phoneSubscriber)
                    )
                )
            )
        );

        return doc.ToString(SaveOptions.DisableFormatting);
    }

    private static string BuildProvisionXml(
    KuveytTurk3DConfirmRequest request,
    string merchantId,
    string customerId,
    string merchantOrderId,
    string amount,
    string installmentCount,
    string currencyCode,
    string transactionSecurity,
    string md)
    {
        var safeMerchantId = string.IsNullOrWhiteSpace(merchantId)
            ? request.MerchantId.Trim()
            : merchantId.Trim();

        var safeCustomerId = string.IsNullOrWhiteSpace(customerId)
            ? request.CustomerId.Trim()
            : customerId.Trim();

        var safeUserName = request.UserName.Trim();
        var safePassword = request.Password.Trim();

        var safeCurrencyCode = string.IsNullOrWhiteSpace(currencyCode)
            ? "0949"
            : currencyCode.Trim();

        var safeTransactionSecurity = string.IsNullOrWhiteSpace(transactionSecurity)
            ? "3"
            : transactionSecurity.Trim();

        var safeMerchantOrderId = merchantOrderId.Trim();

        var hashedPassword = SHA1Base64Utf8(safePassword);

        var hashData = SHA1Base64Iso88599(
            safeMerchantId +
            safeMerchantOrderId +
            amount +
            safeUserName +
            hashedPassword
        );

        var doc = new XDocument(
            new XDeclaration("1.0", "utf-8", null),
            new XElement("KuveytTurkVPosMessage",
                new XAttribute(XNamespace.Xmlns + "xsi", "http://www.w3.org/2001/XMLSchema-instance"),
                new XAttribute(XNamespace.Xmlns + "xsd", "http://www.w3.org/2001/XMLSchema"),

                new XElement("APIVersion", "TDV2.0.0"),
                new XElement("HashData", hashData),
                new XElement("MerchantId", safeMerchantId),
                new XElement("CustomerId", safeCustomerId),
                new XElement("UserName", safeUserName),
                new XElement("CurrencyCode", safeCurrencyCode),
                new XElement("TransactionType", "Sale"),
                new XElement("InstallmentCount", installmentCount),
                new XElement("Amount", amount),
                new XElement("MerchantOrderId", safeMerchantOrderId),
                new XElement("TransactionSecurity", safeTransactionSecurity),

                new XElement("KuveytTurkVPosAdditionalData",
                    new XElement("AdditionalData",
                        new XElement("Key", "MD"),
                        new XElement("Data", md)
                    )
                )
            )
        );

        return doc.ToString(SaveOptions.DisableFormatting);
    }

    private static void ValidateRequiredStartRequest(KuveytTurk3DStartRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Email))
            throw new Exception("Kuveyt Türk Email alanı zorunludur.");

        if (string.IsNullOrWhiteSpace(request.PhoneNumber))
            throw new Exception("Kuveyt Türk telefon alanı zorunludur.");

        if (string.IsNullOrWhiteSpace(request.AddressLine))
            throw new Exception("Kuveyt Türk adres alanı zorunludur.");

        if (string.IsNullOrWhiteSpace(request.City))
            throw new Exception("Kuveyt Türk şehir alanı zorunludur.");

        if (string.IsNullOrWhiteSpace(request.PostCode))
            throw new Exception("Kuveyt Türk posta kodu zorunludur.");

        if (string.IsNullOrWhiteSpace(request.StateCode))
            throw new Exception("Kuveyt Türk il kodu zorunludur.");
    }

    private async Task<string> PostXmlAsync(
        string url,
        string xml,
        CancellationToken cancellationToken)
    {
        using var content = new StringContent(xml, Encoding.UTF8, "application/xml");

        using var response = await _httpClient.PostAsync(url, content, cancellationToken);
        var responseBody = await response.Content.ReadAsStringAsync(cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            return $"HTTP {(int)response.StatusCode} {response.ReasonPhrase} - {responseBody}";
        }

        return responseBody;
    }

    private static string FormatAmountForKuveyt(decimal amount)
    {
        return ((long)Math.Round(amount * 100M, 0, MidpointRounding.AwayFromZero))
            .ToString(CultureInfo.InvariantCulture);
    }

    private static string ComputeProvisionHash(
    string merchantId,
    string merchantOrderId,
    string amountText,
    string userName,
    string password)
    {
        using var sha = SHA1.Create();

        var hashedPassword = Convert.ToBase64String(
            sha.ComputeHash(Encoding.UTF8.GetBytes(password))
        );

        var hashString =
            merchantId +
            merchantOrderId +
            amountText +
            userName +
            hashedPassword;

        var hashBytes = Encoding
            .GetEncoding("ISO-8859-9")
            .GetBytes(hashString);

        return Convert.ToBase64String(sha.ComputeHash(hashBytes));
    }

    private static string SHA1Base64Utf8(string text)
    {
        using var sha = SHA1.Create();

        var bytes = Encoding.UTF8.GetBytes(text ?? "");
        var hashBytes = sha.ComputeHash(bytes);

        return Convert.ToBase64String(hashBytes);
    }

    private static string SHA1Base64Iso88599(string text)
    {
        using var sha = SHA1.Create();

        var bytes = Encoding
            .GetEncoding("ISO-8859-9")
            .GetBytes(text ?? "");

        var hashBytes = sha.ComputeHash(bytes);

        return Convert.ToBase64String(hashBytes);
    }

    private static bool IsRedirectHtml(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return false;

        return value.Contains("<html", StringComparison.OrdinalIgnoreCase) ||
               value.Contains("<form", StringComparison.OrdinalIgnoreCase) ||
               value.Contains("<!doctype", StringComparison.OrdinalIgnoreCase);
    }

    private static string? TryGetXmlValue(string rawXml, string elementName)
    {
        try
        {
            var doc = XDocument.Parse(rawXml);
            return GetXmlValue(doc, elementName);
        }
        catch
        {
            return null;
        }
    }

    private static string? GetXmlValue(XDocument doc, string elementName)
    {
        return doc
            .Descendants()
            .FirstOrDefault(x => x.Name.LocalName.Equals(elementName, StringComparison.OrdinalIgnoreCase))
            ?.Value;
    }

    private static string? GetXmlValue(XElement element, string elementName)
    {
        return element
            .Descendants()
            .FirstOrDefault(x => x.Name.LocalName.Equals(elementName, StringComparison.OrdinalIgnoreCase))
            ?.Value;
    }

    private static string? GetPairValue(Dictionary<string, object> pairs, string key)
    {
        if (pairs.TryGetValue(key, out var value))
            return value?.ToString();

        var match = pairs.FirstOrDefault(x =>
            x.Key.Equals(key, StringComparison.OrdinalIgnoreCase));

        return match.Value?.ToString();
    }

    private static string DecodeXmlIfNeeded(string value)
    {
        var trimmed = value.Trim();

        if (trimmed.StartsWith("<"))
            return trimmed;

        var decoded = WebUtility.UrlDecode(trimmed);

        return string.IsNullOrWhiteSpace(decoded)
            ? trimmed
            : decoded.Trim();
    }

    private static string NormalizeCardType(string? cardType, string? cardNumber = null)
    {
        var number = OnlyDigits(cardNumber);

        // Kart numarasından otomatik tespit en güvenlisi.
        if (number.StartsWith("4"))
            return "Visa";

        if (number.StartsWith("5") || number.StartsWith("2"))
            return "MasterCard";

        if (number.StartsWith("9792") || number.StartsWith("65"))
            return "Troy";

        // Kart numarası boşsa frontend/cardType değerine bak.
        var value = (cardType ?? "").Trim();

        if (value.Equals("Visa", StringComparison.OrdinalIgnoreCase) ||
            value.Equals("VISA", StringComparison.OrdinalIgnoreCase))
            return "Visa";

        if (value.Equals("MasterCard", StringComparison.OrdinalIgnoreCase) ||
            value.Equals("Master", StringComparison.OrdinalIgnoreCase))
            return "MasterCard";

        if (value.Equals("Troy", StringComparison.OrdinalIgnoreCase) ||
            value.Equals("TROY", StringComparison.OrdinalIgnoreCase))
            return "Troy";

        return "MasterCard";
    }

    private static string OnlyDigits(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return "";

        return new string(value.Where(char.IsDigit).ToArray());
    }

    private static string NormalizePhoneSubscriber(string? value)
    {
        var digits = new string((value ?? "").Where(char.IsDigit).ToArray());

        if (digits.StartsWith("90") && digits.Length > 10)
            digits = digits[^10..];

        if (digits.Length > 10)
            digits = digits[^10..];

        if (digits.Length == 10)
            return digits;

        return "5551234567";
    }

    private static string NormalizeIdentityTaxNumber(string? value)
    {
        var digits = new string((value ?? "").Where(char.IsDigit).ToArray());

        if (digits.Length == 10 || digits.Length == 11)
            return digits;

        // Kuveyt Türk test için geçerli TCKN fallback.
        return "11111111110";
    }

    private static string MaxLength(string? value, int maxLength)
    {
        if (string.IsNullOrWhiteSpace(value))
            return "";

        value = value.Trim();

        return value.Length <= maxLength
            ? value
            : value[..maxLength];
    }

    private static void WriteDebugXmlFile(string fileName, string xml)
    {
        try
        {
            var logDirectory = @"C:\AvmB2B.Api\logs";

            Directory.CreateDirectory(logDirectory);

            var path = Path.Combine(logDirectory, fileName);

            var maskedXml = MaskSensitiveXml2(xml);

            File.WriteAllText(path, maskedXml, Encoding.UTF8);
        }
        catch
        {
            // Debug dosyası yazılamazsa ödeme akışını bozmasın.
        }
    }

    private static string MaskSensitiveXml2(string xml)
    {
        if (string.IsNullOrWhiteSpace(xml))
            return xml;

        xml = Regex.Replace(
            xml,
            @"<CardNumber>.*?</CardNumber>",
            "<CardNumber>************</CardNumber>",
            RegexOptions.IgnoreCase | RegexOptions.Singleline
        );

        xml = Regex.Replace(
            xml,
            @"<CardCVV2>.*?</CardCVV2>",
            "<CardCVV2>***</CardCVV2>",
            RegexOptions.IgnoreCase | RegexOptions.Singleline
        );

        return xml;
    }

}