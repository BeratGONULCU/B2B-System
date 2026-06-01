using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Fisma
{
    public int Id { get; set; }

    public int? Fisid { get; set; }

    public string Fisno { get; set; } = null!;

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public string? Cartip { get; set; }

    public string? Carkod { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public double? Toptut { get; set; }

    public string? Yertip { get; set; }

    public string? Ack { get; set; }

    public bool? Sil { get; set; }

    public int? Firmano { get; set; }
}
