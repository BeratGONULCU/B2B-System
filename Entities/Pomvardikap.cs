using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Pomvardikap
{
    public decimal Id { get; set; }

    public double Varno { get; set; }

    public int? Varok { get; set; }

    public int? Sil { get; set; }

    public int? Firmano { get; set; }

    public string? Kaptip { get; set; }

    public string? Kod { get; set; }

    public double? Tutar { get; set; }

    public string? Cartip { get; set; }

    public string? Ackfaz { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public int? Dataok { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public int? RemoteId { get; set; }

    public int? TransferStartId { get; set; }

    public int? TransferStopId { get; set; }

    public DateTime? TransferDateTime { get; set; }
}
