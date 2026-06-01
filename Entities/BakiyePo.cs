using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class BakiyePo
{
    public string Kod { get; set; } = null!;

    public double BekBak { get; set; }

    public double KomBak { get; set; }

    public double? VadGelen { get; set; }
}
