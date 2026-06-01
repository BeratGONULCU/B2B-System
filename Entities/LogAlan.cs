using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class LogAlan
{
    public string? Tablo { get; set; }

    public string? Alan { get; set; }

    public int? Sfirmano { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }
}
