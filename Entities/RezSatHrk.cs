using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class RezSatHrk
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public double RezSatid { get; set; }

    public double Varno { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public string? Stktip { get; set; }

    public string? Stkod { get; set; }

    public double? Miktar { get; set; }

    public double? BrmFiyat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public double? Kdvyuz { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public int? Dataok { get; set; }

    public int? Kayok { get; set; }

    public string? Parabrm { get; set; }

    public double? Kur { get; set; }

    public string? Brim { get; set; }

    public string? Barkod { get; set; }

    public int? Satfiyno { get; set; }

    public string? Depkod { get; set; }

    public double? Indyuz { get; set; }

    public int? RemoteId { get; set; }

    public int? StktipId { get; set; }

    public int? StkId { get; set; }

    public byte? Gctip { get; set; }

    public bool? Sil { get; set; }
}
