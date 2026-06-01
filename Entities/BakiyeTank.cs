using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class BakiyeTank
{
    public string Kod { get; set; } = null!;

    public double MevMiktar { get; set; }

    public double GirMiktar { get; set; }

    public double GirTopkdvli { get; set; }

    public double GirTopkdvsiz { get; set; }

    public double CikMiktar { get; set; }

    public double CikTopkdvli { get; set; }

    public double CikTopkdvsiz { get; set; }
}
