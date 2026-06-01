using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Entegre
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public string? Tip { get; set; }

    public string? Beg { get; set; }

    public string? Host { get; set; }

    public string? Users { get; set; }

    public string? Pass { get; set; }

    public string? Dataname { get; set; }
}
