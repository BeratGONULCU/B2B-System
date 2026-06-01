using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class RehberBarkod
{
    public int Id { get; set; }

    public int? RehberId { get; set; }

    public string? Barkod { get; set; }

    public bool? Durum { get; set; }

    public DateTime? OlusturmaTarihSaat { get; set; }

    public string? OlusturmaKullaniciUnvan { get; set; }

    public DateTime? DegistirmeTarihSaat { get; set; }

    public string? DegistirmeKullaniciUnvan { get; set; }

    public DateTime? SilTarihSaat { get; set; }

    public string? SilKullaniciUnvan { get; set; }

    public bool? Sil { get; set; }

    public int? RemoteId { get; set; }
}
