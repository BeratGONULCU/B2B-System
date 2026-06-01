using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Veresiyenfiyhrk
{
    public int Id { get; set; }

    public int? Masterid { get; set; }

    public int? Verid { get; set; }

    public int? Verhrkid { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public double? EskiFiyat { get; set; }

    public double? YeniFiyat { get; set; }

    public DateTime? EskiVadetar { get; set; }

    public DateTime? YeniVadetar { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Ack { get; set; }

    public string? Yertip { get; set; }

    public string? Yerad { get; set; }
}
