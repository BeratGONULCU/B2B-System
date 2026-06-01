using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class GelGidKartListesi
{
    public decimal Id { get; set; }

    public int? Firmano { get; set; }

    public string? Firmaad { get; set; }

    public int Sil { get; set; }

    public string Kod { get; set; } = null!;

    public string? Ad { get; set; }

    public string? Drm { get; set; }

    public int? Grp1 { get; set; }

    public int? Grp2 { get; set; }

    public int? Grp3 { get; set; }

    public double? Fisbak { get; set; }

    public double? Carbak { get; set; }

    public string? Muhkod { get; set; }

    public string? Muhonkod { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public double? Fiyat { get; set; }

    public double? Toplim { get; set; }

    public int? LimitTip { get; set; }

    public string? Kdvtip { get; set; }

    public double? Kdv { get; set; }

    public string? Brim { get; set; }

    public string? Parabrm { get; set; }

    public double? Fisaktut { get; set; }

    public int? Fisadet { get; set; }

    public int? Fisakadet { get; set; }

    public double? Actutar { get; set; }

    public bool? Gizli { get; set; }

    public double FisBakiye { get; set; }

    public double CarBakiye { get; set; }

    public double TopBakiye { get; set; }

    public double CekharcBakiye { get; set; }

    public DateTime? SonhrkTarih { get; set; }

    public DateTime? SonFisTarih { get; set; }

    public double SonFisTutar { get; set; }

    public int FisAdet { get; set; }

    public string? Grup { get; set; }

    public double? Topbak { get; set; }
}
