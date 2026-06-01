using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Cariteminat1
{
    public decimal Id { get; set; }

    public string Kod { get; set; } = null!;

    public int? Firmano { get; set; }

    public string? Tip { get; set; }

    public string? Tur { get; set; }

    public double? Tutar { get; set; }

    public string? Ack { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public bool? Sil { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }
}
