using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class TarihKapat
{
    public int Id { get; set; }

    public int? FirmaNo { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public byte? Drm { get; set; }

    public byte? Sil { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }
}
