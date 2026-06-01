namespace AvmB2B.Api.DTOs.Auth;

public class LoginResponse
{
    public string Token { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string UserType { get; set; } = null!;

    public string? CariKod { get; set; }

    public bool MustChangePassword { get; set; }
}