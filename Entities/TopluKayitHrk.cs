using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class TopluKayitHrk
{
    public int Id { get; set; }

    public int? TopluKayitId { get; set; }

    public int? SiraNo { get; set; }

    public int? KartTipId { get; set; }

    public string? KartUniqId { get; set; }

    public string? KartKod { get; set; }

    public double? Tutar { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? OlusTarihSaat { get; set; }

    public string? OlusUser { get; set; }

    public DateTime? DegisTarihSaat { get; set; }

    public string? DegisUser { get; set; }

    public bool? Sil { get; set; }
}
