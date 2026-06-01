using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Gelgidkart
{
    public decimal Id { get; set; }

    public int? Firmano { get; set; }

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

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public int? Dataok { get; set; }

    public double? Fiyat { get; set; }

    public double? Toplim { get; set; }

    public string? Kdvtip { get; set; }

    public double? Kdv { get; set; }

    public string? Brim { get; set; }

    public string? Parabrm { get; set; }

    public double? Fisaktut { get; set; }

    public int? Fisadet { get; set; }

    public int? Fisakadet { get; set; }

    public double? Actutar { get; set; }

    public bool? Gizli { get; set; }

    public string? Muhonkod { get; set; }

    public int? TipId { get; set; }

    public bool? Prom { get; set; }

    public double? PuanBrm { get; set; }

    public byte? PuanTip { get; set; }

    public double? PuanNakit { get; set; }

    public double? PuanKk { get; set; }

    public double? PuanFis { get; set; }

    public double? PromSatPuan { get; set; }

    public bool? PromUrun { get; set; }

    public byte? PromSatTip { get; set; }

    public int? PromKacSatis { get; set; }

    public int? LimitTip { get; set; }

    public int? RemoteId { get; set; }
}
