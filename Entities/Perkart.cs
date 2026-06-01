using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Perkart
{
    public decimal Id { get; set; }

    public string? Drm { get; set; }

    public int? Sil { get; set; }

    public int? Firmano { get; set; }

    public string Kod { get; set; } = null!;

    public string? Ad { get; set; }

    public string? Soyad { get; set; }

    public int? Grp1 { get; set; }

    public int? Grp2 { get; set; }

    public int? Grp3 { get; set; }

    public string? Tel { get; set; }

    public string? Fax { get; set; }

    public string? Cep { get; set; }

    public string? Muhkod { get; set; }

    public byte[]? Resim { get; set; }

    public string? Adres { get; set; }

    public string? Evil { get; set; }

    public string? Evilce { get; set; }

    public string? Vergidaire { get; set; }

    public string? Vergino { get; set; }

    public string? Mail { get; set; }

    public string? Tcno { get; set; }

    public double? Toplim { get; set; }

    public double? Maasgun { get; set; }

    public double? Maas { get; set; }

    public double? Prim { get; set; }

    public double? Isk { get; set; }

    public DateTime? Isbastar { get; set; }

    public DateTime? Isbittar { get; set; }

    public double? Fisbak { get; set; }

    public double? Carbak { get; set; }

    public int? Gos { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public int? Dataok { get; set; }

    public int? Fisadet { get; set; }

    public double? Fisaktut { get; set; }

    public int? Fisakadet { get; set; }

    public string? Parabrm { get; set; }

    public double? Actutar { get; set; }

    public string? Adres2 { get; set; }

    public string? Muhonkod { get; set; }

    public string? Sgkno { get; set; }

    public string? BankaAd { get; set; }

    public string? BankaSube { get; set; }

    public string? Hesapno { get; set; }

    public int? LimitTip { get; set; }

    public string? FileName { get; set; }

    public string? KulKod { get; set; }

    public string? KulSifre { get; set; }

    public string? KasiyerKod { get; set; }
}
