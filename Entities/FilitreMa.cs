using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class FilitreMa
{
    public int Id { get; set; }

    public int? GrpId { get; set; }

    public string? GrpAd { get; set; }

    public string? AlanAd { get; set; }

    public string? AlanAck { get; set; }

    public int? DegerTip { get; set; }

    public string? QueryTable { get; set; }

    public string? QueryTableSorgu { get; set; }
}
