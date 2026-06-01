using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class LogUrunFiyatHistory
{
    public long LogId { get; set; }

    public long Id { get; set; }

    public long BayiId { get; set; }

    public int KartId { get; set; }

    public double Fiyat { get; set; }

    public double Kdv { get; set; }

    public int KdvTipId { get; set; }

    public int ParaBirimId { get; set; }

    public byte SyncStatus { get; set; }

    public int? OlusturmaKullaniciTipId { get; set; }

    public DateTime? OlusturmaKullaniciId { get; set; }

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

    public bool? Sil { get; set; }

    public int? FiyatNo { get; set; }

    public int? FiyatTip { get; set; }

    public int? KartTipId { get; set; }

    public double? EskiFiyat { get; set; }

    public string? DegistirmeKullanici { get; set; }
}
