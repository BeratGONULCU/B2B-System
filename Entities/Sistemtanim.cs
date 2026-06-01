using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Sistemtanim
{
    public decimal Id { get; set; }

    public int? Firmano { get; set; }

    public string? Kod { get; set; }

    public string? Ad { get; set; }

    public string? Sistemkasa { get; set; }

    public string? Otomas1 { get; set; }

    public string? Otomas2 { get; set; }

    public string? Mardepo { get; set; }

    public string? Pomvardiackfaz { get; set; }

    public string? Pomvarditeskasa { get; set; }

    public string? Marvarditeskasa { get; set; }

    public int? Alsatfiykontrol { get; set; }

    public int? Bacarigiris { get; set; }

    public int? Haricistokgiris { get; set; }

    public int? Yenicarigrp { get; set; }

    public int? Varkapislemtariheata { get; set; }

    public int? Varteslimatkasateksatir { get; set; }

    public int? Pommailgonder { get; set; }

    public int? Marmailgonder { get; set; }

    public string? Vadfarkgelgid { get; set; }

    public int? PomKapsec { get; set; }

    public string? SistemYtlstr { get; set; }

    public double? SistemKasakur { get; set; }

    public int? GrpPerpomid { get; set; }

    public int? GrpPermarid { get; set; }

    public int? GrpMadyagid { get; set; }

    public string? Akyakitstokbrm { get; set; }

    public string? Marketstokbrm { get; set; }

    public int? GrpGelirid { get; set; }

    public int? GrpGiderid { get; set; }

    public int? GrpMadeniyagid { get; set; }

    public int? GrpMusid { get; set; }

    public int? GrpSatid { get; set; }

    public DateTime? Devirtarihsaat { get; set; }

    public string? Deviruserad { get; set; }

    public string? Marsatgiderkart { get; set; }

    public int? Marsatstkuyrses { get; set; }

    public int? Printrenksiz { get; set; }

    public string? Dbversion { get; set; }

    public string? IskontoGid { get; set; }

    public string? Cekmaskod { get; set; }

    public string? Marketsatpbrm { get; set; }

    public int? Marsateksistok { get; set; }

    public int? Pomvarozet { get; set; }

    public string? Marvardiackfaz { get; set; }

    public string? Adres1 { get; set; }

    public string? Adres2 { get; set; }

    public int? Sayimtip { get; set; }

    public string? Posmaskod { get; set; }

    public int? Fisesasbrm { get; set; }

    public int? Alfisesbrm { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public int? Kap { get; set; }

    public int? GrpHizmet { get; set; }

    public int? DonemTarih { get; set; }

    public int? Yazbarkont { get; set; }

    public int? VtsFisYazdir { get; set; }

    public int? Carimailgonder { get; set; }

    public string? ZrapCarkod { get; set; }

    public int? Terazikarksay { get; set; }

    public int? Fatesasbrm { get; set; }

    public int? KasFinVar { get; set; }

    public int? VarTesTek { get; set; }

    public byte? OtoBelgeno { get; set; }

    public string? MuhEntegre { get; set; }

    public string? Carvadfarkgelgid { get; set; }

    public string? YedekDizin { get; set; }

    public int? Marsatf2ekran { get; set; }

    public string? Marpossatkod { get; set; }

    public string? PerMaasgidkart { get; set; }

    public string? GridSecrenk { get; set; }

    public string? SistemParabrm { get; set; }

    public string? TelNo { get; set; }

    public string? FaxNo { get; set; }

    public byte? Alfatesbrm { get; set; }

    public string? Fisyenfiygelgid { get; set; }

    public byte? HvzFisOto { get; set; }

    public byte? VerFisKisa { get; set; }

    public int? FisvadEksiIzni { get; set; }

    public string? FatIskontoKart { get; set; }

    public DateTime? RapHrkBasTar { get; set; }

    public byte? HvzFisKartOto { get; set; }

    public byte? LimAsimSor { get; set; }

    public string? FisIskontoKart { get; set; }

    public byte? VtsOtoVarAktar { get; set; }

    public byte? PlakaKontDev { get; set; }

    public int? ParaOndalik { get; set; }

    public byte? PlakaYeniSor { get; set; }

    public int? VarVeresiFis { get; set; }

    public byte? VarAlacakFis { get; set; }

    public int? PromDepo { get; set; }

    public int? PromFisRap { get; set; }

    public byte? VarHrkTarIsle { get; set; }

    public byte? VtsFisCariSec { get; set; }

    public bool? VarFisEmtiaIsle { get; set; }

    public byte? KurSor { get; set; }

    public byte? VarTopEposta { get; set; }

    public string? MuhPosCarKod { get; set; }

    public string? MuhPosGidKod { get; set; }

    public byte? PuanYuvTip { get; set; }

    public byte? SayimKont { get; set; }

    public byte? KartUnvanKod { get; set; }

    public bool? KasaTarih { get; set; }

    public byte? FatVerSatirDeg { get; set; }

    public bool? AkaryakitTumFirma { get; set; }

    public bool? PomVarEksiStok { get; set; }

    public int? ZraporEsasBrm { get; set; }

    public bool? MarketSube { get; set; }

    public bool? BekoPosOtomatik { get; set; }

    public int? MarKapsec { get; set; }

    public bool? Market1FiyatGit { get; set; }

    public bool? PomVarOtomasPlaka { get; set; }

    public bool? VarPosIsle { get; set; }

    public int? MarketStokAltGrup { get; set; }

    public bool? FaturaFisIskonto { get; set; }

    public string? TtsBankaKod { get; set; }

    public bool? EfaturaSeriNoOto { get; set; }

    public bool? OtoFisVade { get; set; }

    public string? OtoFisVadeZaman { get; set; }

    public int? EntegreSubeNo { get; set; }

    public bool? CariAvansTakip { get; set; }

    public string? TtsBankaKod2 { get; set; }

    public bool? MarketCikisSifre { get; set; }

    public byte? PuanPlakaKont { get; set; }

    public string? MarketCikisSifreKod { get; set; }

    public bool? BedelsizBarkodKontrol { get; set; }

    public bool? MarVarPosIsle { get; set; }
}
