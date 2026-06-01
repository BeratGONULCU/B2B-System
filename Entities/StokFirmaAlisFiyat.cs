using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class StokFirmaAlisFiyat
{
    public decimal Id { get; set; }

    public int? Firmano { get; set; }

    public string Stktip { get; set; } = null!;

    public string Stkod { get; set; } = null!;

    public double? AlisFiyatKdvli { get; set; }

    public decimal? SonId { get; set; }
}
