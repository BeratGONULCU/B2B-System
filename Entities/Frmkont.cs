using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Frmkont
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public int? Bolumid { get; set; }

    public int? Frmid { get; set; }

    public string? Kont { get; set; }

    public string? Konttr { get; set; }

    public string? Konten { get; set; }

    public bool? Yetkialan { get; set; }

    public int? Sfirmano { get; set; }

    public bool? Havuz { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public int? Anafrmid { get; set; }

    public int? FatFisKontId { get; set; }

    public string? Modul { get; set; }

    public string? KontMenu { get; set; }

    public int? RapId { get; set; }
}
