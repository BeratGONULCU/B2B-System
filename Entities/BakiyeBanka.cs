using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class BakiyeBanka
{
    public string Kod { get; set; } = null!;

    public double Borc { get; set; }

    public double Alacak { get; set; }
}
