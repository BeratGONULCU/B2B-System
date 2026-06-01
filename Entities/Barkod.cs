using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Barkod
{
    public decimal Id { get; set; }

    public int? Firmano { get; set; }

    public string Tip { get; set; } = null!;

    public string Kod { get; set; } = null!;

    public string? Barkod1 { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public int? Sil { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public double? Carpan { get; set; }

    public string? Brim { get; set; }

    public byte? TipId { get; set; }

    public int? StkId { get; set; }

    public int? RemoteId { get; set; }

    public bool? Terazi { get; set; }

    public bool? Master { get; set; }
}
