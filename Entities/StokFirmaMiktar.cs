using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class StokFirmaMiktar
{
    public int? Firmano { get; set; }

    public string Stktip { get; set; } = null!;

    public string Stkod { get; set; } = null!;

    public double? Miktar { get; set; }
}
