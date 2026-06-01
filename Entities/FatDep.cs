using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class FatDep
{
    public int Id { get; set; }

    public int? Fatid { get; set; }

    public int? FatHrkId { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public int? Sr { get; set; }

    public int? Cfirmano { get; set; }

    public int? Gfirmano { get; set; }

    public string? Cdepkod { get; set; }

    public string? Gdepkod { get; set; }

    public string? Cstktip { get; set; }

    public string? Gstktip { get; set; }

    public int? CstktipId { get; set; }

    public int? GstktipId { get; set; }

    public int? CstkId { get; set; }

    public int? GstkId { get; set; }

    public string? CstkKod { get; set; }

    public string? GstkKod { get; set; }

    public double? Miktar { get; set; }

    public string? Yerad { get; set; }

    public string? Yertip { get; set; }

    public byte? Sil { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Belno { get; set; }

    public string? Ack { get; set; }
}
