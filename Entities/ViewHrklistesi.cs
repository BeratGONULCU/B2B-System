using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class ViewHrklistesi
{
    public string Grp { get; set; } = null!;

    public string Grptip { get; set; } = null!;

    public string Hrkidad { get; set; } = null!;

    public double? Masterid { get; set; }

    public string? Gctip { get; set; }

    public double Hrkid { get; set; }

    public double? Varno { get; set; }

    public int? Varok { get; set; }

    public int? Sil { get; set; }

    public string? Yerad { get; set; }

    public string? Perkod { get; set; }

    public int? Adaid { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public string? Tipad { get; set; }

    public string? Hrkad { get; set; }

    public string? Islmtip { get; set; }

    public string? Islmhrk { get; set; }

    public string? Yertip { get; set; }

    public string? Belno { get; set; }

    public decimal Id { get; set; }

    public string Kod { get; set; } = null!;

    public string? Carkod { get; set; }

    public string? Cartip { get; set; }

    public string? Cartur { get; set; }

    public string? Unvan { get; set; }

    public string? Perad { get; set; }

    public string? Ada { get; set; }

    public double? Giren { get; set; }

    public double? Cikan { get; set; }

    public double? Kur { get; set; }

    public string Kaskod { get; set; } = null!;

    public string? Kasad { get; set; }

    public string? Bankod { get; set; }

    public string? Bankad { get; set; }

    public string? Ack { get; set; }

    public DateTime? Vadetar { get; set; }

    public string? Parabrm { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Olususer { get; set; }
}
