using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class PromaksMarketSatisLog
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public int? IslemId { get; set; }

    public int? DetayId { get; set; }

    public DateTime? IslemTarih { get; set; }

    public string? KasiyerKod { get; set; }

    public string? StokKod { get; set; }

    public string? StokAd { get; set; }

    public string? Barkod { get; set; }

    public int? IslemTipId { get; set; }

    public decimal? Miktar { get; set; }

    public string? Birim { get; set; }

    public decimal? Fiyat { get; set; }

    public decimal? Kdv { get; set; }

    public decimal? Tutar { get; set; }

    public DateTime? KayitTarih { get; set; }

    public int? StokId { get; set; }

    public string? GuidId { get; set; }

    public bool? Transfer { get; set; }

    public bool? Aktar { get; set; }

    public string? OdemeTip { get; set; }
}
