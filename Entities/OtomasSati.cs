using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class OtomasSati
{
    public long Id { get; set; }

    public long Otomasid { get; set; }

    public double? Varno { get; set; }

    public int? Firmano { get; set; }

    public DateTime Tarih { get; set; }

    public string Saat { get; set; } = null!;

    public string? Yakit { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? Tutar { get; set; }

    public decimal? Brimfiy { get; set; }

    public string? Adano { get; set; }

    public string? Tabanca { get; set; }

    public string? Sayackod { get; set; }

    public double? Km { get; set; }

    public string? FisNo { get; set; }

    public string? Plaka { get; set; }

    public string? Perkod { get; set; }

    public string? Perad { get; set; }

    public string? Carkod { get; set; }

    public string? Carad { get; set; }

    public int? Ykodemetip { get; set; }

    public string? Ack { get; set; }
}
