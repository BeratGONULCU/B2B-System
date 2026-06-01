using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class HrkKriter
{
    public int Id { get; set; }

    public string? Raptip { get; set; }

    public string? Kod { get; set; }

    public byte? Sec { get; set; }

    public int? UserId { get; set; }

    public int? Firmano { get; set; }

    public int? GrpId { get; set; }
}
