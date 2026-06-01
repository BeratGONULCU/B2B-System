using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class VMarketSatisUrunIdReceteMaliyet
{
    public long? MarSatId { get; set; }

    public long? MarSatHrkId { get; set; }

    public long? MarSatRecHrkId { get; set; }

    public int? UrunId { get; set; }

    public double? BirimMaliyetFiyat { get; set; }
}
