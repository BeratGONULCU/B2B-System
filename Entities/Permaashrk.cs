using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Permaashrk
{
    public int Id { get; set; }

    public int? Permaashrkid { get; set; }

    public int? Firmano { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public string? Carkod { get; set; }

    public string? Cartip { get; set; }

    public string? Gidkod { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Olususer { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public double? Kur { get; set; }

    public string? Parabrm { get; set; }

    public double? Tutar { get; set; }

    public byte? Sil { get; set; }

    public string? Yertip { get; set; }

    public string? Yerad { get; set; }

    public string? Belno { get; set; }

    public string? Ack { get; set; }
}
