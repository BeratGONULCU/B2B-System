using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Stkdrm
{
    public decimal Id { get; set; }

    public string Stktip { get; set; } = null!;

    public string Stkod { get; set; } = null!;

    public string Depkod { get; set; } = null!;

    public int? Firmano { get; set; }

    public double? Girenmik { get; set; }

    public double? Girenbrmkdvli { get; set; }

    public double? Cikanmik { get; set; }

    public double? Cikanbrmkdvli { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }
}
