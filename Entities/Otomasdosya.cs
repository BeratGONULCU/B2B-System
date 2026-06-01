using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Otomasdosya
{
    public int Id { get; set; }

    public string? Dosya { get; set; }

    public string? Otomastip { get; set; }

    public DateTime? Tarih { get; set; }

    public bool? Aktarim { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }
}
