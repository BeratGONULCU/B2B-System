using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class RehberGrupDetay
{
    public int Id { get; set; }

    public int? GrupId { get; set; }

    public int? StokGrupId { get; set; }

    public double? KomisyonYuzde { get; set; }

    public double? IndirimYuzde { get; set; }

    public DateTime? OlusturmaTarihSaat { get; set; }

    public string? OlusturmaKullaniciUnvan { get; set; }

    public DateTime? DegistirmeTarihSaat { get; set; }

    public string? DegistirmeKullaniciUnvan { get; set; }

    public DateTime? SilTarihSaat { get; set; }

    public string? SilKullaniciUnvan { get; set; }

    public bool? Sil { get; set; }
}
