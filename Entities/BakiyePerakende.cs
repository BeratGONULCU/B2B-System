using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class BakiyePerakende
{
    public string Kod { get; set; } = null!;

    public double Borc { get; set; }

    public double Alacak { get; set; }

    public double CarBakiye { get; set; }

    public DateTime? SonhrkTarih { get; set; }

    public DateTime? SonFisTarih { get; set; }

    public double SonFisTutar { get; set; }

    public int FisAdet { get; set; }

    public double FisBakiye { get; set; }
}
