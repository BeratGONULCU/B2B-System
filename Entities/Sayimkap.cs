using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Sayimkap
{
    public decimal Id { get; set; }

    public double Sayid { get; set; }

    public string? Kaptip { get; set; }

    public int? Firmano { get; set; }

    public string? Kod { get; set; }

    public double? Tutar { get; set; }

    public string? Ackfaz { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public int? Dataok { get; set; }

    public string? Saymiktip { get; set; }

    public bool? Sil { get; set; }
}
