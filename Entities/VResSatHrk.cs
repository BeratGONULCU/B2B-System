using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class VResSatHrk
{
    public int Id { get; set; }

    public string? OlusUser { get; set; }

    public DateTime? OlusTarSaat { get; set; }

    public string? DegisUser { get; set; }

    public DateTime? DegisTarSaat { get; set; }

    public bool? Sil { get; set; }

    public int? VarNo { get; set; }

    public double ResSatId { get; set; }

    public int? StkTipId { get; set; }

    public int? StkId { get; set; }

    public string Kod { get; set; } = null!;

    public string? Ad { get; set; }

    public double? Miktar { get; set; }

    public string? Birim { get; set; }

    public double? BirimCarpan { get; set; }

    public double? BirimFiyat { get; set; }

    public double? KdvYuz { get; set; }

    public string? ParaBirim { get; set; }

    public double? Kur { get; set; }

    public string? Barkod { get; set; }

    public int? SatFiyNo { get; set; }

    public double? IndYuz { get; set; }

    public double? Tutar { get; set; }

    public double? TutarKdvli { get; set; }

    public double? IndTutar { get; set; }

    public double? KdvTutar { get; set; }

    public double? NetBirimFiyat { get; set; }

    public double? NetTutar { get; set; }
}
