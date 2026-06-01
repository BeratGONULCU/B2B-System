using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class FilitreHrk
{
    public int Id { get; set; }

    public bool? Sec { get; set; }

    public int? TanId { get; set; }

    public int? MasId { get; set; }

    public string? Deger { get; set; }

    public string? SorguStr { get; set; }

    public string? DegerSorgu { get; set; }
}
