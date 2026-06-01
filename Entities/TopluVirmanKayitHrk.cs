using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class TopluVirmanKayitHrk
{
    public int Id { get; set; }

    public int? TopluKayitId { get; set; }

    public int? SiraNo { get; set; }

    public int? KartTipId { get; set; }

    public string? KartUniqId { get; set; }

    public string? KartKod { get; set; }

    public double? Borc { get; set; }

    public double? Alacak { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? OlusTarihSaat { get; set; }

    public string? OlusUser { get; set; }

    public DateTime? DegisTarihSaat { get; set; }

    public string? DegisUser { get; set; }

    public bool? Sil { get; set; }
}
