using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class PromLimit
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public string? Cartip { get; set; }

    public int? CartipId { get; set; }

    public string? Carkod { get; set; }

    public int? CarId { get; set; }

    public int? LimitTip { get; set; }

    public string? LimitKosul { get; set; }
}
