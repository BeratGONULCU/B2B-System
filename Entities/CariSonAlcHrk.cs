using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class CariSonAlcHrk
{
    public string? Carkod { get; set; }

    public string? Cartip { get; set; }

    public DateTime? SonalcTarih { get; set; }

    public double SonalcTutar { get; set; }
}
