using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class CariHrkBakiyeAy
{
    public string? Cartip { get; set; }

    public string? Carkod { get; set; }

    public int? Yil { get; set; }

    public int? Ay { get; set; }

    public double Borc { get; set; }

    public double Alacak { get; set; }

    public double Bakiye { get; set; }
}
