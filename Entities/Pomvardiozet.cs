using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Pomvardiozet
{
    public decimal Id { get; set; }

    public double Varno { get; set; }

    public int? Firmano { get; set; }

    public int Varok { get; set; }

    public int Sil { get; set; }

    public string? Tip { get; set; }

    public string? Tipack { get; set; }

    public double? Giris { get; set; }

    public double? Cikis { get; set; }

    public double? Bakiye { get; set; }

    public double? Sr { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public int? RemoteId { get; set; }

    public int? TransferStartId { get; set; }

    public int? TransferStopId { get; set; }

    public DateTime? TransferDateTime { get; set; }
}
