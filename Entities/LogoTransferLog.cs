using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class LogoTransferLog
{
    public int Id { get; set; }

    public int? FirmaNo { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Tip { get; set; }

    public string? BelgeNo { get; set; }

    public string? Ack { get; set; }
}
