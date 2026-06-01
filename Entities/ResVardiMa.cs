using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class ResVardiMa
{
    public int Id { get; set; }

    public string? OlusUser { get; set; }

    public DateTime? OlusTarSaat { get; set; }

    public string? DegUser { get; set; }

    public DateTime? DegTarSaat { get; set; }

    public bool? Sil { get; set; }

    public int VarNo { get; set; }

    public int? VarOk { get; set; }

    public int? FirmaNo { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public string? VarAd { get; set; }

    public string? PerKod { get; set; }

    public string? DepKod { get; set; }

    public double? IadeTop { get; set; }

    public double? NakTesTop { get; set; }

    public double? PosTop { get; set; }

    public double? VeresiTop { get; set; }

    public double? GiderTop { get; set; }

    public double? TahTop { get; set; }

    public double? OdeTop { get; set; }

    public DateTime? KapTarih { get; set; }

    public string? KapSaat { get; set; }

    public double? SatisTop { get; set; }

    public double? BozukPara { get; set; }

    public double? NakSatTop { get; set; }

    public string? VarAckFazTip { get; set; }

    public double? GelirTop { get; set; }

    public double? PosCarTop { get; set; }

    public string? KasaKod { get; set; }

    public double? Kur { get; set; }

    public string? ParaBirim { get; set; }

    public int? RemoteId { get; set; }

    public double? IndTop { get; set; }

    public int? YazarKasaNo { get; set; }

    public DateTime? EntegreAktar { get; set; }

    public string? EntegreTip { get; set; }
}
