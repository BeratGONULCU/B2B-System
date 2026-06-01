namespace AvmB2B.Api.Entities;

public class B2BPosInstallmentRule
{
    public int Id { get; set; }

    public int PosAccountId { get; set; }

    public int Installment { get; set; }

    public decimal MinAmount { get; set; }

    public decimal? MaxAmount { get; set; }

    public decimal? CommissionRate { get; set; }

    public bool IsActive { get; set; } = true;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}