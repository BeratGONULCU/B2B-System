using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Pomvardistok
{
    public decimal Id { get; set; }

    public int? Firmano { get; set; }

    public double Varno { get; set; }

    public int? Varok { get; set; }

    public int? Sil { get; set; }

    public string Kod { get; set; } = null!;

    public string? Stktip { get; set; }

    public double? Acmik { get; set; }

    public double? Satmik { get; set; }

    public double? Kalan { get; set; }

    public decimal? Brimfiy { get; set; }

    public double? Tutar { get; set; }

    public double? Testmik { get; set; }

    public double? TransferCksMik { get; set; }

    public double? Kdvyuz { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public double? TransferGrsMik { get; set; }

    public int? RemoteId { get; set; }

    public int? TransferStartId { get; set; }

    public int? TransferStopId { get; set; }

    public DateTime? TransferDateTime { get; set; }
}
