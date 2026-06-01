using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class PerakendeKartListesi
{
    public decimal Id { get; set; }

    public int Firmano { get; set; }

    public int Sil { get; set; }

    public string? Drm { get; set; }

    public string Kod { get; set; } = null!;

    public string? Ad { get; set; }

    public string? Soyad { get; set; }

    public string? Unvan { get; set; }

    public int? Grp1 { get; set; }

    public int? Grp2 { get; set; }

    public int? Grp3 { get; set; }

    public string? Ilgili { get; set; }

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

    public string? Kulkod { get; set; }

    public string? Kulsif { get; set; }

    public double? Fisbak { get; set; }

    public double? Carbak { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public int? Dataok { get; set; }

    public string? Parabrm { get; set; }

    public string? Adres2 { get; set; }

    public int? Fisadet { get; set; }

    public string? Muhonkod { get; set; }

    public string? Fatunvan { get; set; }

    public bool? Webextre { get; set; }

    public int? PromGrp1 { get; set; }

    public string? Vergieposta { get; set; }

    public bool? Efatura { get; set; }

    public int? EfaturaTip { get; set; }

    public string? TicSicilNo { get; set; }

    public DateTime? DogumTarih { get; set; }

    public double? FisBakiye { get; set; }

    public double? CarBakiye { get; set; }

    public double? TopBakiye { get; set; }

    public DateTime? SonhrkTarih { get; set; }

    public DateTime? SonFisTarih { get; set; }

    public double? SonFisTutar { get; set; }

    public int? FisAdet { get; set; }

    public double? Topbak { get; set; }

    public string? Grup { get; set; }
}
