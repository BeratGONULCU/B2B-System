using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class VResGrup
{
    public decimal Id { get; set; }

    public int? Sr { get; set; }

    public int? Sil { get; set; }

    public int? FirmaNo { get; set; }

    public string TabloAd { get; set; } = null!;

    public int? Grp1 { get; set; }

    public int? Grp2 { get; set; }

    public string? Ad { get; set; }

    public int? DataOk { get; set; }

    public double? Kar1 { get; set; }

    public double? Kar2 { get; set; }

    public double? Kdv { get; set; }

    public string? YkkIsNo { get; set; }

    public double? Kar3 { get; set; }

    public double? Kar4 { get; set; }

    public bool? Restaurant { get; set; }
}
