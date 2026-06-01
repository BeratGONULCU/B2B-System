using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class StokFirmaFiyatList
{
    public int Firmano { get; set; }

    public string? FirmaUnvan { get; set; }

    public decimal Id { get; set; }

    public string Tip { get; set; } = null!;

    public string Kod { get; set; } = null!;

    public string? Ad { get; set; }

    public int? Grp1 { get; set; }

    public int? Grp2 { get; set; }

    public int? Grp3 { get; set; }

    public double? SatisKdv { get; set; }

    public double? AlisKdv { get; set; }

    public double AlisFiyat { get; set; }

    public double SatisFiyat1 { get; set; }

    public double SatisFiyat2 { get; set; }

    public double SatisFiyat3 { get; set; }

    public double SatisFiyat4 { get; set; }
}
