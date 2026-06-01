using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class KdvOran
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public int? Oran { get; set; }
}
