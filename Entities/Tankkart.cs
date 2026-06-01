using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Tankkart
{
    public decimal Id { get; set; }

    public string Kod { get; set; } = null!;

    public string Bagak { get; set; } = null!;

    public int Firmano { get; set; }

    public string? Ad { get; set; }

    public int? Sil { get; set; }

    public int? Dataok { get; set; }

    public double? Kapsit { get; set; }

    public double? Minmik { get; set; }

    public string? Drm { get; set; }

    public double? Acmik { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public double? Alsmik { get; set; }

    public double? Satmik { get; set; }

    public string? Stktip { get; set; }

    public double? Alskdvlitoptut { get; set; }

    public double? Satkdvlitoptut { get; set; }

    public int? RemoteId { get; set; }
}
