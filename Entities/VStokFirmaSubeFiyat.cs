using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class VStokFirmaSubeFiyat
{
    public int? Firmano { get; set; }

    public decimal StkId { get; set; }

    public string StkKod { get; set; } = null!;

    public double? SatisFiyat1Kdv { get; set; }

    public double SatisFiyat1KdvDahil { get; set; }

    public double? SatisFiyat2Kdv { get; set; }

    public double SatisFiyat2KdvDahil { get; set; }

    public double? SatisFiyat3Kdv { get; set; }

    public double SatisFiyat3KdvDahil { get; set; }

    public double? SatisFiyat4Kdv { get; set; }

    public double SatisFiyat4KdvDahil { get; set; }

    public double? AlisFiyatKdv { get; set; }

    public double AlisFiyatKdvDahil { get; set; }
}
