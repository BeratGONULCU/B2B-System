namespace AvmB2B.Api.DTOs.AdminDatabase;

public class SwitchActiveDatabaseResponse
{
    public bool Success { get; set; }
    public string Message { get; set; } = "";
    public string OldDatabase { get; set; } = "";
    public string NewDatabase { get; set; } = "";
    public bool RestartScheduled { get; set; }
}