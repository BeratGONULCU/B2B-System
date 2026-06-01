using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class OtomasWebServisHrk
{
    public int Id { get; set; }

    public int? OtomasId { get; set; }

    public int? Firmano { get; set; }

    public DateTime? Tarih { get; set; }

    public int? YakitId { get; set; }

    public string? YakitUnvan { get; set; }

    public string? PersonelKod { get; set; }

    public string? PersonelUnvan { get; set; }

    public int? PompaNo { get; set; }

    public int? TabancaNo { get; set; }

    public double? BrmFiyat { get; set; }

    public double? Miktar { get; set; }

    public double? Tutar { get; set; }

    public string? Plaka { get; set; }

    public int? OdemeTip { get; set; }

    public string? OtomasTip { get; set; }

    public string? FisNo { get; set; }
}
