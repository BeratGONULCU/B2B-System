using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class RaporGrupKriter
{
    public int Id { get; set; }

    public string? RapKod { get; set; }

    public int? UserId { get; set; }

    public string? Ack { get; set; }

    public int? CarTipId { get; set; }

    public int? MasId { get; set; }

    public string? DegerKodIn { get; set; }

    public bool? Sil { get; set; }

    public int? DegerTip { get; set; }

    public int? Carpan { get; set; }

    public string? HrkTip { get; set; }
}
