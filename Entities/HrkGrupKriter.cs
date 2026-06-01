using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class HrkGrupKriter
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? AckTr { get; set; }

    public int? Tip { get; set; }

    public int? Genel { get; set; }
}
