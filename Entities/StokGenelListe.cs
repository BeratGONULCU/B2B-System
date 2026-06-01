using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class StokGenelListe
{
    public int? Firmano { get; set; }

    public decimal Id { get; set; }

    public int? TipId { get; set; }

    public string Tip { get; set; } = null!;

    public string Tipi { get; set; } = null!;

    public string Kod { get; set; } = null!;

    public string? Ad { get; set; }

    public int Sil { get; set; }

    public int? Grp1 { get; set; }

    public int? Grp2 { get; set; }

    public int? Grp3 { get; set; }

    public double? Alskdv { get; set; }

    public double? Sat1kdv { get; set; }

    public double? Sat2kdv { get; set; }

    public double? Sat3kdv { get; set; }

    public double? Sat4kdv { get; set; }

    public double? Sat1fiykdvli { get; set; }

    public double? Sat1fiykdvsiz { get; set; }

    public double? Sat2fiykdvli { get; set; }

    public double? Sat2fiykdvsiz { get; set; }

    public double? Alsfiykdvli { get; set; }

    public double? Alsfiykdvsiz { get; set; }

    public bool? Prom { get; set; }

    public byte? PuanTip { get; set; }

    public double? PuanBrm { get; set; }

    public double? PuanNakit { get; set; }

    public double? PuanKk { get; set; }

    public double? PuanFis { get; set; }
}
