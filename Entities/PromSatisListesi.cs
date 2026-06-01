using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class PromSatisListesi
{
    public decimal Id { get; set; }

    public double Promid { get; set; }

    public double Varno { get; set; }

    public long? Fatid { get; set; }

    public long? Vtsid { get; set; }

    public int? Firmano { get; set; }

    public int? Varok { get; set; }

    public int? Kayok { get; set; }

    public int? Sil { get; set; }

    public int? FisrapId { get; set; }

    public int? FistipId { get; set; }

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

    public double? GenelTopKdvli { get; set; }

    public double? GenelTopKdvsiz { get; set; }

    public string? Ack { get; set; }

    public string? Saat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public int? Dataok { get; set; }

    public string? Aktip { get; set; }

    public DateTime? Aktar { get; set; }

    public DateTime? Vadtar { get; set; }

    public double? Bagid { get; set; }

    public double? Marsatid { get; set; }

    public string? Parabrm { get; set; }

    public double? Kur { get; set; }

    public double? Akid { get; set; }

    public string? Otocarkod { get; set; }

    public string? Otocarad { get; set; }

    public string? Kartno { get; set; }

    public double? Isktop { get; set; }

    public int? OtomasId { get; set; }

    public string? OtomasAck { get; set; }

    public int? RemoteId { get; set; }

    public bool? VtsOtoAktar { get; set; }

    public bool? HrkStkPro { get; set; }

    public int? CarId { get; set; }

    public int? CartipId { get; set; }

    public int? Gctip { get; set; }

    public int? FisturId { get; set; }

    public bool? HrkCarPro { get; set; }

    public string? KartParaBrm { get; set; }

    public double? KartKur { get; set; }

    public string? IslemParaBrm { get; set; }

    public double? IslemKur { get; set; }

    public string? Kdvtip { get; set; }

    public bool? Kmsec { get; set; }

    public int? OdeTipId { get; set; }

    public string? OdeTipAd { get; set; }

    public double? GenelTopPuan { get; set; }

    public double? GenelTopKdv { get; set; }

    public double? GenelTopNet { get; set; }

    public bool? PromPro { get; set; }

    public bool? PromKartsiz { get; set; }

    public int? KartId { get; set; }

    public int? PromGrp1 { get; set; }

    public string Kod { get; set; } = null!;

    public string? Unvan { get; set; }
}
