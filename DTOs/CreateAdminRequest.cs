namespace AvmB2B.Api.DTOs.Auth;

public class CreateAdminRequest
{
    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;
}