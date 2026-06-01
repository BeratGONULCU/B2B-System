namespace AvmB2B.Api.DTOs.AdminDatabase;

public class DatabaseNotificationDto
{
    public int Id { get; set; }
    public string DatabaseName { get; set; } = "";
    public string ChangeType { get; set; } = "";
    public string Title { get; set; } = "";
    public string Message { get; set; } = "";
    public bool IsRequiredAction { get; set; }
    public DateTime CreatedAt { get; set; }
}