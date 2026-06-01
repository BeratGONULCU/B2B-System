using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class MailAck
{
    public int Id { get; set; }

    public string? Ad { get; set; }

    public string? Ack { get; set; }

    public bool? Sil { get; set; }
}
