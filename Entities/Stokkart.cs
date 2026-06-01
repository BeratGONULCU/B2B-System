using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Stokkart
{
    public decimal Id { get; set; }

    public string Tip { get; set; } = null!;

    public string Kod { get; set; } = null!;

    public int? Firmano { get; set; }

    public string? Barkod { get; set; }

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

    public string? Muhgrskod { get; set; }

    public string? Muhckskod { get; set; }

    public double? Brmcarp { get; set; }

    public string? Brmust { get; set; }

    public string? Ykno { get; set; }

    public int? Grp1 { get; set; }

    public int? Grp2 { get; set; }

    public int? Grp3 { get; set; }

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

    public double? Alskdvlitoptut { get; set; }

    public double? Satkdvlitoptut { get; set; }

    public double? Alsiademik { get; set; }

    public double? Alsiadekdvlitoptut { get; set; }

    public double? Satiademik { get; set; }

    public double? Satiadekdvlitoptut { get; set; }

    public double? Ortalsfiykdvli { get; set; }

    public string? Brmust2 { get; set; }

    public double? Brmcarp2 { get; set; }

    public byte? Zrapor { get; set; }

    public string? MuhAlsIadKod { get; set; }

    public string? MuhSatIadKod { get; set; }

    public string? MuhAlsIskKod { get; set; }

    public string? MuhSatIskKod { get; set; }

    public string? MuhAlsOtvKod { get; set; }

    public string? MuhSatOtvKod { get; set; }

    public string? MuhSatMalKod { get; set; }

    public string? Muhonkod { get; set; }

    public int? OzelKod1 { get; set; }

    public int? OzelKod2 { get; set; }

    public string? Notack { get; set; }

    public int? TipId { get; set; }

    public byte? PuanBrm { get; set; }

    public byte? PuanTip { get; set; }

    public double? PuanNakit { get; set; }

    public double? PuanKk { get; set; }

    public double? PuanFis { get; set; }

    public bool? Prom { get; set; }

    public bool? PromUrun { get; set; }

    public byte? PromSatTip { get; set; }

    public double? PromSatPuan { get; set; }

    public int? PromKacSatis { get; set; }

    public double? PuanOtomas { get; set; }

    public string? Gtip { get; set; }

    public int? EpdkTur { get; set; }

    public int? YkFiyat { get; set; }

    public bool? Recete { get; set; }

    public bool? Restaurant { get; set; }

    public int? RemoteId { get; set; }

    public double? KarYuzde { get; set; }

    public int? Bildirim { get; set; }

    public string? BagliCariKod { get; set; }

    public bool? Yerli { get; set; }

    public int? UretimYerId { get; set; }

    public DateTime? SatisFiyat1DegisimTarih { get; set; }

    public DateTime? SatisFiyat2DegisimTarih { get; set; }

    public DateTime? SatisFiyat3DegisimTarih { get; set; }

    public DateTime? SatisFiyat4DegisimTarih { get; set; }

    public int? OlcumBirimId { get; set; }

    public double? OlcumBirimCarpan { get; set; }

    public bool? SatisFiyatDegistir { get; set; }

    public int? EtiketId { get; set; }

    public DateTime? AlisFiyatDegisimTarih { get; set; }
}
