using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class ResSatHrk
{
    public int Id { get; set; }

    public string? OlusUser { get; set; }

    public DateTime? OlusTarSaat { get; set; }

    public string? DegisUser { get; set; }

    public DateTime? DegisTarSaat { get; set; }

    public bool? Sil { get; set; }

    public double ResSatId { get; set; }

    public int? StkTipId { get; set; }

    public int? StkId { get; set; }

    public double? Miktar { get; set; }

    public double? BirimFiyat { get; set; }

    public double? KdvYuz { get; set; }

    public string? ParaBirim { get; set; }

    public double? Kur { get; set; }

    public string? Birim { get; set; }

    public string? Barkod { get; set; }

    public int? SatFiyNo { get; set; }

    public double? IndYuz { get; set; }

    public double? BirimCarpan { get; set; }

    public int? VarNo { get; set; }

    public bool? Recete { get; set; }
}
