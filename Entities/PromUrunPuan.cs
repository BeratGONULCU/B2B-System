using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class PromUrunPuan
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public int? UrunTipId { get; set; }

    public int? UrunId { get; set; }

    public int? Grp1 { get; set; }

    public int? PuanTip { get; set; }

    public int? PuanBrm { get; set; }

    public double? PuanNakit { get; set; }

    public double? PuanKk { get; set; }

    public double? PuanFis { get; set; }

    public double? PuanOtomas { get; set; }

    public byte? Sil { get; set; }

    public string? DegisUser { get; set; }

    public DateTime? DegisTarSaat { get; set; }

    public string? OlusUser { get; set; }

    public DateTime? OlusTarSaat { get; set; }

    public double? PuanOtomas2 { get; set; }
}
