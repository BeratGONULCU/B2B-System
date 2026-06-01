using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class PromMusteriListesi
{
    public decimal OtId { get; set; }

    public decimal Id { get; set; }

    public string? Idx { get; set; }

    public int CartipId { get; set; }

    public string Cartip { get; set; } = null!;

    public int? Firmano { get; set; }

    public int? Grp1 { get; set; }

    public int? Grp2 { get; set; }

    public int? Grp3 { get; set; }

    public string? GrupAd { get; set; }

    public DateTime? DogumTarih { get; set; }

    public string Kod { get; set; } = null!;

    public string? Ad { get; set; }

    public string? Soyad { get; set; }

    public string? Unvan { get; set; }

    public int Sil { get; set; }

    public string? Adres { get; set; }

    public string? Adres2 { get; set; }

    public string? Evil { get; set; }

    public string? Evilce { get; set; }

    public string? Vergino { get; set; }

    public string? Vergidaire { get; set; }

    public string? Tel { get; set; }

    public string? Fax { get; set; }

    public string? Cep { get; set; }

    public string? Mail { get; set; }

    public string? Drm { get; set; }

    public string? Parabrm { get; set; }

    public int? PromGrp1 { get; set; }

    public double GirenPuan { get; set; }

    public double CikanPuan { get; set; }

    public double MevcutPuan { get; set; }

    public double AlsTutar { get; set; }

    public double KulTutar { get; set; }

    public double KalTutar { get; set; }

    public DateTime? SonTarih { get; set; }

    public bool? PromGrs { get; set; }

    public bool? FisGrs { get; set; }

    public string? Plaka { get; set; }

    public string? Kartno { get; set; }

    public decimal KartId { get; set; }
}
