using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class EvrakNot
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public string? TableAd { get; set; }

    public int? MasId { get; set; }

    public string? Ack { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public bool? Sil { get; set; }
}
