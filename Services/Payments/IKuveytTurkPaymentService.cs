namespace AvmB2B.Api.Services.Payments;

public interface IKuveytTurkPaymentService
{
    Task<KuveytTurk3DStartResponse> Start3DAsync(
        KuveytTurk3DStartRequest request,
        CancellationToken cancellationToken = default
    );

    Task<KuveytTurk3DConfirmResponse> Confirm3DAsync(
        KuveytTurk3DConfirmRequest request,
        CancellationToken cancellationToken = default
    );
}

public sealed class KuveytTurk3DStartRequest
{
    public bool TestPlatform { get; set; }

    public string MerchantId { get; set; } = "";
    public string CustomerId { get; set; } = "";
    public string UserName { get; set; } = "";
    public string Password { get; set; } = "";

    public string CardNumber { get; set; } = "";
    public string CardHolderName { get; set; } = "";
    public int ExpireMonth { get; set; }
    public int ExpireYear { get; set; }
    public string Cvv { get; set; } = "";
    public string CardType { get; set; } = "MasterCard";

    public decimal Amount { get; set; }
    public int Installment { get; set; }

    public string OrderNumber { get; set; } = "";
    public string ReturnUrl { get; set; } = "";
    public string ClientIp { get; set; } = "127.0.0.1";
    public string Description { get; set; } = "B2B Odeme";

    public string? IdentityTaxNumber { get; set; }

    // Bunlar artık test veriyle dolu gelmeyecek.
    // Frontend veya cari kaydından hazırlanıp controller'dan gönderilecek.
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }

    // Elimizde net adres alanları yoksa XML'e hiç basmayacağız.
    public string? AddressLine { get; set; }
    public string? City { get; set; }
    public string? PostCode { get; set; }
    public string? StateCode { get; set; }
}

public sealed class KuveytTurk3DStartResponse
{
    public bool IsSuccess { get; set; }
    public string? DebugRequestXml { get; set; }
    public bool IsRedirectHtml { get; set; }
    public string Status { get; set; } = "Error";
    public string Message { get; set; } = "";
    public string RawResponse { get; set; } = "";
    public string? ResponseCode { get; set; }
}

public sealed class KuveytTurk3DConfirmRequest
{
    public bool TestPlatform { get; set; }

    public string MerchantId { get; set; } = "";
    public string CustomerId { get; set; } = "";
    public string UserName { get; set; } = "";
    public string Password { get; set; } = "";

    // Provision hash için DB'deki orijinal sipariş no kullanılacak.
    // Callback içinden gelen MerchantOrderId bazen maskeli geliyor.
    public string OrderNumber { get; set; } = "";

    // Provision hash için DB'deki ödeme tutarı kullanılacak.
    public decimal Amount { get; set; }

    // Tek çekim bankaya 0 gönderilecek.
    public int Installment { get; set; }

    public string CurrencyCode { get; set; } = "0949";
    public int TransactionSecurity { get; set; } = 3;

    public string Description { get; set; } = "B2B Odeme";

    public Dictionary<string, object> ResponseData { get; set; } = new();
}

public sealed class KuveytTurk3DConfirmResponse
{
    public bool IsSuccess { get; set; }
    public string Status { get; set; } = "Error";
    public string Message { get; set; } = "";

    public string? ResponseCode { get; set; }
    public string? MerchantOrderId { get; set; }
    public string? OrderId { get; set; }
    public string? ProvisionNumber { get; set; }
    public string? TransactionId { get; set; }
    public string? AuthCode { get; set; }
    public string? HostRefNo { get; set; }
    public string? RawAuthenticationResponseXml { get; set; }
    public string? RawProvisionResponseXml { get; set; }
    public string? DebugProvisionRequestXml { get; set; }
}