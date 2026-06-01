using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Markasahrk
{
    public decimal Id { get; set; }

    public double Kashrkid { get; set; }

    public double Varno { get; set; }

    public double? Marsatid { get; set; }

    public int? Firmano { get; set; }

    public string? Cartip { get; set; }

    public string? Carkod { get; set; }

    public string? Gctip { get; set; }

    public int? Sil { get; set; }

    public int? Varok { get; set; }

    public string? Islmtip { get; set; }

    public string? Islmtipad { get; set; }

    public string? Islmhrk { get; set; }

    public string? Islmhrkad { get; set; }

    public string? Yertip { get; set; }

    public string? Yerad { get; set; }

    public string? Perkod { get; set; }

    public double? Giren { get; set; }

    public double? Cikan { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public double? Kur { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public int? Dataok { get; set; }

    public string? Parabrm { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Kaskod { get; set; }

    public byte? CartipId { get; set; }

    public int? CarId { get; set; }

    public int? KasaId { get; set; }

    public int? RemoteId { get; set; }

    public bool? Transfer { get; set; }

    public DateTime? TransferTarSaat { get; set; }

    public int? TransferStartId { get; set; }

    public int? TransferStopId { get; set; }

    public DateTime? TransferDateTime { get; set; }
}
