using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class CariCalismaUrunIskonto
{
    public int Id { get; set; }

    public int? MasId { get; set; }

    public int? Tip { get; set; }

    public string? StkTip { get; set; }

    public int? StkTipId { get; set; }

    public int? StkId { get; set; }

    public string? StkKod { get; set; }

    public double? IskontoOran { get; set; }

    public bool? Sil { get; set; }

    public string? OlusUser { get; set; }

    public DateTime? OlusTarSaat { get; set; }

    public string? DegisUser { get; set; }

    public DateTime? DegisTarSaat { get; set; }
}
