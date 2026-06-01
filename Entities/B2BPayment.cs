namespace AvmB2B.Api.Entities;

public class B2BPayment
{
    public int Id { get; set; }

    public string PaymentNo { get; set; } = null!;

    public string CariKod { get; set; } = null!;

    public decimal Amount { get; set; }

    public string Currency { get; set; } = "TRY";

    public string Status { get; set; } = null!;

    public string? BankCode { get; set; }

    public int? PosAccountId { get; set; }

    public int Installment { get; set; } = 1;

    public string OrderNumber { get; set; } = null!;

    public string? BankTransactionId { get; set; }

    public string? ErrorMessage { get; set; }

    public string? CardBin { get; set; }

    public string? CardLast4 { get; set; }

    public string? MaskedCardNo { get; set; }

    public string? RedirectType { get; set; }

    public string? RedirectData { get; set; }

    public string? BankResponseCode { get; set; }

    public string? BankResponseMessage { get; set; }

    public string? AuthCode { get; set; }

    public string? HostRefNo { get; set; }

    // Ödemeyi B2B tarafında kim başlattı?
    // Callback anonymous geldiği için bu bilgiyi payment oluşturulurken saklıyoruz.
    public int? CreatedByUserId { get; set; }

    public string? CreatedByUsername { get; set; }

    public string? CreatedByUserType { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? PaidAt { get; set; }

    public DateTime? CallbackReceivedAt { get; set; }
}