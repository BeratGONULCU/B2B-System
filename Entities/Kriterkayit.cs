using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Kriterkayit
{
    public decimal Id { get; set; }

    public int? Firmano { get; set; }

    public string? Form { get; set; }

    public string? Users { get; set; }

    public string? Cekin { get; set; }

    public string? Slipin { get; set; }

    public string? Alisfatin { get; set; }

    public string? Satfatin { get; set; }

    public string? Fisin { get; set; }

    public string? Carigrupin { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public bool? ChBakSifir { get; set; }

    public bool? ChTarih { get; set; }

    public bool? ChDevir { get; set; }

    public bool? FatOrtBrm { get; set; }

    public string? VarBasin { get; set; }

    public string? NesneTip { get; set; }

    public string? NesneAd { get; set; }

    public string? NesneDeger { get; set; }

    public bool? ChYazdir { get; set; }

    public string? VadKrd { get; set; }
}
