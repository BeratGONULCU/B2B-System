using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class ResSatMa
{
    public int Id { get; set; }

    public string? OlusUser { get; set; }

    public DateTime? OlusTarSaat { get; set; }

    public string? DegisUser { get; set; }

    public DateTime? DegisTarSaat { get; set; }

    public bool? Sil { get; set; }

    public int? FirmaNo { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public int? VarNo { get; set; }

    public bool? KayOk { get; set; }

    public bool? Iade { get; set; }

    public double? SatisTop { get; set; }

    public double? IadeTop { get; set; }

    public double? NakitTop { get; set; }

    public double? PosTop { get; set; }

    public string? ParaBirim { get; set; }

    public double? Kur { get; set; }

    public string? FisNo { get; set; }

    public string? DepoKod { get; set; }

    public double? IndTop { get; set; }
}
