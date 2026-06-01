using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class PerCari
{
    public int Id { get; set; }

    public int? PerId { get; set; }

    public string? PerKod { get; set; }

    public string? Cartip { get; set; }

    public int? CarTipId { get; set; }

    public int? CarId { get; set; }

    public string? CarKod { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }
}
