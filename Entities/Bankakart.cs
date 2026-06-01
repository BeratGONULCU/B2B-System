using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Bankakart
{
    public decimal Id { get; set; }

    public string Kod { get; set; } = null!;

    public int Firmano { get; set; }

    public string? Ad { get; set; }

    public string? Muhkod { get; set; }

    public string? Hesno { get; set; }

    public string? Parabrm { get; set; }

    public string? Ilgili { get; set; }

    public string? Tel { get; set; }

    public string? Drm { get; set; }

    public string? Fax { get; set; }

    public string? Grp1 { get; set; }

    public string? Grp2 { get; set; }

    public string? Grp3 { get; set; }

    public double? Borc { get; set; }

    public double? Alacak { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Deguser { get; set; }

    public int Sil { get; set; }

    public int? Dataok { get; set; }

    public double? Actutar { get; set; }

    public string? Muhonkod { get; set; }

    public string? Cekmuhkod { get; set; }

    public int? RemoteId { get; set; }

    public string? Iban { get; set; }
}
