using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class CariAvansBakiye
{
    public string? Cartip { get; set; }

    public string? Carkod { get; set; }

    public double Borc { get; set; }

    public double Alacak { get; set; }

    public double Bakiye { get; set; }
}
