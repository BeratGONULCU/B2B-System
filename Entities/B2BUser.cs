namespace AvmB2B.Api.Entities;

public class B2BUser
{
    public int Id { get; set; }

    public string UserType { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string? CariKod { get; set; }

    public bool IsActive { get; set; }

    public bool MustChangePassword { get; set; }

    public DateTime CreatedAt { get; set; }
}