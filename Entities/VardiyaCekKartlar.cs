using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class VardiyaCekKartlar
{
    public int Id { get; set; }

    public int Sil { get; set; }

    public string Kod { get; set; } = null!;

    public string Ad { get; set; } = null!;

    public string Cartp { get; set; } = null!;

    public string Parabrm { get; set; } = null!;

    public int Crno { get; set; }

    public string Tcno { get; set; } = null!;

    public string Grupad1 { get; set; } = null!;

    public string Tip { get; set; } = null!;

    public string Adres { get; set; } = null!;

    public string Adres2 { get; set; } = null!;

    public string Evil { get; set; } = null!;

    public string Evilce { get; set; } = null!;

    public string Vergidaire { get; set; } = null!;

    public string Vergino { get; set; } = null!;

    public int FisIskonto { get; set; }

    public int FatIskonto { get; set; }
}
