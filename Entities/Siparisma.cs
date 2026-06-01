using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Siparisma
{
    public decimal Id { get; set; }

    public double Sipid { get; set; }

    public int? Firmano { get; set; }

    public int? Sil { get; set; }

    public int? Kayok { get; set; }

    public string? Sipad { get; set; }

    public string? Siptip { get; set; }

    public string? Siptur { get; set; }

    public string? Sipturad { get; set; }

    public string? Sipseri { get; set; }

    public string? Sipno { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Vadtar { get; set; }

    public string? Kdvtip { get; set; }

    public string? Ack { get; set; }

    public double? Kdvtut { get; set; }

    public string? Depo { get; set; }

    public int? Dataok { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public double? Siptop { get; set; }

    public double? Kdvtop { get; set; }

    public string? Cartip { get; set; }

    public string? Carkod { get; set; }

    public string? Saat { get; set; }

    public string? Aktip { get; set; }

    public double? Kaltop { get; set; }

    public string? Irtip { get; set; }

    public int? Durum { get; set; }

    public string? DurumAck { get; set; }
}
