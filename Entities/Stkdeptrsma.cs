using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Stkdeptrsma
{
    public int Id { get; set; }

    public int? TrsId { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public int? Cfirmano { get; set; }

    public int? Gfirmano { get; set; }

    public string? Girdepkod { get; set; }

    public int? GirdepId { get; set; }

    public string? Cikdepkod { get; set; }

    public int? CikdepId { get; set; }

    public string? BelSeri { get; set; }

    public string? BelNo { get; set; }

    public string? Ack { get; set; }

    public string? Yertip { get; set; }

    public string? Yerad { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public int? Sil { get; set; }

    public int? GirDepTip { get; set; }

    public int? CikDepTip { get; set; }

    public double? GenTop { get; set; }

    public byte? Kayok { get; set; }
}
