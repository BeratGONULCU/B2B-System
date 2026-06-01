using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Kasakart
{
    public decimal Id { get; set; }

    public double? Firmano { get; set; }

    public int Tip { get; set; }

    public string Kod { get; set; } = null!;

    public string? Ad { get; set; }

    public string? Parabrm { get; set; }

    public double? Giren { get; set; }

    public double? Cikan { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public int? Sil { get; set; }

    public int? Dataok { get; set; }

    public int? Sr { get; set; }

    public string? Muhkod { get; set; }

    public string? Muhonkod { get; set; }

    public string? Cekmuhkod { get; set; }

    public DateTime? AcTarih { get; set; }

    public string? UserIdIn { get; set; }
}
