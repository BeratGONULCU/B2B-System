using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Sayimstkgrp
{
    public decimal Id { get; set; }

    public double? Sayid { get; set; }

    public int? Firmano { get; set; }

    public string? Depkod { get; set; }

    public string? Stktip { get; set; }

    public double? Stkgrp1 { get; set; }

    public double? Stkgrp2 { get; set; }

    public double? Stkgrp3 { get; set; }

    public bool? Sil { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }
}
