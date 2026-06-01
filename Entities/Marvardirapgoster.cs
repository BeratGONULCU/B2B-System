using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Marvardirapgoster
{
    public int? Id { get; set; }

    public string? Ad { get; set; }

    public bool? Goster { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public bool? Filitre { get; set; }

    public string? FilitreDegerIn { get; set; }

    public string? RapTip { get; set; }
}
