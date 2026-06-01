using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class KasaKapat
{
    public int Id { get; set; }

    public int Firmano { get; set; }

    public string Kaskod { get; set; } = null!;

    public DateTime Tarih { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public byte? Drm { get; set; }

    public bool? Sil { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public int? KasaId { get; set; }
}
