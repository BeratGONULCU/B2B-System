using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class TabloAlan
{
    public int Id { get; set; }

    public int? Tabloid { get; set; }

    public string? Alan { get; set; }

    public string? Tip { get; set; }

    public string? Alias { get; set; }
}
