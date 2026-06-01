using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Islemhrktip
{
    public int Id { get; set; }

    public string? Kod { get; set; }

    public string? Ad { get; set; }

    public string? Tip { get; set; }

    public string? Hrk { get; set; }

    public string? Gc { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }
}
