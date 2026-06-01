using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class PdaOffSayimMa
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public string? Ack { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Drm { get; set; }

    public double? StkTopMik { get; set; }

    public double? Aktarid { get; set; }

    public DateTime? Aktartarsaat { get; set; }

    public string? Aktaruser { get; set; }
}
