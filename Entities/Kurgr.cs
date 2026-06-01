using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Kurgr
{
    public decimal Id { get; set; }

    public int? Firmano { get; set; }

    public int? Sil { get; set; }

    public DateTime? Tar { get; set; }

    public double? Ytl { get; set; }

    public double? Usd { get; set; }

    public double? Euro { get; set; }

    public double? Gbp { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public int? Dataok { get; set; }
}
