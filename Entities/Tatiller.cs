using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Tatiller
{
    public decimal Id { get; set; }

    public double? Firmano { get; set; }

    public DateTime? Tar { get; set; }

    public string? Ack { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }
}
