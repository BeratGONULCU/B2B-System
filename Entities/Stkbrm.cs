using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Stkbrm
{
    public decimal Id { get; set; }

    public string Kod { get; set; } = null!;

    public int? Firmano { get; set; }

    public string? Ad { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public int? Dataok { get; set; }

    public bool? Sil { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }
}
