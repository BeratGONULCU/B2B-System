using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class TtsBankaTahsilat
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public string? Plaka { get; set; }

    public DateTime? OdeTarih { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public double? Tutar { get; set; }

    public string? Dosya { get; set; }

    public int? Verid { get; set; }

    public string? CariKod { get; set; }

    public string? FisSeriNo { get; set; }
}
