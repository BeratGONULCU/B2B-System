using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class PdaOffSayimHrk
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public int Offsayid { get; set; }

    public string? StkTip { get; set; }

    public string? StkKod { get; set; }

    public double? Miktar { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public int? Sil { get; set; }

    public string? StkBarkod { get; set; }

    public double? Kaymiktar { get; set; }
}
