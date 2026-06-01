using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class PromPuanHrk
{
    public long Id { get; set; }

    public int? Firmano { get; set; }

    public bool? Sil { get; set; }

    public int? CartipId { get; set; }

    public string? Cartip { get; set; }

    public int? CarId { get; set; }

    public string? Carkod { get; set; }

    public int? StktipId { get; set; }

    public string? Stktip { get; set; }

    public int? StkId { get; set; }

    public string? Stkkod { get; set; }

    public double? PuanGiren { get; set; }

    public double? PuanCikan { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public int? IslemTipId { get; set; }

    public string? IslemTipAd { get; set; }

    public int? OdeTipId { get; set; }

    public string? OdeTipAd { get; set; }

    public string? OlusUser { get; set; }

    public DateTime? OlusTarSaat { get; set; }

    public string? Ack { get; set; }

    public string? DegisUser { get; set; }

    public DateTime? DegisTarSaat { get; set; }

    public string? CarPlaka { get; set; }

    public string? CarKartNo { get; set; }

    public double? BrmFiyatKdvli { get; set; }

    public double? KdvOran { get; set; }

    public double? MikGiren { get; set; }

    public double? MikCikan { get; set; }

    public string? BelNo { get; set; }

    public double? TutarKdvli { get; set; }

    public long? Fatid { get; set; }

    public long? Fisid { get; set; }

    public long? Promid { get; set; }

    public string? Yertip { get; set; }

    public string? YerAd { get; set; }

    public long? Varno { get; set; }

    public int? DepId { get; set; }

    public string? DepKod { get; set; }

    public int? CarKartId { get; set; }

    public int? Puanid { get; set; }

    public bool? HrkStkPro { get; set; }

    public byte? Kayok { get; set; }

    public double? Kur { get; set; }
}
