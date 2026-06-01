using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class StokSonKullanim
{
    public int Id { get; set; }

    public int? FirmaNo { get; set; }

    public int? StokId { get; set; }

    public DateTime? Tarih { get; set; }

    public double? Miktar { get; set; }

    public DateTime? OlusturmaTarihSaat { get; set; }

    public string? OlusturmaKullaniciUnvan { get; set; }

    public DateTime? DegistirmeTarihSaat { get; set; }

    public string? DegistirmeKullaniciUnvan { get; set; }

    public DateTime? SilTarihSaat { get; set; }

    public string? SilKullaniciUnvan { get; set; }

    public bool? Sil { get; set; }
}
