using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class LogUrunHareket
{
    public long Id { get; set; }

    public int? BayiId { get; set; }

    public int KartTipId { get; set; }

    public int KartId { get; set; }

    public int? IslemTipId { get; set; }

    public int? PompaciVardiyaId { get; set; }

    public int? MarketVardiyaId { get; set; }

    public int? TankId { get; set; }

    public int? DepoId { get; set; }

    public DateTime? TarihSaat { get; set; }

    public double? Giren { get; set; }

    public double? Cikan { get; set; }

    public double? BirimFiyatBrutKdvli { get; set; }

    public double? BirimFiyatNetKdvli { get; set; }

    public double? KdvYuzde { get; set; }

    public double? Otv { get; set; }

    public string? Aciklama { get; set; }

    public string? BelgeNo { get; set; }

    public int? MarketSatisId { get; set; }

    public int? MarketSatisHareketId { get; set; }

    public int? FaturaId { get; set; }

    public int? FaturaHareketId { get; set; }

    public int? IrsaliyeId { get; set; }

    public int? IrsaliyeHareketId { get; set; }

    public int? VeresiyeId { get; set; }

    public int? VeresiyeHareketId { get; set; }

    public int? DepoTransferId { get; set; }

    public decimal? SayimId { get; set; }

    public int? StokRenkId { get; set; }

    public int? StokBedenNoId { get; set; }

    public int? ReceteId { get; set; }

    public int? ReceteStokHareketId { get; set; }

    public bool KayitDurum { get; set; }

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

    public string? SadakatKartNo { get; set; }

    public double? SadakatHarcananPuan { get; set; }

    public string? StokKodu { get; set; }

    public byte SyncStatus { get; set; }

    public string? StokBarkod { get; set; }
}
