using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class AnaMenuHrk
{
    public int Id { get; set; }

    public string? UserKod { get; set; }

    public string? Name { get; set; }

    public string? Class { get; set; }

    public int? IconIndex { get; set; }

    public string? CapTr { get; set; }

    public string? Modul { get; set; }
}
