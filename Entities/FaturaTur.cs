using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class FaturaTur
{
    public int Id { get; set; }

    public string? AckTr { get; set; }

    public string? AckEn { get; set; }

    public string? AckAl { get; set; }

    public string? AckRu { get; set; }
}
