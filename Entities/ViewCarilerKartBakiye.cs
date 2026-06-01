using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class ViewCarilerKartBakiye
{
    public decimal Id { get; set; }

    public int? Sl { get; set; }

    public string Kod { get; set; } = null!;

    public string? Ad { get; set; }

    public int? Grp1 { get; set; }

    public int? Grp2 { get; set; }

    public int? Grp3 { get; set; }

    public string? Fatunvan { get; set; }

    public string Cartp { get; set; } = null!;

    public double? Fisvadfark { get; set; }

    public double? Fatvadfark { get; set; }

    public int Crno { get; set; }

    public string? Tcno { get; set; }

    public string Tip { get; set; } = null!;

    public string? Adres { get; set; }

    public string? Adres2 { get; set; }

    public string? Evil { get; set; }

    public string? Evilce { get; set; }

    public string? Vergidaire { get; set; }

    public string? Vergino { get; set; }

    public string? YktAlmDefNo { get; set; }

    public string? AracAd { get; set; }

    public string? Tel { get; set; }

    public string? Cep { get; set; }

    public string? Fax { get; set; }

    public string? Mail { get; set; }

    public double? Fisbak { get; set; }

    public double? Carbak { get; set; }

    public double? Topbak { get; set; }

    public double? Toplimit { get; set; }

    public double? CekharcBakiye { get; set; }

    public double? CekBakiye { get; set; }

    public string? GrupAd { get; set; }
}
