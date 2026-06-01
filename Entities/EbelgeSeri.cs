using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class EbelgeSeri
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public int? EbelgeTipId { get; set; }

    public int? EntegratorId { get; set; }

    public string? EntegratorSeri { get; set; }

    public string? EntegratorBayiNo { get; set; }

    public bool? Sil { get; set; }

    public string? OlusUser { get; set; }

    public DateTime? OlusTarSaat { get; set; }

    public string? DegUser { get; set; }

    public DateTime? DegTarSaat { get; set; }
}
