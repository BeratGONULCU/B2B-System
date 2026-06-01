using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Bolum
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public string? Ad { get; set; }

    public int? Sfirmano { get; set; }

    public bool? Havuz { get; set; }

    public string? Anaformnesne { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Modul { get; set; }
}
