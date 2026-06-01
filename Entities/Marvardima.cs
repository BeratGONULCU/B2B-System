using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Marvardima
{
    public decimal Id { get; set; }

    public double Varno { get; set; }

    public int? Varok { get; set; }

    public int? Sil { get; set; }

    public int? Firmano { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public string? Varad { get; set; }

    public string? Perkod { get; set; }

    public string? Depkod { get; set; }

    public double? Iadetop { get; set; }

    public double? Naktestop { get; set; }

    public double? Postop { get; set; }

    public double? Veresitop { get; set; }

    public double? Gidertop { get; set; }

    public double? Tahtop { get; set; }

    public double? Odetop { get; set; }

    public DateTime? Kaptar { get; set; }

    public string? Kapsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public int? Dataok { get; set; }

    public double? Satistop { get; set; }

    public double? Bozukpara { get; set; }

    public double? Naksattop { get; set; }

    public string? Varackfaztip { get; set; }

    public double? Gelirtop { get; set; }

    public double? Poscartop { get; set; }

    public string? KasKod { get; set; }

    public double? Kur { get; set; }

    public string? Parabrm { get; set; }

    public int? RemoteId { get; set; }

    public double? Indtop { get; set; }

    public int? YazKno { get; set; }

    public string? FisNo { get; set; }

    public DateTime? EntegreAktar { get; set; }

    public string? EntegreTip { get; set; }

    public bool? Transfer { get; set; }

    public DateTime? TransferTarSaat { get; set; }

    public bool? Entegre { get; set; }

    public int? TransferStartId { get; set; }

    public int? TransferStopId { get; set; }

    public DateTime? TransferDateTime { get; set; }

    public int? Zno { get; set; }

    public bool? YazarKasaServis { get; set; }

    public bool? YazarKasaKontrol { get; set; }

    public string? YazarKasaModel { get; set; }

    public string? YazarKasaSeriNo { get; set; }

    public int? YazarKasaVardiyaNo { get; set; }

    public double? Bankatop { get; set; }

    public string? YazarKasaKasiyerKod { get; set; }
}
