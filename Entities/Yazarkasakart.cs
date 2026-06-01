using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Yazarkasakart
{
    public int Id { get; set; }

    public int Firmano { get; set; }

    public string Kod { get; set; } = null!;

    public string? Ad { get; set; }

    public int? Sil { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? DepoKod { get; set; }
}
