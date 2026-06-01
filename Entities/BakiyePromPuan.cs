using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class BakiyePromPuan
{
    public int? CarKartId { get; set; }

    public double GirenPuan { get; set; }

    public double CikanPuan { get; set; }

    public double MevcutPuan { get; set; }

    public double AlsTutar { get; set; }

    public double KulTutar { get; set; }

    public DateTime? SonTarih { get; set; }
}
