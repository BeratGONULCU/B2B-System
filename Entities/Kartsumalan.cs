using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Kartsumalan
{
    public int Id { get; set; }

    public string? Tabload { get; set; }

    public string? Alanad { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }
}
