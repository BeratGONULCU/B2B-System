using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class OzelKod
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public string? Tip { get; set; }

    public string? Kod { get; set; }

    public string? Ad { get; set; }

    public int? Sil { get; set; }
}
