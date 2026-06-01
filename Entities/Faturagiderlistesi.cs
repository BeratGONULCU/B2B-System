using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Faturagiderlistesi
{
    public decimal Id { get; set; }

    public double Fatid { get; set; }

    public string Kod { get; set; } = null!;

    public string? Ad { get; set; }

    public string? Muhkod { get; set; }

    public string? Muhonkod { get; set; }

    public double? Kdv { get; set; }

    public double? Tutar { get; set; }
}
