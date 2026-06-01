using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class CariCalismaSart
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public string Ad { get; set; } = null!;

    public string? Fatvadtip { get; set; }

    public int? Fatvadsur { get; set; }

    public string? Fisvadtip { get; set; }

    public int? Fisvadsur { get; set; }

    public double? Fatisk { get; set; }

    public double? Fisvadfark { get; set; }

    public double? Fatvadfark { get; set; }

    public double? TtsBayisk { get; set; }

    public double? TtsDagisk { get; set; }

    public double? TtsBayVadFark { get; set; }

    public double? TtsDagVadFark { get; set; }

    public double? ToplamLimit { get; set; }

    public int? LimitTip { get; set; }

    public double? RiskLimit { get; set; }

    public int? TtsOdeTip { get; set; }

    public string? DbsRefNo { get; set; }

    public bool? OtoFisVadeFark { get; set; }

    public bool? AvansTakip { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Deguser { get; set; }

    public bool? Sil { get; set; }

    public double? Fisisk { get; set; }

    public bool? WebAvans { get; set; }

    public bool? WebFatura { get; set; }

    public bool? WebCariHrk { get; set; }

    public bool? WebCariBakiye { get; set; }

    public bool? WebFisOdendi { get; set; }

    public bool? WebFaturaOdendi { get; set; }

    public bool? WebPos { get; set; }

    public bool? WebFisIskontoluTahsil { get; set; }

    public bool? Web { get; set; }

    public bool? WebFis { get; set; }

    public bool? WebFaturaIskontoluTahsil { get; set; }

    public bool? WebFaturaTahsil { get; set; }

    public bool? WebFisTahsil { get; set; }
}
