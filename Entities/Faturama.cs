using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Faturama
{
    public decimal Id { get; set; }

    public double Fatid { get; set; }

    public int? Firmano { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public string? Fatad { get; set; }

    public string? Fattip { get; set; }

    public string? Fattur { get; set; }

    public string? Fatturad { get; set; }

    public string? Fatseri { get; set; }

    public string? Fatno { get; set; }

    public string? Cartip { get; set; }

    public string? Carkod { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Ack { get; set; }

    public double? Geniskyuz { get; set; }

    public double? Genisktop { get; set; }

    public double? Satisktop { get; set; }

    public double? Kdvtop { get; set; }

    public double? Yuvtop { get; set; }

    public double? Gidertop { get; set; }

    public double? Giderkdvtop { get; set; }

    public double? Fattop { get; set; }

    public double? Otvtop { get; set; }

    public string? Kdvtip { get; set; }

    public DateTime? Vadtar { get; set; }

    public string? Depo { get; set; }

    public int? Sil { get; set; }

    public int? Dataok { get; set; }

    public double? Irsaliyeirid { get; set; }

    public double? Siparissipid { get; set; }

    public int? Kayok { get; set; }

    public double? Kur { get; set; }

    public string? Parabrm { get; set; }

    public string? Kaptip { get; set; }

    public double? Odemetop { get; set; }

    public double? Marsatid { get; set; }

    public bool? Yazildi { get; set; }

    public string? Kapidler { get; set; }

    public byte? GenIndTip { get; set; }

    public DateTime? EntegreAktar { get; set; }

    public string? EntegreTip { get; set; }

    public string? Yertip { get; set; }

    public string? Yerad { get; set; }

    public string? Ykfisno { get; set; }

    public double? GenelTop { get; set; }

    public bool? Kilit { get; set; }

    public bool? HrkCarPro { get; set; }

    public bool? HrkStkPro { get; set; }

    public string? Plaka { get; set; }

    public double? GenelIskTop { get; set; }

    public byte? IskTip { get; set; }

    public byte? AkIskTip { get; set; }

    public double? AkIskYuz { get; set; }

    public double? AkIskTop { get; set; }

    public byte? MrIskTip { get; set; }

    public double? MrIskYuz { get; set; }

    public double? MrIskTop { get; set; }

    public double? GnMatrah { get; set; }

    public double? AkMatrah { get; set; }

    public double? MrMatrah { get; set; }

    public double? GenelKdvTop { get; set; }

    public double? GenelAraTop { get; set; }

    public string? IrsNo { get; set; }

    public int? Gctip { get; set; }

    public int? FattipId { get; set; }

    public int? FatturId { get; set; }

    public int? FatrapId { get; set; }

    public int? CarId { get; set; }

    public int? CartipId { get; set; }

    public string? KartParaBrm { get; set; }

    public double? KartKur { get; set; }

    public string? IslemParaBrm { get; set; }

    public double? IslemKur { get; set; }

    public double? GgMatrah { get; set; }

    public byte? GgIskTip { get; set; }

    public double? GgIskYuz { get; set; }

    public double? GgIskTop { get; set; }

    public double? KdvOran1 { get; set; }

    public double? KdvTutar1 { get; set; }

    public double? KdvOran2 { get; set; }

    public double? KdvTutar2 { get; set; }

    public double? KdvOran3 { get; set; }

    public double? KdvTutar3 { get; set; }

    public double? KdvOran4 { get; set; }

    public double? KdvTutar4 { get; set; }

    public double? KdvOran5 { get; set; }

    public double? KdvTutar5 { get; set; }

    public long? RemoteId { get; set; }

    public double? GenelNetTop { get; set; }

    public bool? PromPro { get; set; }

    public double? Varno { get; set; }

    public bool? Odeme { get; set; }

    public int? KarsiCartipId { get; set; }

    public int? KarsiCarId { get; set; }

    public bool? HrkKarsiPro { get; set; }

    public bool? DepDag { get; set; }

    public bool? Entegre { get; set; }

    public bool? Efatura { get; set; }

    public int? EfaturaTip { get; set; }

    public string? EfaturaId { get; set; }

    public DateTime? EfaturaAktar { get; set; }

    public int? PerId { get; set; }

    public bool? AvansTakip { get; set; }

    public string? EfaturaEfinansBelgeOid { get; set; }

    public int? EbelgeTipId { get; set; }

    public int? EbelgeSeriId { get; set; }

    public int? EbelgeEntegrasyonId { get; set; }

    public string? EbelgeGibSeriNo { get; set; }

    public DateTime? EbelgeMailTarihSaat { get; set; }

    public double? GenelKdvTevkifatTop { get; set; }
}
