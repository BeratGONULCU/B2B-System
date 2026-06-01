using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Otomaskarthrk
{
    public decimal Id { get; set; }

    public string Otmaskod { get; set; } = null!;

    public int? Firmano { get; set; }

    public string? Kod { get; set; }

    public string? Ad { get; set; }

    public int? Pos { get; set; }

    public int? Uzn { get; set; }

    public string? Iptkar { get; set; }

    public int? Onpos { get; set; }

    public int? Onuzn { get; set; }

    public int? Oku { get; set; }

    public int? Sr { get; set; }

    public bool? Sil { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }
}
