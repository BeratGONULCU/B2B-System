using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class RaporMa
{
    public int Id { get; set; }

    public string? RapKod { get; set; }

    public int? UserId { get; set; }

    public string? Ack { get; set; }

    public int? AnaId { get; set; }

    public bool? Sil { get; set; }

    public bool? Ana { get; set; }
}
