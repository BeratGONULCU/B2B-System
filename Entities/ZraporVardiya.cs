using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class ZraporVardiya
{
    public int Id { get; set; }

    public int? Zrapid { get; set; }

    public int? VarTip { get; set; }

    public int? VarNo { get; set; }

    public string? VarAd { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? OlusUser { get; set; }

    public DateTime? DegisTarsaat { get; set; }

    public string? DegisUser { get; set; }

    public bool? Sil { get; set; }
}
