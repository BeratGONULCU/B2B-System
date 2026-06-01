using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Sayimhrk
{
    public decimal Id { get; set; }

    public double Sayid { get; set; }

    public string? Depkod { get; set; }

    public string? Stkod { get; set; }

    public int? Firmano { get; set; }

    public int? Sil { get; set; }

    public string? Drm { get; set; }

    public string? Stktip { get; set; }

    public double? Sayimmik { get; set; }

    public double? Mevcutmik { get; set; }

    public string? Saydrm { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Deguser { get; set; }

    public double? Brmfiy { get; set; }

    public string? Kdvtip { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public int? Dataok { get; set; }

    public double? Kdvyuz { get; set; }

    public byte? Mevata { get; set; }

    public double? OnlineSayimMiktar { get; set; }

    public double? OnlineSatisMiktar { get; set; }

    public DateTime? OnlineSayimTarihSaat { get; set; }

    public bool? OnlineSayim { get; set; }
}
