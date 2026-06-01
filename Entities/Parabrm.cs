using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Parabrm
{
    public int Id { get; set; }

    public string? Kod { get; set; }

    public string? Ad { get; set; }

    public bool? Sabit { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? KurusKod { get; set; }
}
