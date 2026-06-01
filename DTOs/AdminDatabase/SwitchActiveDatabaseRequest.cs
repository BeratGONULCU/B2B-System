namespace AvmB2B.Api.DTOs.AdminDatabase;

public class SwitchActiveDatabaseRequest
{
    public string TargetDatabase { get; set; } = "";

    public bool ConfirmAppSettingsWillBeUpdated { get; set; }
    public bool ConfirmApiServiceWillRestart { get; set; }
}