using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Fattip
{
    public int Id { get; set; }

    public string Kod { get; set; } = null!;

    public string? Ad { get; set; }

    public byte? Gctip { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Tip { get; set; }

    public int? TurId { get; set; }

    public string? Gc { get; set; }

    public bool? Gizli { get; set; }
}
