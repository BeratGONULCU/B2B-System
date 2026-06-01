using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class HariciKart
{
    public int Id { get; set; }

    public int? TipId { get; set; }

    public string? Tip { get; set; }

    public string? Kod { get; set; }

    public string? Ad { get; set; }

    public string? Cartip { get; set; }

    public string? Parabrm { get; set; }

    public byte? Sil { get; set; }
}
