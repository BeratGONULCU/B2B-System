using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Otomasonlineoku
{
    public decimal Id { get; set; }

    public long Otomasid { get; set; }

    public double? Varno { get; set; }

    public int? Firmano { get; set; }

    public DateTime Tarih { get; set; }

    public string Saat { get; set; } = null!;

    public string? Unvan { get; set; }

    public string? Kodu { get; set; }

    public string? Yakit { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? Tutar { get; set; }

    public decimal? Brimfiy { get; set; }

    public string? Adano { get; set; }

    public string? Tabanca { get; set; }

    public int? Tag { get; set; }

    public int? Km { get; set; }

    public long? Fisno { get; set; }

    public string? Dosya { get; set; }

    public string? Plaka { get; set; }

    public string? Tip { get; set; }

    public bool Islem { get; set; }

    public string? Sayackod { get; set; }

    public string? Perkod { get; set; }

    public string? Carkod { get; set; }

    public string? Sattip { get; set; }

    public string? Stkod { get; set; }

    public string? Cartip { get; set; }

    public string? Carad { get; set; }

    public string? Otomasad { get; set; }

    public string? Tankod { get; set; }

    public string? Otocarad { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public int? Ykodemetip { get; set; }

    public long? Aktarid { get; set; }

    public double? OtoMiktar { get; set; }

    public string? OtoAck { get; set; }

    public bool? Aktar { get; set; }

    public long? Promid { get; set; }

    public bool? OtoFis { get; set; }

    public bool? OtoFisYazdir { get; set; }

    public DateTime? OtoFisYazdirTarSaat { get; set; }

    public bool? Utts { get; set; }
}
