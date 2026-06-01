namespace AvmB2B.Api.Entities;

public class B2BPaymentLog
{
    public int Id { get; set; }

    public int? PaymentId { get; set; }

    public string Direction { get; set; } = null!;

    public string? LogType { get; set; }

    public string? RawData { get; set; }

    public bool? IsSuccess { get; set; }

    public string? ErrorCode { get; set; }

    public string? ErrorMessage { get; set; }

    public DateTime CreatedAt { get; set; }
}