using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class TaksitHrk
{
    public int Id { get; set; }

    public string? Tip { get; set; }

    public int? Firmano { get; set; }

    public int? MasId { get; set; }

    public int? Sr { get; set; }

    public DateTime? Tarih { get; set; }

    public double? Tutar { get; set; }

    public double? Kur { get; set; }

    public string? Parabrm { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public bool? Sil { get; set; }

    public bool? Kayok { get; set; }

    public string? Yertip { get; set; }

    public string? Yerad { get; set; }
}
