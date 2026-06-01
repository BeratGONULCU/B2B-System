using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Otomaspumptan
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public byte? Tip { get; set; }

    public string? Kod { get; set; }

    public int? Sira { get; set; }
}
