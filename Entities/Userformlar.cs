using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Userformlar
{
    public decimal Id { get; set; }

    public double? Firmano { get; set; }

    public string Grupkod { get; set; } = null!;

    public string Formkod { get; set; } = null!;

    public string? Fromack { get; set; }

    public double? Sira { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }
}
