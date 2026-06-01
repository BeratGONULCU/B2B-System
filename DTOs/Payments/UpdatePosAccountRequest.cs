namespace AvmB2B.Api.DTOs.Payments;

public class UpdatePosAccountRequest
{
    public string BankName { get; set; } = "";

    public string CustomerId { get; set; } = "";

    public string MerchantId { get; set; } = "";
    public string MerchantUser { get; set; } = "";

    public string MerchantPassword { get; set; } = "";

    // Kuveyt Türk için zorunlu değil, diğer bankalar için kalabilir.
    public string MerchantStoreKey { get; set; } = "";

    public bool TestPlatform { get; set; } = true;
    public bool IsActive { get; set; } = true;

    public string ReturnUrl { get; set; } = "";

    public string PayGateUrl { get; set; } = "";
    public string ProvisionGateUrl { get; set; } = "";

    public string ApiVersion { get; set; } = "";
    public string CurrencyCode { get; set; } = "";
    public int? TransactionSecurity { get; set; }

    public string AccountingCardType { get; set; } = "";
    public string AccountingCardCode { get; set; } = "";
    public string AccountingDescription { get; set; } = "";
}