using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class EfaturaGelen
{
    public int Id { get; set; }

    public int? EfaturaTip { get; set; }

    public string? Guid { get; set; }

    public int? Firmano { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Tcvkntip { get; set; }

    public string? Tcvknno { get; set; }

    public string? Unvan { get; set; }

    public string? Tur { get; set; }

    public string? Tip { get; set; }

    public string? Durum { get; set; }

    public string? DurumHata { get; set; }

    public string? BelgeNo { get; set; }

    public double? GenelToplam { get; set; }

    public string? OlusUser { get; set; }

    public DateTime? OlusTarSaat { get; set; }

    public string? AktarUser { get; set; }

    public DateTime? AktarTarSaat { get; set; }

    public bool? Sil { get; set; }

    public int? FatTip { get; set; }

    public int? CarTipId { get; set; }

    public int? CarId { get; set; }

    public int? RapId { get; set; }

    public string? DepoTipId { get; set; }

    public double? GenelOtvToplam { get; set; }

    public double? GenelIskToplam { get; set; }

    public double? GenelKdvToplam { get; set; }

    public int? EntegreId { get; set; }

    public DateTime? EntegreTarihSaat { get; set; }

    public DateTime? VadeTarih { get; set; }

    public string? IrsaliyeIdIn { get; set; }

    public string? Aciklama { get; set; }
}
