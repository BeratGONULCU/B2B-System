using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Grup
{
    public decimal Id { get; set; }

    public int? Sr { get; set; }

    public int? Sil { get; set; }

    public int? Firmano { get; set; }

    public string Tabload { get; set; } = null!;

    public int? Grp1 { get; set; }

    public int? Grp2 { get; set; }

    public string? Ad { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public int? Dataok { get; set; }

    public double? Kar1 { get; set; }

    public double? Kar2 { get; set; }

    public double? Kdv { get; set; }

    public string? Ykkisno { get; set; }

    public double? Kar3 { get; set; }

    public double? Kar4 { get; set; }

    public string? Muhgrskod { get; set; }

    public string? Muhckskod { get; set; }

    public string? MuhAlsIadKod { get; set; }

    public string? MuhSatIadKod { get; set; }

    public string? MuhAlsIskKod { get; set; }

    public string? MuhSatIskKod { get; set; }

    public string? MuhAlsOtvKod { get; set; }

    public string? MuhSatOtvKod { get; set; }

    public string? MuhSatMalKod { get; set; }

    public string? Muhonkod { get; set; }

    public bool? Restaurant { get; set; }

    public int? RemoteId { get; set; }

    public string? PerIdin { get; set; }

    public int? CalismaSartId { get; set; }

    public string? MuhasebeGrupKodu { get; set; }

    public string? YkKod { get; set; }

    public bool? Yerli { get; set; }

    public int? UretimYerId { get; set; }

    public string? UserIdIn { get; set; }

    public string? Kod { get; set; }
}
