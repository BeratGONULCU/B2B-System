using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class TankKartListesi
{
    public decimal Id { get; set; }

    public string Kod { get; set; } = null!;

    public string Bagak { get; set; } = null!;

    public int Firmano { get; set; }

    public string? Ad { get; set; }

    public int? Sil { get; set; }

    public int? Dataok { get; set; }

    public double? Kapsit { get; set; }

    public double? Minmik { get; set; }

    public string? Drm { get; set; }

    public double? Acmik { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public double? Alsmik { get; set; }

    public double? Satmik { get; set; }

    public string? Stktip { get; set; }

    public double? Alskdvlitoptut { get; set; }

    public double? Satkdvlitoptut { get; set; }

    public int? RemoteId { get; set; }

    public double? GirMiktar { get; set; }

    public double? CikMiktar { get; set; }

    public double? MevMiktar { get; set; }

    public double? GirTopkdvli { get; set; }

    public double? GirTopkdvsiz { get; set; }

    public double? CikTopkdvli { get; set; }

    public double? CikTopkdvsiz { get; set; }

    public double? Satfiykdvli { get; set; }

    public double? Satfiykdvsiz { get; set; }

    public double? Alsfiykdvli { get; set; }

    public double? Alsfiykdvsiz { get; set; }

    public double? Kalsattopkdvsiz { get; set; }

    public double? Kalsattopkdvli { get; set; }

    public double? Kalalstopkdvsiz { get; set; }

    public double? Kalalstopkdvli { get; set; }
}
