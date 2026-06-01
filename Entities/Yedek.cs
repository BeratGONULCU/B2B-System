using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Yedek
{
    public int Id { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Dosyaad { get; set; }

    public bool? Ok { get; set; }
}
