using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class TeslimYerKart
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public string? Unvan { get; set; }

    public string? Adres { get; set; }

    public string? AdresIl { get; set; }

    public string? AdresIlce { get; set; }

    public DateTime? OlusturmaTarihSaat { get; set; }

    public string? OlusturmaKullaniciUnvan { get; set; }

    public DateTime? DegistirmeTarihSaat { get; set; }

    public string? DegistirmeKullaniciUnvan { get; set; }

    public DateTime? SilTarihSaat { get; set; }

    public string? SilKullaniciUnvan { get; set; }

    public bool? Sil { get; set; }

    public int? RemoteId { get; set; }

    public string? AdresPostaKod { get; set; }
}
