using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class GrafikRapGoster
{
    public int? Id { get; set; }

    public int? Tip { get; set; }

    public string? AckTr { get; set; }

    public string? AckEn { get; set; }

    public bool? Goster { get; set; }
}
