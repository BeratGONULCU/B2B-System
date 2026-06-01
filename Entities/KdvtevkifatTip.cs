using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class KdvtevkifatTip
{
    public int Id { get; set; }

    public string? Kod { get; set; }

    public string? Ad { get; set; }

    public int? Yuzde { get; set; }

    public bool? Sil { get; set; }
}
