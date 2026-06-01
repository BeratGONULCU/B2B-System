using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Userformhrk
{
    public decimal Id { get; set; }

    public double? Formid { get; set; }

    public double? Firmano { get; set; }

    public int? Tan1 { get; set; }

    public int? Tan2 { get; set; }

    public int? Tan3 { get; set; }

    public int? Tan4 { get; set; }

    public int? Tan5 { get; set; }

    public int? Tan6 { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }
}
