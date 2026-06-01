using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Tablelog
{
    public decimal Id { get; set; }

    public int? Firmano { get; set; }

    public string? Tablead { get; set; }

    public double? Hrkid { get; set; }

    public string? Islemtip { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }
}
