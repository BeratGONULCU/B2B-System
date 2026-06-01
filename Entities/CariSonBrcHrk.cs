using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class CariSonBrcHrk
{
    public string? Carkod { get; set; }

    public string? Cartip { get; set; }

    public DateTime? SonbrcTarih { get; set; }

    public double SonbrcTutar { get; set; }
}
