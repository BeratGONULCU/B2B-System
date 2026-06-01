using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class EntegreMuhHesKod
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public string? Tip { get; set; }

    public string? Kod { get; set; }

    public string? Ack { get; set; }

    public string? Deger { get; set; }

    public double? KdvOran { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Parabrm { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }
}
