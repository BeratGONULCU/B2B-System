using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class PdaFaturaSayimMa
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public string? Cartip { get; set; }

    public string? Carkod { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public double? StkTopMik { get; set; }

    public string? Drm { get; set; }

    public string? Ack { get; set; }

    public double? BarCapran { get; set; }
}
