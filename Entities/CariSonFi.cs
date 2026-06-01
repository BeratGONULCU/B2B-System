using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class CariSonFi
{
    public string? Carkod { get; set; }

    public string? Cartip { get; set; }

    public DateTime? FisTarih { get; set; }

    public double FisTutar { get; set; }
}
