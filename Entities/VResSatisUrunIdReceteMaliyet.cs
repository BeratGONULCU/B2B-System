using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class VResSatisUrunIdReceteMaliyet
{
    public long? ResSatId { get; set; }

    public long? ResSatHrkId { get; set; }

    public long? ResSatRecHrkId { get; set; }

    public int? UrunId { get; set; }

    public double? BirimMaliyetFiyat { get; set; }
}
