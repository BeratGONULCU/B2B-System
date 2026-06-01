using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class LogFaturaHareket
{
    public long LogId { get; set; }

    public long? Id { get; set; }

    public int? BayiId { get; set; }

    public int? FaturaId { get; set; }

    public int? KartTipId { get; set; }

    public int? KartId { get; set; }

    public string? Barkod { get; set; }

    public double? Miktar { get; set; }

    public double? BirimFiyat { get; set; }

    public int? DepoTipId { get; set; }

    public int? DepoId { get; set; }

    public double? KdvYuzde { get; set; }

    public double? KdvTutar { get; set; }

    public int? KdvTipId { get; set; }

    public int? BirimId { get; set; }

    public double? SatirIskontoYuzde { get; set; }

    public double? SatirIskontoTutar { get; set; }

    public double? OtvYuzde { get; set; }

    public double? OtvTutar { get; set; }

    public double? Carpan { get; set; }

    public int? ParaBirimId { get; set; }

    public double? Kur { get; set; }

    public double? Kesafet { get; set; }

    public int? KartParaBirimId { get; set; }

    public double? KartKur { get; set; }

    public int? IslemParaBirimId { get; set; }

    public double? IslemKur { get; set; }

    public double? ToplamIskontoYuzde { get; set; }

    public double? ToplamIskontoTutar { get; set; }

    public double? ToplamTutarIskontoluKdvsiz { get; set; }

    public double? ToplamTutarIskontoluKdvli { get; set; }

    public double? ToplamKdvTutar { get; set; }

    public double? OtvCarpan { get; set; }

    public string? Aciklama { get; set; }

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
