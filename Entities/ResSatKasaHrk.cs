using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class ResSatKasaHrk
{
    public int Id { get; set; }

    public double? ResSatId { get; set; }

    public string? CariTip { get; set; }

    public string? CariKod { get; set; }

    public string? GcTip { get; set; }

    public bool? Sil { get; set; }

    public double? Tutar { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public double? Kur { get; set; }

    public string? OlusUser { get; set; }

    public DateTime? OlusTarSaat { get; set; }

    public string? ParaBirim { get; set; }

    public string? DegUser { get; set; }

    public DateTime? DegTarSaat { get; set; }

    public string? KasaKod { get; set; }

    public byte? CariTipId { get; set; }

    public int? CariId { get; set; }

    public int? KasaId { get; set; }

    public int? RemoteId { get; set; }

    public int? VarNo { get; set; }
}
