using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class ZraporUrunKartListesi
{
    public int? Firmano { get; set; }

    public string? Kod { get; set; }

    public string? Ad { get; set; }

    public double? Kdv { get; set; }

    public string Tip { get; set; } = null!;

    public int TipId { get; set; }

    public double? Brimfiy { get; set; }

    public string? Brim { get; set; }

    public string Muhonkod { get; set; } = null!;

    public string? Muhgrskod { get; set; }

    public string? Muhckskod { get; set; }
}
