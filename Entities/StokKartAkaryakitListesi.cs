using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class StokKartAkaryakitListesi
{
    public decimal Id { get; set; }

    public int? RemoteId { get; set; }

    public string Tip { get; set; } = null!;

    public string Kod { get; set; } = null!;

    public int? Grp1 { get; set; }

    public int? Grp2 { get; set; }

    public int? Grp3 { get; set; }

    public int? Firmano { get; set; }

    public string? Ad { get; set; }

    public double? Sat1fiy { get; set; }

    public double? Sat1kdv { get; set; }

    public string? Sat1kdvtip { get; set; }

    public double? Sat2fiy { get; set; }

    public double? Sat2kdv { get; set; }

    public string? Sat2kdvtip { get; set; }

    public double? Alsfiy { get; set; }

    public double? Alskdv { get; set; }

    public string? Alskdvtip { get; set; }

    public double? Kesft { get; set; }

    public string? Brim { get; set; }

    public double? Otv { get; set; }

    public string? Eksat { get; set; }

    public double? Minmik { get; set; }

    public string Drm { get; set; } = null!;

    public byte? Zrapor { get; set; }

    public string? Muhgrskod { get; set; }

    public string? Muhckskod { get; set; }

    public string? Muhonkod { get; set; }

    public string? MuhAlsIadKod { get; set; }

    public string? MuhSatIadKod { get; set; }

    public string? MuhAlsIskKod { get; set; }

    public string? MuhSatIskKod { get; set; }

    public string? MuhAlsOtvKod { get; set; }

    public string? MuhSatOtvKod { get; set; }

    public string? MuhSatMalKod { get; set; }

    public double? Brmcarp { get; set; }

    public string? Brmust { get; set; }

    public string? Ykno { get; set; }

    public double? Alsmik { get; set; }

    public double? Satmik { get; set; }

    public int Sil { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public int? Dataok { get; set; }

    public double? Acmik { get; set; }

    public double? Karoran1 { get; set; }

    public double? Karoran2 { get; set; }

    public double? Grpkdvoran { get; set; }

    public string? Sat1pbrm { get; set; }

    public string? Sat2pbrm { get; set; }

    public string? Sat3pbrm { get; set; }

    public string? Sat4pbrm { get; set; }

    public string? Alspbrm { get; set; }

    public double? Sat3fiy { get; set; }

    public double? Sat3kdv { get; set; }

    public string? Sat3kdvtip { get; set; }

    public double? Sat4fiy { get; set; }

    public double? Sat4kdv { get; set; }

    public string? Sat4kdvtip { get; set; }

    public double? Alsiademik { get; set; }

    public double? Satiademik { get; set; }

    public string? Brmust2 { get; set; }

    public double? Brmcarp2 { get; set; }

    public int? EpdkTur { get; set; }

    public double HarMiktar { get; set; }

    public double GirMiktar { get; set; }

    public double CikMiktar { get; set; }

    public double GirTopkdvli { get; set; }

    public double GirTopkdvsiz { get; set; }

    public double CikTopkdvli { get; set; }

    public double CikTopkdvsiz { get; set; }

    public double MevMiktar { get; set; }

    public double AlsiadeMik { get; set; }

    public double SatiadeMik { get; set; }

    public double AlsiadeTopkdvli { get; set; }

    public double SatiadeTopkdvli { get; set; }

    public double OrtalsFiykdvli { get; set; }

    public double OrtalsFiykdvsiz { get; set; }

    public double? Satfiykdvli { get; set; }

    public double? Satfiykdvsiz { get; set; }

    public double? Alsfiykdvli { get; set; }

    public double? Alsfiykdvsiz { get; set; }

    public double? Kalsattopkdvsiz { get; set; }

    public double? Kalsattopkdvli { get; set; }

    public double? Kalalstopkdvsiz { get; set; }

    public double? Kalalstopkdvli { get; set; }
}
