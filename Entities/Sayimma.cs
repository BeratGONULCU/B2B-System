using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Sayimma
{
    public decimal Id { get; set; }

    public double Sayid { get; set; }

    public int Sil { get; set; }

    public int? Firmano { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public string? Sayack { get; set; }

    public string? Drm { get; set; }

    public string? Depkod { get; set; }

    public string? Perkod { get; set; }

    public DateTime? Onaytarih { get; set; }

    public string? Onaysaat { get; set; }

    public double? Sayimmik { get; set; }

    public double? Mevcutmik { get; set; }

    public double? Mevcuttut { get; set; }

    public double? Sayimtut { get; set; }

    public string? Onayack { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Deguser { get; set; }

    public string? Kdvtip { get; set; }

    public string? Brmfiytip { get; set; }

    public int? Dataok { get; set; }

    public string? Onayper { get; set; }

    public string? Yertip { get; set; }

    public string? Yerad { get; set; }
}
