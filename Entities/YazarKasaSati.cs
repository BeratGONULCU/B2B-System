using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class YazarKasaSati
{
    public int Id { get; set; }

    public string? KasaTip { get; set; }

    public int? KasaNo { get; set; }

    public DateTime? Tarih { get; set; }

    public int? Carpan { get; set; }

    public string? FisNo { get; set; }

    public int? StokId { get; set; }

    public string? StokKod { get; set; }

    public string? Barkod { get; set; }

    public double? Miktar { get; set; }

    public double? BrimFiyat { get; set; }

    public double? Tutar { get; set; }

    public int? Kdv { get; set; }

    public string? Brim { get; set; }

    public int? RemoteId { get; set; }

    public bool? Trans { get; set; }

    public int? FirmaNo { get; set; }

    public int? YazarKasaIslemId { get; set; }

    public int? Zno { get; set; }

    public int? VardiyaNo { get; set; }

    public string? KasiyerKod { get; set; }

    public string? KasiyerUnvan { get; set; }

    public string? BankaTerminalNo { get; set; }

    public double? NakitOdeme { get; set; }

    public double? PosOdeme { get; set; }
}
