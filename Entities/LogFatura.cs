using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class LogFatura
{
    public long LogId { get; set; }

    public long? Id { get; set; }

    public int BayiId { get; set; }

    public int? KartTipId { get; set; }

    public int? KartId { get; set; }

    public DateTime? TarihSaat { get; set; }

    public int? RaporId { get; set; }

    public int? GenelTipId { get; set; }

    public int? IslemTipId { get; set; }

    public string? FaturaAd { get; set; }

    public string? FaturaSeri { get; set; }

    public string? FaturaNo { get; set; }

    public string? Aciklama { get; set; }

    public double? ToplamKdvTutar { get; set; }

    public double? ToplamAraTutar { get; set; }

    public double? ToplamIskontoTutar { get; set; }

    public double? ToplamNetTutar { get; set; }

    public double? ToplamGenelTutar { get; set; }

    public double? YuvarlamaTutar { get; set; }

    public double? GiderToplam { get; set; }

    public double? GiderKdvToplam { get; set; }

    public double? OtvToplam { get; set; }

    public int? KdvTipId { get; set; }

    public DateTime? VadeTarih { get; set; }

    public double? Kur { get; set; }

    public int? ParaBirimId { get; set; }

    public int? KapTipId { get; set; }

    public double? OdemeToplam { get; set; }

    public string? YazarKasaFisno { get; set; }

    public bool? Kilit { get; set; }

    public bool? HareketCariYaz { get; set; }

    public bool? HareketStokYaz { get; set; }

    public string? Plaka { get; set; }

    public double? GenelIskontoYuzde { get; set; }

    public double? GenelIskontoTutar { get; set; }

    public double? GenelMatrah { get; set; }

    public double? AkaryakitIskontoYuzde { get; set; }

    public double? AkaryakitIskontoTutar { get; set; }

    public double? AkaryakitMatrah { get; set; }

    public double? MarketIskontoYuzde { get; set; }

    public double? MarketIskontoTutar { get; set; }

    public double? MarketMatrah { get; set; }

    public int? KartParaBirimId { get; set; }

    public double? KartKur { get; set; }

    public int? IslemParaBirimId { get; set; }

    public double? IslemKur { get; set; }

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

    public int? VardiyaId { get; set; }

    public bool? Odeme { get; set; }

    public int? KarsiKartTipId { get; set; }

    public int? KarsiKartId { get; set; }

    public bool KayitDurum { get; set; }

    public int? EfaturaTipId { get; set; }

    public string? EfaturaNo { get; set; }

    public string? EfaturaId { get; set; }

    public DateTime? EfaturaAktarimTarih { get; set; }

    public int? EntegreTipId { get; set; }

    public int? EntegreId { get; set; }

    public DateTime? EntegreAktarimTarih { get; set; }

    public bool? Sil { get; set; }

    public int? OlusturmaKullaniciTipId { get; set; }

    public int? OlusturmaKullaniciId { get; set; }

    public DateTime? OlusturmaTarihSaat { get; set; }

    public int? DegistirmeKullaniciTipId { get; set; }

    public int? DegistirmeKullaniciId { get; set; }

    public DateTime? DegistirmeTarihSaat { get; set; }

    public int? SilKullaniciTipId { get; set; }

    public int? SilKullaniciId { get; set; }

    public DateTime? SilTarihSaat { get; set; }

    public int? TransferStartId { get; set; }

    public int? TransferStopId { get; set; }

    public DateTime? TransferTarihSaat { get; set; }

    public long? RemoteId { get; set; }

    public byte? SyncStatus { get; set; }

    public string? VergiNumarasi { get; set; }
}
