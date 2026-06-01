using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Frm
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public int? Bolumid { get; set; }

    public string? Frm1 { get; set; }

    public string? Frmtr { get; set; }

    public string? Frmen { get; set; }

    public bool? Yetkialan { get; set; }

    public int? Sfirmano { get; set; }

    public bool? Havuz { get; set; }

    public string? Anaformnesne { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Modul { get; set; }
}
