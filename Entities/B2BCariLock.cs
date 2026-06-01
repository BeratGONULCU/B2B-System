namespace AvmB2B.Api.Entities;

public class B2BCariLock
{
    public int Id { get; set; }

    public string CariKod { get; set; } = string.Empty;

    public bool IsLocked { get; set; } = true;

    public string? Reason { get; set; }

    public int? LockedByUserId { get; set; }

    public DateTime LockedAt { get; set; } = DateTime.Now;

    public int? UnlockedByUserId { get; set; }

    public DateTime? UnlockedAt { get; set; }
}