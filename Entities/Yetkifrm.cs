using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Yetkifrm
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public int? Yetkiid { get; set; }

    public int? Bolumid { get; set; }

    public int? Frmid { get; set; }

    public int? Havuz { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Modul { get; set; }
}
