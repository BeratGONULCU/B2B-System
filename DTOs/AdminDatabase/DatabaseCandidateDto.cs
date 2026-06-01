namespace AvmB2B.Api.DTOs.AdminDatabase;

public class DatabaseCandidateDto
{
    public string DatabaseName { get; set; } = "";
    public bool IsCurrent { get; set; }
    public bool HasOpenNotification { get; set; }
}