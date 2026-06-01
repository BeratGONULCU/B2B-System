using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class PlakaLimitCariMiktar
{
    public string? Cartip { get; set; }

    public string? Carkod { get; set; }

    public double Miktarlt { get; set; }

    public double Lttutar { get; set; }
}
