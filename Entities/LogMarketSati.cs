using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class LogMarketSati
{
    public long LogId { get; set; }

    public long? Id { get; set; }

    public int? BayiId { get; set; }

    public int? MarketVardiyaId { get; set; }

    public int? DepoKartId { get; set; }

    public DateTime? TarihSaat { get; set; }

    public int? IslemTipId { get; set; }

    public double? SatisTutar { get; set; }

    public double? IadeTutar { get; set; }

    public double? NakitTutar { get; set; }

    public double? PosTutar { get; set; }

    public double? VeresiyeTutar { get; set; }

    public double? GiderTutar { get; set; }

    public double? IndirimTutar { get; set; }

    public double? YuvarlamaTutar { get; set; }

    public int? KartTipId { get; set; }

    public int? KartId { get; set; }

    public int? VeresiyeId { get; set; }

    public int? FaturaId { get; set; }

    public int? YazarKasaTipId { get; set; }

    public int? YazarKasaNo { get; set; }

    public int? PersonelKartId { get; set; }

    public bool? KayitDurum { get; set; }

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
}
