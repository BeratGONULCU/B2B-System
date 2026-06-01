using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Usrsplit
{
    public decimal Id { get; set; }

    public string Users { get; set; } = null!;

    public int? Firmano { get; set; }

    public string? Form { get; set; }

    public int? Genis { get; set; }

    public string? Panel { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }
}
