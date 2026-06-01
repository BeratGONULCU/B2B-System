using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Raporlar
{
    public decimal Id { get; set; }

    public int? Firmano { get; set; }

    public string Rapgrp { get; set; } = null!;

    public string? Rapkod { get; set; }

    public string? Ack { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Olususer { get; set; }

    public string? Yer { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Aktif { get; set; }

    public string? Kaptip { get; set; }

    public string? Islmkod { get; set; }

    public int? Master { get; set; }

    public bool? Yazildi { get; set; }

    public int? Sil { get; set; }

    public byte? Yazdir { get; set; }

    public bool? HrkCarPro { get; set; }

    public bool? HrkStkPro { get; set; }

    public int? TipId { get; set; }

    public byte? BelgeTip { get; set; }

    public byte? BaskaCarFisAktar { get; set; }

    public byte? SatirEsasBrm { get; set; }

    public byte? AlisSatisFiyatKont { get; set; }

    public byte? KdvTip { get; set; }

    public string? CarTip { get; set; }

    public string? GrsStkTip { get; set; }

    public string? IskStkTip { get; set; }

    public string? FatGrsAlan { get; set; }

    public byte? FatTahOde { get; set; }

    public byte? KdvOranYansit { get; set; }

    public byte? PlakaLimit { get; set; }

    public byte? PlakaKontDevam { get; set; }

    public byte? YeniCarKart { get; set; }

    public byte? KartOku { get; set; }

    public byte? YeniStkKart { get; set; }

    public bool? PromPro { get; set; }

    public bool? PromKartsiz { get; set; }

    public byte? StkAdBarkod { get; set; }

    public bool? KarsiHesGrs { get; set; }

    public bool? StkDepDag { get; set; }

    public bool? CarKodBosalt { get; set; }

    public bool? TesisFiyat { get; set; }

    public bool? PlakaAramaYetki { get; set; }

    public bool? IskGiderHrkYansit { get; set; }
}
