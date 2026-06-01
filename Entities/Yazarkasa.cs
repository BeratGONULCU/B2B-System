using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Yazarkasa
{
    public decimal Id { get; set; }

    public double? Islmid { get; set; }

    public int? Firmano { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public double? Varno { get; set; }

    public string? Dosyayer { get; set; }

    public string? Users { get; set; }

    public string? Islemtipi { get; set; }

    public string? Yazkasatipi { get; set; }

    public string? Aktar { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public int? Marsatid { get; set; }

    public int? KasaNo { get; set; }

    public int? KasiyerNo { get; set; }
}
