using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Pomvardiper
{
    public decimal Id { get; set; }

    public double Varno { get; set; }

    public int? Varok { get; set; }

    public int? Sil { get; set; }

    public int? Firmano { get; set; }

    public string? Per { get; set; }

    public string? Perad { get; set; }

    public int? Sr { get; set; }

    public double? Perackfaz { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? GecPerKod { get; set; }

    public int? RemoteId { get; set; }

    public int? TransferStartId { get; set; }

    public int? TransferStopId { get; set; }

    public DateTime? TransferDateTime { get; set; }
}
