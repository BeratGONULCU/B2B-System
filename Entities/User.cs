using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class User
{
    public decimal Id { get; set; }

    public string Kod { get; set; } = null!;

    public int Firmano { get; set; }

    public string? Sifre { get; set; }

    public string? Gorev { get; set; }

    public string? Ad { get; set; }

    public double? Lang { get; set; }

    public DateTime? Gectar { get; set; }

    public bool? Aktif { get; set; }

    public string? Mail { get; set; }

    public string? Pc { get; set; }

    public string? Ip { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Version { get; set; }

    public int? Printduz { get; set; }

    public DateTime? Sisgrstarsaat { get; set; }

    public DateTime? Sisckstarsaat { get; set; }

    public bool? Indsec { get; set; }

    public int? Indyuzde { get; set; }

    public int? Yetki { get; set; }

    public bool? VadGelen { get; set; }

    public int? Firmaid { get; set; }

    public string? MarDepKod { get; set; }

    public int? IslemGunSure { get; set; }

    public byte? FirmaSec { get; set; }

    public byte? PomGecSayacGrs { get; set; }

    public int? PerId { get; set; }

    public byte? ChFirmaSec { get; set; }

    public int? ChTumKartlar { get; set; }

    public DateTime? BilgiEkranGosterimTarih { get; set; }

    public bool? KartListGrupYetki { get; set; }
}
