using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class PromDahilUrunList
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public decimal StkId { get; set; }

    public string Kod { get; set; } = null!;

    public string? Ad { get; set; }

    public string Tip { get; set; } = null!;

    public int? TipId { get; set; }

    public byte? Sil { get; set; }

    public int? Grp1 { get; set; }

    public string? StokTipAd { get; set; }

    public int? PuanTip { get; set; }

    public int? PuanBrm { get; set; }

    public double? PuanOtomas { get; set; }

    public double? PuanOtomas2 { get; set; }

    public double? PuanNakit { get; set; }

    public double? PuanKk { get; set; }

    public double? PuanFis { get; set; }

    public string? PuanTipAd { get; set; }

    public double? SatFiyKdvli { get; set; }
}
