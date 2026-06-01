using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class BakiyeCari
{
    public string Kod { get; set; } = null!;

    public int? Grp1 { get; set; }

    public int? Grp2 { get; set; }

    public int? Grp3 { get; set; }

    public double Borc { get; set; }

    public double Alacak { get; set; }

    public double CarBakiye { get; set; }

    public DateTime? SonhrkTarih { get; set; }

    public DateTime? SonbrcTarih { get; set; }

    public DateTime? SonalcTarih { get; set; }

    public double SonalcTutar { get; set; }

    public double SonbrcTutar { get; set; }

    public DateTime? SonFisTarih { get; set; }

    public double FisAlcbakiye { get; set; }

    public double FisBrcbakiye { get; set; }

    public double IrsAlcbakiye { get; set; }

    public double IrsBrcbakiye { get; set; }

    public int IrsAdet { get; set; }

    public double AvansAlcbakiye { get; set; }

    public double AvansBrcbakiye { get; set; }

    public double AvansBakiye { get; set; }

    public double SonFisTutar { get; set; }

    public int FisAdet { get; set; }

    public double FisBakiye { get; set; }

    public double IrsBakiye { get; set; }

    public double CekBakiye { get; set; }

    public double CirBakiye { get; set; }

    public double FisOtoVadeFarkTutar { get; set; }
}
