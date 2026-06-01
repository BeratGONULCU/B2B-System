using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class StokIadeMiktarListesi
{
    public string Tip { get; set; } = null!;

    public string Kod { get; set; } = null!;

    public double AlsiadeMik { get; set; }

    public double AlsiadeTopkdvli { get; set; }

    public double SatiadeMik { get; set; }

    public double SatiadeTopkdvli { get; set; }
}
