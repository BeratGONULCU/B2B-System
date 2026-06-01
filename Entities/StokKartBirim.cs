using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class StokKartBirim
{
    public string Tip { get; set; } = null!;

    public string Kod { get; set; } = null!;

    public string? BrmKod { get; set; }

    public double? BrmCarpan { get; set; }
}
