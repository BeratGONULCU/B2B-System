namespace AvmB2B.Api.Entities;

public class B2BPosAccount
{
    public int Id { get; set; }

    public string BankCode { get; set; } = null!;
    public string BankName { get; set; } = null!;

    public string? CustomerId { get; set; }

    public string MerchantId { get; set; } = null!;
    public string? MerchantUser { get; set; }

    public string? MerchantPasswordEncrypted { get; set; }

    // Kuveyt Türk için kullanılmayacak ama başka bankalar için kalabilir.
    public string? MerchantStoreKeyEncrypted { get; set; }

    public bool TestPlatform { get; set; } = true;
    public bool IsActive { get; set; } = true;

    public string? ReturnUrl { get; set; }
    // carihrk için işletme kredi kartı / POS karşı hesap bilgisi.
    // Örnek: istkart / KART0012 veya istkart / 4289450103440518
    public string? PayGateUrl { get; set; }
    public string? ProvisionGateUrl { get; set; }

    public string? ApiVersion { get; set; }
    public string? CurrencyCode { get; set; }
    public int? TransactionSecurity { get; set; }

    public string? AccountingCardType { get; set; } = "istkart";
    public string? AccountingCardCode { get; set; }
    public string? AccountingDescription { get; set; } = "K.KARTI";

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
