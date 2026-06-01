using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Zraporhrk
{
    public int Id { get; set; }

    public int Zrapid { get; set; }

    public string? Tip { get; set; }

    public string? Kod { get; set; }

    public bool? Sil { get; set; }

    public double? Kdvyuz { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public byte? Kayok { get; set; }

    public double? Miktar { get; set; }

    public double? Brmfiy { get; set; }
}
