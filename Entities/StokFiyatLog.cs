using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class StokFiyatLog
{
    public int Id { get; set; }

    public int? FirmaNo { get; set; }

    public DateTime? Tarih { get; set; }

    public int? StokTipId { get; set; }

    public int? StokId { get; set; }

    public decimal? SatisFiyat { get; set; }

    public decimal? AlisFiyat { get; set; }

    public decimal? TedarikFiyat { get; set; }

    public decimal? MarjYuzde { get; set; }

    public decimal? SatisKdv { get; set; }

    public decimal? AlisKdv { get; set; }

    public string? ParaBrm { get; set; }

    public int? RemoteId { get; set; }

    public string? OlusUser { get; set; }

    public DateTime? OlusTarSaat { get; set; }

    public string? DegUser { get; set; }

    public DateTime? DegTarSaat { get; set; }

    public bool? Sil { get; set; }
}
