using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class RehberGrupDetayListesi
{
    public int GrupId { get; set; }

    public int GrupDetayId { get; set; }

    public int? StokGrupId { get; set; }

    public double? KomisyonYuzde { get; set; }

    public double? IndirimYuzde { get; set; }
}
