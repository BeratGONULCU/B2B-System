namespace AvmB2B.Api.DTOs.Payments;

public class StartPaymentRequest
{
    public decimal Amount { get; set; }

    // Admin ödeme başlatıyorsa seçilen cari buradan gelir.
    // Cari kullanıcıysa token içindeki cariKod kullanılır.
    public string? CariKod { get; set; }

    public string? BankCode { get; set; }

    public int Installment { get; set; } = 1;

    public string CardHolderName { get; set; } = "";
    public string CardNumber { get; set; } = "";
    public int ExpireMonth { get; set; }
    public int ExpireYear { get; set; }
    public string Cvv { get; set; } = "";

    // Frontend ödeme ekranında girilen telefon.
    public string? PhoneNumber { get; set; }

    // Kuveyt Türk 3D Secure için zorunluysa frontend veya cari bilgisinden gelir.
    // 10 haneli VKN veya 11 haneli TCKN.
    public string? IdentityTaxNumber { get; set; }

    // Kuveyt Türk için: Troy, VISA, MasterCard
    public string? CardType { get; set; }
}


