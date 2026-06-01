using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class IstkrediKartListesi
{
    public decimal Id { get; set; }

    public int Firmano { get; set; }

    public int? Sil { get; set; }

    public string Kod { get; set; } = null!;

    public string? Ad { get; set; }

    public string? Bankod { get; set; }

    public string? Sahibi { get; set; }

    public string? Muhkod { get; set; }

    public double? Lim { get; set; }

    public DateTime? Sonkultar { get; set; }

    public double? Heskesgun { get; set; }

    public double? Hessongun { get; set; }

    public string? Drm { get; set; }

    public string? Karttur { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public int? Dataok { get; set; }

    public double? Borc { get; set; }

    public double? Alacak { get; set; }

    public string? Parabrm { get; set; }

    public double? Actutar { get; set; }

    public string? Muhonkod { get; set; }

    public double TopBakiye { get; set; }

    public double? KalLimit { get; set; }

    public double? VadGelen { get; set; }

    public DateTime? HesKesTar { get; set; }

    public DateTime? SonOdeTar { get; set; }
}
