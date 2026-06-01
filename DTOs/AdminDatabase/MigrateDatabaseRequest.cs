namespace AvmB2B.Api.DTOs.AdminDatabase;

public class MigrateDatabaseRequest
{
    public string SourceDatabase { get; set; } = "";
    public string TargetDatabase { get; set; } = "";

    public bool ConfirmInvalidCariDataWillBeDeleted { get; set; }
    public bool ConfirmPaymentHistoryWillBeDeletedForInvalidCari { get; set; }
}