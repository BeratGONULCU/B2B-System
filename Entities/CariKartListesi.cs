using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class CariKartListesi
{
    public decimal Id { get; set; }

    public int? TurId { get; set; }

    public string? TurAd { get; set; }

    public int? Grp1 { get; set; }

    public int? Grp2 { get; set; }

    public int? Grp3 { get; set; }

    public int? Firmano { get; set; }

    public int Sil { get; set; }

    public string Kod { get; set; } = null!;

    public string? Ad { get; set; }

    public string? Soyad { get; set; }

    public string? Unvan { get; set; }

    public int? Fisadet { get; set; }

    public int? Fisakadet { get; set; }

    public double? Fisaktut { get; set; }

    public double? Actutar { get; set; }

    public int? LimitTip { get; set; }

    public string? Ilgili { get; set; }

    public string? Grup { get; set; }

    public string? PerIdin { get; set; }

    public int? PerId { get; set; }

    public byte? FatCarSec { get; set; }

    public string? FatCarKod { get; set; }

    public int? FatCarId { get; set; }

    public string? Tel { get; set; }

    public string? Fax { get; set; }

    public string? Cep { get; set; }

    public string? Muhonkod { get; set; }

    public string? Muhkod { get; set; }

    public string? Hesapno { get; set; }

    public bool? OtoFisVadeFark { get; set; }

    public string? AdresPostaKod { get; set; }

    public string? Drm { get; set; }

    public byte[]? Resim { get; set; }

    public string? Adres { get; set; }

    public string? Evil { get; set; }

    public string? Evilce { get; set; }

    public string? DbsRefNo { get; set; }

    public string? Vergidaire { get; set; }

    public string? Vergino { get; set; }

    public string? Vergikimlikno { get; set; }

    public bool? Efatura { get; set; }

    public int? EfaturaTip { get; set; }

    public string? TicSicilNo { get; set; }

    public string? Webadres { get; set; }

    public string? VergiEposta { get; set; }

    public string? Mail { get; set; }

    public string? Tcno { get; set; }

    public string? Kulkod { get; set; }

    public string? Kulsif { get; set; }

    public string? Fatvadtip { get; set; }

    public int? TtsOdeTip { get; set; }

    public string? Fisvadtip { get; set; }

    public int? Fatvadsur { get; set; }

    public int? Fisvadsur { get; set; }

    public double? Fatisk { get; set; }

    public double? Fisvadfark { get; set; }

    public double? Fatvadfark { get; set; }

    public double? Fisisk { get; set; }

    public double? Ttsbayisk { get; set; }

    public double? Ttsdagisk { get; set; }

    public double? Ttsbayvadfark { get; set; }

    public double? Ttsdagvadfark { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Parabrm { get; set; }

    public int? Otofisak { get; set; }

    public string? Fatunvan { get; set; }

    public double? Toplamteminat { get; set; }

    public double? Toplamlimit { get; set; }

    public double? RiskLimit { get; set; }

    public string? Adres2 { get; set; }

    public string? Notack { get; set; }

    public bool? Epostagonder { get; set; }

    public bool? Webextre { get; set; }

    public string? YktAlmDefNo { get; set; }

    public string? AracAd { get; set; }

    public string? EpdkLisansNo { get; set; }

    public int AracSayi { get; set; }

    public bool? AvansTakip { get; set; }

    public bool? WebAvans { get; set; }

    public bool? WebFatura { get; set; }

    public bool? WebCariHrk { get; set; }

    public bool? WebCariBakiye { get; set; }

    public bool? WebFisOdendi { get; set; }

    public bool? WebFaturaOdendi { get; set; }

    public bool? WebPos { get; set; }

    public bool? WebFisIskontoluTahsil { get; set; }

    public bool? Web { get; set; }

    public bool? WebFaturaTahsil { get; set; }

    public bool? WebFaturaIskontoluTahsil { get; set; }

    public bool? WebFis { get; set; }

    public bool? WebFisTahsil { get; set; }

    public int? RemoteId { get; set; }

    public int? ValorGun { get; set; }

    public double? BrcBakiye { get; set; }

    public double? AlcBakiye { get; set; }

    public double? BrcTopBakiye { get; set; }

    public double? AlcTopBakiye { get; set; }

    public double? AvansBakiye { get; set; }

    public double? FisBakiye { get; set; }

    public double? CarBakiye { get; set; }

    public double? IrsBakiye { get; set; }

    public double? CirBakiye { get; set; }

    public double? TopBakiye { get; set; }

    public double? CekBakiye { get; set; }

    public double? CekharcBakiye { get; set; }

    public DateTime? SonhrkTarih { get; set; }

    public DateTime? SonalcTarih { get; set; }

    public DateTime? SonbrcTarih { get; set; }

    public double? SonbrcTutar { get; set; }

    public double? SonalcTutar { get; set; }

    public DateTime? SonFisTarih { get; set; }

    public double? SonFisTutar { get; set; }

    public int? FisAdet { get; set; }

    public int? IrsAdet { get; set; }

    public double? TeminatTutar { get; set; }

    public string? TeminatAck { get; set; }

    public double KulTutLimit { get; set; }

    public double? KalanLimit { get; set; }

    public double? FisOtoVadeFarkTutar { get; set; }

    public string? BankaKod { get; set; }

    public string? BankaDbs { get; set; }

    public string? BankaAd { get; set; }
}
