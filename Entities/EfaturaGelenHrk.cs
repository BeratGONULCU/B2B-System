using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class EfaturaGelenHrk
{
    public int Id { get; set; }

    public int? EfatId { get; set; }

    public int? Firmano { get; set; }

    public int? SiraNo { get; set; }

    public string? Ad { get; set; }

    public double? Miktar { get; set; }

    public string? Birim { get; set; }

    public double? Fiyat { get; set; }

    public double? IskYuz { get; set; }

    public double? KdvYuz { get; set; }

    public double? Carpan { get; set; }

    public string? OlusUser { get; set; }

    public DateTime? OlusTarSaat { get; set; }

    public string? DegUser { get; set; }

    public DateTime? DegTarSaat { get; set; }

    public bool? Sil { get; set; }

    public int? StkTip { get; set; }

    public int? StkId { get; set; }

    public string? DepoTipId { get; set; }

    public string? StkUniqueId { get; set; }

    public double? EfaturaMiktar { get; set; }

    public double? EfaturaFiyat { get; set; }

    public string? Barkod { get; set; }

    public double? Kesafet { get; set; }

    public string? EfaturaBirim { get; set; }
}
