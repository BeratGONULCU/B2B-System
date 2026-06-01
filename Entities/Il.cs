using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Il
{
    public decimal Id { get; set; }

    public string Kod { get; set; } = null!;

    public string? Ad { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }
}
