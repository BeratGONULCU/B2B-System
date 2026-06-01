using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class ParaKur
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public string? Kod { get; set; }

    public DateTime? Tarih { get; set; }

    public double? DovAlis { get; set; }

    public double? DovSatis { get; set; }

    public double? EfkAlis { get; set; }

    public double? EfkSatis { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Deguser { get; set; }
}
