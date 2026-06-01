using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class RehberGrup
{
    public int Id { get; set; }

    public string? Kod { get; set; }

    public string? Ad { get; set; }

    public DateTime? OlusturmaTarihSaat { get; set; }

    public string? OlusturmaKullaniciUnvan { get; set; }

    public DateTime? DegistirmeTarihSaat { get; set; }

    public string? DegistirmeKullaniciUnvan { get; set; }

    public DateTime? SilTarihSaat { get; set; }

    public string? SilKullaniciUnvan { get; set; }

    public bool? Sil { get; set; }
}
