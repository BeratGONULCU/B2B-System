using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Marsatma
{
    public decimal Id { get; set; }

    public double Marsatid { get; set; }

    public int? Firmano { get; set; }

    public double Varno { get; set; }

    public int? Varok { get; set; }

    public int? Kayok { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public string? Islmtip { get; set; }

    public string? Islmtipad { get; set; }

    public string? Yertip { get; set; }

    public string? Yerad { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public int? Sil { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public int? Dataok { get; set; }

    public double? Naktop { get; set; }

    public double? Postop { get; set; }

    public double? Veresitop { get; set; }

    public double? Iadetop { get; set; }

    public double? Indtop { get; set; }

    public double? Yuvtop { get; set; }

    public string? Parabrm { get; set; }

    public double? Kur { get; set; }

    public double? Satistop { get; set; }

    public double? Gidertop { get; set; }

    public string? Cartip { get; set; }

    public string? Carkod { get; set; }

    public string? Islmhrk { get; set; }

    public string? Islmhrkad { get; set; }

    public int? CartipId { get; set; }

    public int? CarId { get; set; }

    public int? RemoteId { get; set; }

    public int? YazarKasaId { get; set; }

    public int? Verid { get; set; }

    public int? Fatid { get; set; }

    public string? FisNo { get; set; }

    public bool? Transfer { get; set; }

    public DateTime? TransferTarSaat { get; set; }

    public int? TransferStartId { get; set; }

    public int? TransferStopId { get; set; }

    public DateTime? TransferDateTime { get; set; }

    public int? RehberBarkodId { get; set; }

    public int? RehberId { get; set; }

    public int? RehberGrupId { get; set; }

    public int? YazarKasaIslemId { get; set; }

    public bool? FisYazdirildi { get; set; }

    public int? Zno { get; set; }

    public bool? Cikis { get; set; }

    public string? YazarKasaBankaTerminalNo { get; set; }
}
