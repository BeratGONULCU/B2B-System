using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class LogMarketSatisHareket
{
    public long LogId { get; set; }

    public long Id { get; set; }

    public int? BayiId { get; set; }

    public int? MarketSatisId { get; set; }

    public DateTime? TarihSaat { get; set; }

    public int? KartTipId { get; set; }

    public int? KartId { get; set; }

    public string? Barkod { get; set; }

    public int? FiyatNo { get; set; }

    public double? Miktar { get; set; }

    public double? BirimFiyat { get; set; }

    public double? IndirimYuzde { get; set; }

    public double? KdvYuzde { get; set; }

    public int? KdvTipId { get; set; }

    public int? ParaBirimId { get; set; }

    public double? ParaBirimKur { get; set; }

    public int? BirimId { get; set; }

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

    public int? RemoteId { get; set; }

    public byte? SyncStatus { get; set; }

    public bool? Recete { get; set; }
}
