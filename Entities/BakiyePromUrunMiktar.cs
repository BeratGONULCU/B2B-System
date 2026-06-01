using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class BakiyePromUrunMiktar
{
    public decimal StkId { get; set; }

    public int? TipId { get; set; }

    public double GirenMiktar { get; set; }

    public double CikanMiktar { get; set; }

    public double MevcutMiktar { get; set; }
}
