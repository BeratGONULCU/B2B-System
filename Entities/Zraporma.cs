using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Zraporma
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public int Zrapid { get; set; }

    public string? Ykkod { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public string? Carkod { get; set; }

    public string? Cartip { get; set; }

    public string? Zraptip { get; set; }

    public string? Yertip { get; set; }

    public string? Yerad { get; set; }

    public double? Toptut { get; set; }

    public string? Pbrim { get; set; }

    public bool? Sil { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Zserino { get; set; }

    public string? Zseri { get; set; }

    public int? Varno { get; set; }

    public double? Kur { get; set; }

    public string? Ack { get; set; }

    public string? Parabrm { get; set; }

    public byte? Kayok { get; set; }

    public double? GenelKdvTop { get; set; }

    public double? GenelAraTop { get; set; }

    public double? GenelTop { get; set; }

    public int? CartipId { get; set; }

    public double? NakTop { get; set; }

    public double? PosTop { get; set; }

    public double? VerTop { get; set; }

    public bool? Entegre { get; set; }

    public string? EntegreTip { get; set; }

    public DateTime? EntegreAktar { get; set; }

    public int? MasId { get; set; }
}
