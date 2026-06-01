namespace AvmB2B.Api.Entities;

public class B2BInstallmentAllowedBin
{
    public int Id { get; set; }

    public string BankCode { get; set; } = string.Empty;

    public string BankName { get; set; } = string.Empty;

    public string BinPrefix { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;

    public string? Note { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime? UpdatedAt { get; set; }
}