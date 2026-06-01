using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class PromSatHrk
{
    public long Id { get; set; }

    public double Varno { get; set; }

    public double Promid { get; set; }

    public int? Firmano { get; set; }

    public string? Stktip { get; set; }

    public string? Stkod { get; set; }

    public double? Mik { get; set; }

    public decimal Brmfiy { get; set; }

    public string? Depkod { get; set; }

    public double? Kdvyuz { get; set; }

    public int? Sil { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public int? Dataok { get; set; }

    public int? Kayok { get; set; }

    public string? Brim { get; set; }

    public double? Iskyuz { get; set; }

    public int? RemoteId { get; set; }

    public int? StktipId { get; set; }

    public int? StkId { get; set; }

    public int? DepId { get; set; }

    public string? KartParaBrm { get; set; }

    public double? KartKur { get; set; }

    public string? IslemParaBrm { get; set; }

    public double? IslemKur { get; set; }

    public string? Barkod { get; set; }

    public double? Otvbrim { get; set; }

    public double? KazTopPuan { get; set; }

    public double? TutIskKdvli { get; set; }

    public double? SatBrmPuan { get; set; }

    public double? SatTopPuan { get; set; }

    public double? KazBrmPuan { get; set; }
}
