using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class VResStok01
{
    public decimal Id { get; set; }

    public int? TipId { get; set; }

    public int? FirmaNo { get; set; }

    public int? GrupId { get; set; }

    public string Kod { get; set; } = null!;

    public string? Ad { get; set; }

    public int? FiyNo { get; set; }

    public double? SatKdv { get; set; }

    public string? ParaBrm { get; set; }

    public int? SatKdvTip { get; set; }

    public string? SatKdvTipAd { get; set; }

    public double? SatFiy { get; set; }

    public string? Birim { get; set; }

    public int Receteli { get; set; }
}
