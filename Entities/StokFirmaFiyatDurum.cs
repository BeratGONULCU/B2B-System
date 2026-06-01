using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class StokFirmaFiyatDurum
{
    public int? Firmano { get; set; }

    public decimal Id { get; set; }

    public string Tip { get; set; } = null!;

    public string Kod { get; set; } = null!;

    public string? Ad { get; set; }

    public double AlisFiyat { get; set; }

    public double SatisFiyat { get; set; }

    public double MevcutMiktar { get; set; }
}
