using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class RaporHrkKriter
{
    public int Id { get; set; }

    public string? RapKod { get; set; }

    public int? KartId { get; set; }

    public string? KartKod { get; set; }

    public int? UserId { get; set; }

    public int? Firmano { get; set; }

    public int? GrpId { get; set; }
}
