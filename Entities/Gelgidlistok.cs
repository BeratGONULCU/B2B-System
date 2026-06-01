using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Gelgidlistok
{
    public decimal Id { get; set; }

    public int? TipId { get; set; }

    public string Kod { get; set; } = null!;

    public string Tip { get; set; } = null!;

    public string? Ad { get; set; }

    public string Stktur { get; set; } = null!;

    public string? Brim { get; set; }

    public double? Sat1kdv { get; set; }

    public string? Sat1kdvtip { get; set; }

    public double? Sat1fiy { get; set; }

    public double? Sat2kdv { get; set; }

    public string? Sat2kdvtip { get; set; }

    public double? Sat2fiy { get; set; }

    public int? Grp1 { get; set; }

    public int? Grp2 { get; set; }

    public int? Grp3 { get; set; }

    public string? Gtip { get; set; }

    public string? Muhonkod { get; set; }

    public string? Muhgrskod { get; set; }

    public string? Muhckskod { get; set; }
}
