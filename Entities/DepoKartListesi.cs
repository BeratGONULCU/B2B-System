using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class DepoKartListesi
{
    public decimal Id { get; set; }

    public int TipId { get; set; }

    public string Tip { get; set; } = null!;

    public string Tipad { get; set; } = null!;

    public int? Firmano { get; set; }

    public string Kod { get; set; } = null!;

    public string? Ad { get; set; }

    public string? Stktip { get; set; }

    public string Bagak { get; set; } = null!;

    public int? Sil { get; set; }

    public string? Drm { get; set; }

    public string? TipId1 { get; set; }
}
