using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class RehberBarkodListesi
{
    public int RehberId { get; set; }

    public int? RehberGrupId { get; set; }

    public int BarkodId { get; set; }

    public string? Barkod { get; set; }

    public string? RehberUnvan { get; set; }
}
