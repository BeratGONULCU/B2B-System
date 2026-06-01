using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Poshrk
{
    public decimal Id { get; set; }

    public double Poshrkid { get; set; }

    public string Poskod { get; set; } = null!;

    public int? Firmano { get; set; }

    public string? Bankod { get; set; }

    public int? Sil { get; set; }

    public double? Varno { get; set; }

    public int? Varok { get; set; }

    public string? Perkod { get; set; }

    public int? Adaid { get; set; }

    public string? Islmtip { get; set; }

    public string? Islmtipad { get; set; }

    public string? Islmhrk { get; set; }

    public string? Islmhrkad { get; set; }

    public string? Yertip { get; set; }

    public string? Yerad { get; set; }

    public double? Masterid { get; set; }

    public string? Gctip { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public int? Carslip { get; set; }

    public string? Cartip { get; set; }

    public string? Carkod { get; set; }

    public double? Giren { get; set; }

    public double? Cikan { get; set; }

    public double? Extrakomyuz { get; set; }

    public double? Bankomyuz { get; set; }

    public string? Ack { get; set; }

    public DateTime? Vadetar { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public int? Dataok { get; set; }

    public string? Belno { get; set; }

    public double? Kur { get; set; }

    public DateTime? Aktar { get; set; }

    public string? Aktip { get; set; }

    public DateTime? Gerialtar { get; set; }

    public double? Bagid { get; set; }

    public string? Parabrm { get; set; }

    public double? Ekkomyuz { get; set; }

    public double? Akid { get; set; }

    public int? Pro { get; set; }

    public string? Fisfattip { get; set; }

    public double? Fisfatid { get; set; }

    public double? Marsatid { get; set; }

    public string? Cartur { get; set; }

    public int? Fisid { get; set; }

    public string? Krekartno { get; set; }

    public int? Fatid { get; set; }

    public int? Tahodeid { get; set; }

    public int? PosId { get; set; }

    public int? BankId { get; set; }

    public int? CartipId { get; set; }

    public int? CarId { get; set; }

    public int? RemoteId { get; set; }

    public long? AnaId { get; set; }

    public int? BelrapId { get; set; }

    public DateTime? CarVadeTar { get; set; }

    public string? GecPerKod { get; set; }

    public bool? Devir { get; set; }

    public string? KarsiKartTip { get; set; }

    public string? KarsiKartKod { get; set; }

    public bool? PosIsle { get; set; }

    public bool? Entegre { get; set; }

    public string? EntegreTip { get; set; }

    public DateTime? EntegreAktar { get; set; }

    public int? ResSatId { get; set; }

    public bool? Transfer { get; set; }

    public DateTime? TransferTarSaat { get; set; }

    public int? TransferStartId { get; set; }

    public int? TransferStopId { get; set; }

    public DateTime? TransferDateTime { get; set; }
}
