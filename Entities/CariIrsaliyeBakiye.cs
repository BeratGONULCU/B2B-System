using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class CariIrsaliyeBakiye
{
    public string? Carkod { get; set; }

    public string? Cartip { get; set; }

    public int? IrsAdet { get; set; }

    public double IrsBakiye { get; set; }

    public double IrsBrcbakiye { get; set; }

    public double IrsAlcbakiye { get; set; }
}
