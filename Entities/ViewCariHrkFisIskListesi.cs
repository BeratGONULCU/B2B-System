using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class ViewCariHrkFisIskListesi
{
    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public int? Ay { get; set; }

    public int? Yil { get; set; }

    public string? Carkod { get; set; }

    public string? Unvan { get; set; }

    public string? Cartip { get; set; }

    public double? Borc { get; set; }

    public double? Alacak { get; set; }

    public double? Fisbakiye { get; set; }

    public double? Kur { get; set; }

    public string? Islmtip { get; set; }

    public string? Islmtipad { get; set; }

    public string? Islmhrk { get; set; }

    public string? Islmhrkad { get; set; }

    public string? Aktip { get; set; }
}
