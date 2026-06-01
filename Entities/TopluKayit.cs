using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class TopluKayit
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public int? IslemTipId { get; set; }

    public int? KartTipId { get; set; }

    public string? KartKod { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public string? BelgeNo { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? OlusTarihSaat { get; set; }

    public string? OlusUser { get; set; }

    public DateTime? DegisTarihSaat { get; set; }

    public string? DegisUser { get; set; }

    public bool? Sil { get; set; }

    public bool? KayOk { get; set; }
}
