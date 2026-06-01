using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class CariTeminat
{
    public string Kod { get; set; } = null!;

    public string? Tip { get; set; }

    public double? Tutar { get; set; }

    public string? Ack { get; set; }
}
