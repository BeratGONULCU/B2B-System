using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Pomvardiperadum
{
    public decimal Id { get; set; }

    public double Varno { get; set; }

    public int? Varok { get; set; }

    public int? Firmano { get; set; }

    public int? Sil { get; set; }

    public string? Per { get; set; }

    public int? Sr { get; set; }

    public int? Adaid { get; set; }

    public string? Adad { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public int? RemoteId { get; set; }

    public int? TransferStartId { get; set; }

    public int? TransferStopId { get; set; }

    public DateTime? TransferDateTime { get; set; }
}
