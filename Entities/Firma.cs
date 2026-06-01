using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Firma
{
    public int Id { get; set; }

    public string? Kod { get; set; }

    public string? Ad { get; set; }

    public string? VarOtomas { get; set; }

    public string? OnOtomas { get; set; }

    public int? Sil { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Adres1 { get; set; }

    public string? Adres2 { get; set; }

    public string? TelNo { get; set; }

    public string? FaxNo { get; set; }

    public int? LogoId { get; set; }

    public int? KartAkIsle { get; set; }

    public string? PvAckFaz { get; set; }

    public string? MvAckFaz { get; set; }

    public string? PvKasa { get; set; }

    public string? MvKasa { get; set; }

    public string? EntegreTip { get; set; }

    public int? EntegreFirmaNo { get; set; }

    public string? EntegreUserKod { get; set; }

    public string? EntegreUserSifre { get; set; }

    public string? EntegreZraporOnMuhKod { get; set; }

    public string? EntegreZraporMuhKod { get; set; }

    public int? EfaturaTip { get; set; }

    public string? EfaturaSirketKod { get; set; }

    public string? EfaturaUserKod { get; set; }

    public string? EfaturaUserSifre { get; set; }

    public string? EfaturaCariKod { get; set; }

    public int? EntegrePeriot { get; set; }

    public string? EntegrePosCarMuhKod { get; set; }

    public string? EntegrePosGidMuhKod { get; set; }

    public string? EntegrePosCarOnMuhKod { get; set; }

    public string? EntegrePosGidOnMuhKod { get; set; }

    public string? EfaturaSeri { get; set; }

    public int? EntegreSubeNo { get; set; }

    public string? EntegreBankGidOnMuhKod { get; set; }

    public string? EntegreBankGidMuhKod { get; set; }

    public bool? EfaturaIngFaturaNo { get; set; }

    public string? EarsivUserKod { get; set; }

    public string? EarsivUserSifre { get; set; }

    public string? EarsivSube { get; set; }

    public string? EarsivKasa { get; set; }

    public string? FatIskGiderKod { get; set; }

    public string? FisIskGiderKod { get; set; }

    public int? MarketSatisParaBirim { get; set; }

    public string? MarketSatisParaBirim1 { get; set; }

    public string? MarketSatisParaBirim2 { get; set; }

    public string? MarketSatisParaBirim3 { get; set; }

    public string? MarketSatisParaBirim4 { get; set; }

    public string? ZraporCariKod { get; set; }

    public int? EfaturaEsasBirim { get; set; }

    public string? EarsivSirketKod { get; set; }

    public int? EarsivEntegratorId { get; set; }

    public int? EfaturaEntegratorId { get; set; }

    public bool? EarsivFaturaNo { get; set; }

    public int? EirsaliyeEntegratorId { get; set; }

    public string? EirsaliyeUserKod { get; set; }

    public string? EirsaliyeUserSifre { get; set; }

    public string? EirsaliyeSirketKod { get; set; }

    public bool? EirsaliyeFaturaNo { get; set; }

    public string? EntegreMarketKdv0OnMuhKod { get; set; }

    public string? EntegreMarketKdv1OnMuhKod { get; set; }

    public string? EntegreMarketKdv8OnMuhKod { get; set; }

    public string? EntegreMarketKdv18OnMuhKod { get; set; }

    public string? EntegreDepartmanKod { get; set; }

    public int? BulutTahsilatEntegratorId { get; set; }

    public string? BulutTahsilatSirketKod { get; set; }

    public string? BulutTahsilatUserKod { get; set; }

    public string? BulutTahsilatUserSifre { get; set; }

    public string? MarketSatisPosKod { get; set; }
}
