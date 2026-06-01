using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class MicroStokListesi
{
    public string Stokkod { get; set; } = null!;

    public string? Stokad { get; set; }

    public string? Birimad { get; set; }

    public double? Sat1fiy { get; set; }

    public double? Sat2fiy { get; set; }

    public double? Sat3fiy { get; set; }

    public double? Sat4fiy { get; set; }

    public int? Sat1pbrm { get; set; }

    public int? Sat2pbrm { get; set; }

    public int? Sat3pbrm { get; set; }

    public int? Sat4pbrm { get; set; }

    public int? Sat1kdv { get; set; }
}
