using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class CariTeminatIlk
{
    public string Kod { get; set; } = null!;

    public string CarTip { get; set; } = null!;

    public string? Tur { get; set; }

    public double? Tutar { get; set; }

    public string? Ack { get; set; }
}
