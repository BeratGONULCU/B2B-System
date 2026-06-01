using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Sayachrk
{
    public decimal Id { get; set; }

    public double Sayachrkid { get; set; }

    public string Sayackod { get; set; } = null!;

    public int? Firmano { get; set; }

    public double? Varno { get; set; }

    public int? Varok { get; set; }

    public int? Sil { get; set; }

    public string? Islmtip { get; set; }

    public string? Islmtipad { get; set; }

    public double? Ilkendks { get; set; }

    public double? Sonendks { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public int? Dataok { get; set; }

    public string? Ack { get; set; }

    public string? Yertip { get; set; }

    public string? Yerad { get; set; }

    public double? Islmid { get; set; }

    public string? Belno { get; set; }

    public double? Ilkmekendks { get; set; }

    public double? Sonmekendks { get; set; }

    public int? SayacId { get; set; }
}
