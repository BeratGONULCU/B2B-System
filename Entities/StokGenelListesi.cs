using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class StokGenelListesi
{
    public string Kod { get; set; } = null!;

    public string? Ad { get; set; }

    public string? GrupAd { get; set; }

    public double? Sat1fiykdvli { get; set; }

    public double? Sat1fiykdvsiz { get; set; }

    public double? Sat2fiykdvli { get; set; }

    public double? Sat2fiykdvsiz { get; set; }

    public double? Alsfiykdvli { get; set; }

    public double? Alsfiykdvsiz { get; set; }
}
