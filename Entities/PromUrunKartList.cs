using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class PromUrunKartList
{
    public decimal Id { get; set; }

    public int? Firmano { get; set; }

    public int? TipId { get; set; }

    public int Sil { get; set; }

    public string Kod { get; set; } = null!;

    public string? Ad { get; set; }

    public double? PromSatPuan { get; set; }

    public double? AcMik { get; set; }

    public double? AlsFiy { get; set; }

    public double? AlsKdv { get; set; }

    public byte? PromSatTip { get; set; }

    public int? PromKacSatis { get; set; }

    public string? SatTipAd { get; set; }

    public double GirenMiktar { get; set; }

    public double CikanMiktar { get; set; }

    public double MevcutMiktar { get; set; }
}
