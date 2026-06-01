using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Mesaj
{
    public decimal Id { get; set; }

    public int? Firmano { get; set; }

    public string? KimeUser { get; set; }

    public int? KimeUserId { get; set; }

    public string? Ack { get; set; }

    public DateTime? OlusTarSaat { get; set; }

    public string? OlusUser { get; set; }

    public bool? Drm { get; set; }

    public int? RemoteId { get; set; }
}
