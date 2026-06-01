using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class StkTip
{
    public int Id { get; set; }

    public string? Kod { get; set; }

    public string? AckTr { get; set; }

    public string? AckEn { get; set; }

    public string? AckAl { get; set; }

    public string? AckRu { get; set; }

    public int? OndalikHane { get; set; }
}
