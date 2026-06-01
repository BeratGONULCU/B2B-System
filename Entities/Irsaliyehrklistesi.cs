using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Irsaliyehrklistesi
{
    public decimal Id { get; set; }

    public double Irid { get; set; }

    public string Satirtip { get; set; } = null!;

    public int? Sil { get; set; }

    public int? Firmano { get; set; }

    public string? Stktip { get; set; }

    public string? Stkod { get; set; }

    public double? Mik { get; set; }

    public double? Brmfiy { get; set; }

    public string? Depkod { get; set; }

    public double? Kdvyuz { get; set; }

    public double? Kdvtut { get; set; }

    public string? Kdvtip { get; set; }

    public string? Brim { get; set; }

    public string? Ustbrim { get; set; }

    public double? Carpan { get; set; }

    public string? Parabrim { get; set; }

    public double? Grupid { get; set; }

    public int? Kayok { get; set; }
}
