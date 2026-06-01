using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Otomaspumphrk
{
    public int Id { get; set; }

    public int? Otomasid { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public int? Firmano { get; set; }

    public string? SayacKod { get; set; }

    public string? TankKod { get; set; }

    public string? StokKod { get; set; }

    public string? PerKod { get; set; }

    public double? Litre { get; set; }

    public double? BirimFiyat { get; set; }

    public double? Tutar { get; set; }

    public DateTime? KayitTarSaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Dosya { get; set; }
}
