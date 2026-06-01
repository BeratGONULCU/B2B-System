using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class StokFiyat
{
    public int Id { get; set; }

    public int? FirmaNo { get; set; }

    public int? StktipId { get; set; }

    public int? StkId { get; set; }

    public byte? FiyTip { get; set; }

    public int? FiyNo { get; set; }

    public double? Fiyat { get; set; }

    public double? Kdv { get; set; }

    public byte? KdvTip { get; set; }

    public string? ParaBrm { get; set; }

    public int? RemoteId { get; set; }

    public DateTime? FiyatDegisimTarih { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }
}
