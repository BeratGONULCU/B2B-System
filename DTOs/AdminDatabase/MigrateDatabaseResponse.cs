namespace AvmB2B.Api.DTOs.AdminDatabase;

public class MigrateDatabaseResponse
{
    public bool Success { get; set; }
    public string Message { get; set; } = "";
    public int? MigrationHistoryId { get; set; }
    public int WarningCount { get; set; }
}