using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class BakiyeKasa
{
    public string Kod { get; set; } = null!;

    public decimal Giren { get; set; }

    public decimal Cikan { get; set; }
}
