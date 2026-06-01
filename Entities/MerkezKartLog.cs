using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class MerkezKartLog
{
    public int Id { get; set; }

    public string? TabloAd { get; set; }

    public DateTime? TarihSaat { get; set; }

    public int? Tip { get; set; }
}
