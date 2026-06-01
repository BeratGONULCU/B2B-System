using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class BakiyeStokMiktar1
{
    public string Tip { get; set; } = null!;

    public string Kod { get; set; } = null!;

    public int? Grp1 { get; set; }

    public int? Grp2 { get; set; }

    public int? Grp3 { get; set; }

    public int Sil { get; set; }

    public double OrtalsFiykdvli { get; set; }

    public double OrtalsFiykdvsiz { get; set; }

    public double AlsiadeMik { get; set; }

    public double AlsiadeTopkdvli { get; set; }

    public double SatiadeMik { get; set; }

    public double SatiadeTopkdvli { get; set; }

    public double MevMiktar { get; set; }

    public double GirMiktar { get; set; }

    public double GirTopkdvli { get; set; }

    public double GirTopkdvsiz { get; set; }

    public double CikMiktar { get; set; }

    public double CikTopkdvli { get; set; }

    public double CikTopkdvsiz { get; set; }

    public double HarMiktar { get; set; }
}
