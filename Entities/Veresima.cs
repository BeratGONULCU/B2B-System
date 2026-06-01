using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Veresima
{
    public decimal Id { get; set; }

    public double Verid { get; set; }

    public double Varno { get; set; }

    public long? Fatid { get; set; }

    public long? Vtsid { get; set; }

    public int? Firmano { get; set; }

    public int? Varok { get; set; }

    public int? Kayok { get; set; }

    public int? Sil { get; set; }

    public string? Fisad { get; set; }

    public string? Fistip { get; set; }

    public string? Yertip { get; set; }

    public DateTime? Tarih { get; set; }

    public string Yerad { get; set; } = null!;

    public string? Seri { get; set; }

    public string? No { get; set; }

    public string? Ykno { get; set; }

    public string? Cartip { get; set; }

    public string? Carkod { get; set; }

    public string? Plaka { get; set; }

    public string? Perkod { get; set; }

    public int? Adaid { get; set; }

    public string? Surucu { get; set; }

    public double? Km { get; set; }

    public double? Toptut { get; set; }

    public string? Ack { get; set; }

    public int? Kmsec { get; set; }

    public string? Saat { get; set; }

    public int? Ototag { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public int? Dataok { get; set; }

    public string? Aktip { get; set; }

    public string? Fatbelno { get; set; }

    public DateTime? Aktar { get; set; }

    public DateTime? Vadtar { get; set; }

    public double? Bagid { get; set; }

    public double? Marsatid { get; set; }

    public string? Parabrm { get; set; }

    public double? Kur { get; set; }

    public double? Akid { get; set; }

    public string? Otocarkod { get; set; }

    public string? Otocarad { get; set; }

    public bool? Havuzfis { get; set; }

    public double? Havvarno { get; set; }

    public string? Cardno { get; set; }

    public double? Isktop { get; set; }

    public string? IstasAd { get; set; }

    public string? IstasIl { get; set; }

    public int? OtomasId { get; set; }

    public string? OtomasAck { get; set; }

    public double? Fiyfarktop { get; set; }

    public double? Vadfarktop { get; set; }

    public string? BrcCarkod { get; set; }

    public string? BrcCartip { get; set; }

    public bool? BrcCarsec { get; set; }

    public int? FisCariverId { get; set; }

    public bool? VtsOtoAktar { get; set; }

    public bool? FisAlcKocan { get; set; }

    public int? FisAlcBagverid { get; set; }

    public bool? HrkCarPro { get; set; }

    public bool? HrkStkPro { get; set; }

    public int? Gctip { get; set; }

    public int? FisturId { get; set; }

    public int? FistipId { get; set; }

    public int? FisrapId { get; set; }

    public int? CarId { get; set; }

    public int? CartipId { get; set; }

    public string? Kdvtip { get; set; }

    public string? KartParaBrm { get; set; }

    public double? KartKur { get; set; }

    public string? IslemParaBrm { get; set; }

    public double? IslemKur { get; set; }

    public int? RemoteId { get; set; }

    public bool? PromPro { get; set; }

    public bool? EmtiaIsle { get; set; }

    public double? TopMik { get; set; }

    public string? GecPerKod { get; set; }

    public bool? AlcCarSec { get; set; }

    public bool? Devir { get; set; }

    public int? TtsTip { get; set; }

    public bool? Entegre { get; set; }

    public string? EntegreTip { get; set; }

    public DateTime? EntegreAktar { get; set; }

    public DateTime? TtsOdemeTarih { get; set; }

    public bool? TtsOdemeTakip { get; set; }

    public string? YkFisNo { get; set; }

    public double? GenelKdvToplam { get; set; }

    public double? GenelKdvliToplam { get; set; }

    public int? TransferStartId { get; set; }

    public int? TransferStopId { get; set; }

    public DateTime? TransferDateTime { get; set; }

    public DateTime? DevirliVadeTarih { get; set; }

    public double? OncekiKm { get; set; }

    public bool? ServisFis { get; set; }

    public bool? Utts { get; set; }
}
