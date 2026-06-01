using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Poskart
{
    public decimal Id { get; set; }

    public string Kod { get; set; } = null!;

    public int Firmano { get; set; }

    public string? Ad { get; set; }

    public int? Sil { get; set; }

    public string? Drm { get; set; }

    public string? Bankod { get; set; }

    public string? Muhkod { get; set; }

    public double? Kom { get; set; }

    public double? Exkom { get; set; }

    public double? Vade { get; set; }

    public string? Vadetip { get; set; }

    public string? Parabrm { get; set; }

    public string? Gidhes { get; set; }

    public double? Bekbak { get; set; }

    public double? Kombak { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public int? Dataok { get; set; }

    public string? Muhonkod { get; set; }

    public string? MasGidKod { get; set; }

    public int? RemoteId { get; set; }

    public string? YazarKasaBankaTerminalNo { get; set; }
}
