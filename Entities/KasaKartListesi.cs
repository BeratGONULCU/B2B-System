using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class KasaKartListesi
{
    public decimal Id { get; set; }

    public double? Firmano { get; set; }

    public string Kod { get; set; } = null!;

    public string? Ad { get; set; }

    public int? Sil { get; set; }

    public string? Muhkod { get; set; }

    public int Tip { get; set; }

    public string? Parabrm { get; set; }

    public decimal GirenBakiye { get; set; }

    public decimal CikanBakiye { get; set; }

    public decimal TopBakiye { get; set; }
}
