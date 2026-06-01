using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Parametre
{
    public int Id { get; set; }

    public int? FirmaNo { get; set; }

    public string? UserKod { get; set; }

    public string? Ad { get; set; }

    public string? Bolum { get; set; }

    public string? Deger { get; set; }
}
