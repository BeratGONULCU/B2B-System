using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class TahsilatOdeme
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public int? Fatid { get; set; }

    public int? Fisid { get; set; }

    public string? Cartip { get; set; }

    public int? CartipId { get; set; }

    public string? Carkod { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public string? Belno { get; set; }

    public string? Ack { get; set; }

    public string? Islmtip { get; set; }

    public string? Islmhrk { get; set; }

    public int? KarsiCartipId { get; set; }

    public string? KarsiCartip { get; set; }

    public string? KarsiCarkod { get; set; }

    public double? Giren { get; set; }

    public double? Cikan { get; set; }

    public DateTime? Vadetar { get; set; }

    public int? Cekid { get; set; }

    public string? Gidkod { get; set; }

    public double? Gidtutar { get; set; }

    public double? Kur { get; set; }

    public string? Kesideci { get; set; }

    public string? Hesapno { get; set; }

    public string? Ceksenno { get; set; }

    public string? Parabrm { get; set; }

    public string? Yertip { get; set; }

    public string? Islmtipad { get; set; }

    public string? Islmhrkad { get; set; }

    public string? Yerad { get; set; }

    public int? Varno { get; set; }

    public int? Varok { get; set; }

    public string? Perkod { get; set; }

    public int? Adaid { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? GenelAck { get; set; }

    public string? Grp { get; set; }

    public string? GrpTip { get; set; }

    public double? Tutar { get; set; }

    public string? Bankkod { get; set; }

    public string? Drm { get; set; }

    public string? Drmad { get; set; }

    public string? Bankad { get; set; }

    public string? Banksub { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public byte? Sil { get; set; }

    public double? Ekkomyuz { get; set; }

    public double? Extrakomyuz { get; set; }

    public double? Bankomyuz { get; set; }

    public string? Krekartno { get; set; }

    public int? GidId { get; set; }

    public int? KarsiCarId { get; set; }

    public int? CarId { get; set; }

    public string? KartParaBrm { get; set; }

    public double? KartKur { get; set; }

    public string? Refno { get; set; }

    public bool? Vadeli { get; set; }

    public int? CekSeriNoId { get; set; }
}
