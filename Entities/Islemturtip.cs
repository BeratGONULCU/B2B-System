using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Islemturtip
{
    public decimal Id { get; set; }

    public string Tip { get; set; } = null!;

    public string? Ad { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }
}
