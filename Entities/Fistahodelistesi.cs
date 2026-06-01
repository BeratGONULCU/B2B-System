using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Fistahodelistesi
{
    public string Grp { get; set; } = null!;

    public string Grptip { get; set; } = null!;

    public string Hrkidad { get; set; } = null!;

    public int? Fisid { get; set; }

    public double Hrkid { get; set; }

    public double? Varno { get; set; }

    public int? Varok { get; set; }

    public int? Sil { get; set; }

    public string? Yerad { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public string? Tipad { get; set; }

    public string? Hrkad { get; set; }

    public string? Islmtip { get; set; }

    public string? Islmhrk { get; set; }

    public string? Yertip { get; set; }

    public string? Belno { get; set; }

    public decimal Id { get; set; }

    public double? Tutar { get; set; }

    public double? Kur { get; set; }

    public string? Odetipkod { get; set; }

    public string? Odetipad { get; set; }

    public string? Ack { get; set; }

    public DateTime? Vadetar { get; set; }

    public string? Parabrm { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Olususer { get; set; }
}
