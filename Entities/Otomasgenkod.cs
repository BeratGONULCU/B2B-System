using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Otomasgenkod
{
    public decimal Id { get; set; }

    public int? Firmano { get; set; }

    public string? Otomaskod { get; set; }

    public string? Cartip { get; set; }

    public string? Kod { get; set; }

    public string? Carkod { get; set; }

    public string? Hrktip { get; set; }

    public string? Plaka { get; set; }

    public string? Otomastip { get; set; }

    public string? Perkod { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public int? Dataok { get; set; }

    public double? Limit { get; set; }

    public string? Limitturu { get; set; }

    public string? Stkod { get; set; }

    public bool? Sil { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Kartno { get; set; }

    public bool? FisGrs { get; set; }

    public bool? PromGrs { get; set; }

    public int? CarId { get; set; }

    public int? CartipId { get; set; }

    public double? Km { get; set; }

    public string? PlakaGidKod { get; set; }

    public int? RemoteId { get; set; }

    public bool? OtoFis { get; set; }
}
