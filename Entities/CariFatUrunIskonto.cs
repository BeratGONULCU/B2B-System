using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class CariFatUrunIskonto
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public string? StkTip { get; set; }

    public int? StkTipId { get; set; }

    public int? StkId { get; set; }

    public string? StkKod { get; set; }

    public int? CartipId { get; set; }

    public int? CarId { get; set; }

    public string? CarKod { get; set; }

    public double? IskontoOran { get; set; }

    public bool? Sil { get; set; }

    public string? IskontoTip { get; set; }
}
