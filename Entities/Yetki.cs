using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Yetki
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public string? Ad { get; set; }

    public bool? Sysyetki { get; set; }

    public bool? Sil { get; set; }

    public bool? Havuz { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Modul { get; set; }
}
