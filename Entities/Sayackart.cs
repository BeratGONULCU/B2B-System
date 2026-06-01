using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Sayackart
{
    public decimal Id { get; set; }

    public string Kod { get; set; } = null!;

    public int? Firmano { get; set; }

    public double? Grp1 { get; set; }

    public string? Ad { get; set; }

    public int? Sil { get; set; }

    public string? Drm { get; set; }

    public string? Muhkod { get; set; }

    public string? Tankod { get; set; }

    public string? Satfiytip { get; set; }

    public double? Acendks { get; set; }

    public string? Enktur { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public int? Dataok { get; set; }

    public double? Sonendks { get; set; }

    public string? Otomaskod { get; set; }

    public int? Grp2 { get; set; }

    public int? Grp3 { get; set; }

    public double? Acmekenks { get; set; }

    public double? Sonmekendks { get; set; }

    public double? Acmekendks { get; set; }

    public int? RemoteId { get; set; }

    public string? Ykkod { get; set; }
}
