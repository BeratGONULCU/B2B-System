using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class BanknotTip
{
    public int Id { get; set; }

    public string? Ack { get; set; }

    public double? Deger { get; set; }

    public int? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public byte? Sil { get; set; }
}
