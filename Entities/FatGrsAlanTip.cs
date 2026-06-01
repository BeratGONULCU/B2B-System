using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class FatGrsAlanTip
{
    public int Id { get; set; }

    public int? TipId { get; set; }

    public int? Tab { get; set; }

    public string? AckTr { get; set; }

    public string? AckEn { get; set; }

    public string? AckAl { get; set; }

    public string? AckRu { get; set; }
}
