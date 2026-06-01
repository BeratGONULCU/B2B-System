using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class AnaMenuMa
{
    public int Id { get; set; }

    public string? UserKod { get; set; }

    public bool? KisayolCap { get; set; }

    public byte? Style { get; set; }

    public bool? CokluSatir { get; set; }

    public string? Modul { get; set; }

    public bool? EskiStyle { get; set; }
}
