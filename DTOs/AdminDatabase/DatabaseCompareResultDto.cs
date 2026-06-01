namespace AvmB2B.Api.DTOs.AdminDatabase;

public class DatabaseCompareResultDto
{
    public string SourceDatabase { get; set; } = "";
    public string TargetDatabase { get; set; } = "";

    public int SourceCariKartListesiCount { get; set; }
    public int TargetCariKartListesiCount { get; set; }

    public int SourceCarikartCount { get; set; }
    public int TargetCarikartCount { get; set; }

    public int B2BUsersTotal { get; set; }
    public int B2BUsersMissingInTargetCariSources { get; set; }

    public int B2BCariLocksTotal { get; set; }
    public int B2BCariLocksMissingInTargetCariSources { get; set; }

    public int B2BPaymentsTotal { get; set; }
    public int B2BPaymentsMissingInTargetCariSources { get; set; }

    public int B2BPaymentLogsWillBeDeleted { get; set; }

    public List<string> Warnings { get; set; } = new();
}