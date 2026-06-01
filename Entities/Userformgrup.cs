using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Userformgrup
{
    public decimal Id { get; set; }

    public double? Firmano { get; set; }

    public string Kod { get; set; } = null!;

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }
}
