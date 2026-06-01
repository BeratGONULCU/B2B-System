using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Numarator
{
    public decimal Id { get; set; }

    public int? Firmano { get; set; }

    public string? Seri { get; set; }

    public decimal? Numara { get; set; }

    public string? Tip { get; set; }

    public string? Tipack { get; set; }

    public int? Uzunluk { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }
}
