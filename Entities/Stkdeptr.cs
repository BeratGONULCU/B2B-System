using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Stkdeptr
{
    public decimal Id { get; set; }

    public double Stktrsid { get; set; }

    public string Stktip { get; set; } = null!;

    public string Stkod { get; set; } = null!;

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public int? Firmano { get; set; }

    public double? Varno { get; set; }

    public int? Varok { get; set; }

    public string? Girdepkod { get; set; }

    public string? Cikdepkod { get; set; }

    public string? Yertip { get; set; }

    public string? Yerad { get; set; }

    public double? Miktar { get; set; }

    public double? Brmfiykdvli { get; set; }

    public double? Kdvyuz { get; set; }

    public double? Otv { get; set; }

    public double? Kesafet { get; set; }

    public string? Belno { get; set; }

    public string? Ack { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public int? Dataok { get; set; }

    public string? Stktipad { get; set; }

    public double? Carpan { get; set; }

    public string? Brim { get; set; }

    public string? Girstkod { get; set; }

    public string? Girstktip { get; set; }

    public byte? Sil { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Islmtip { get; set; }

    public string? Islmtipad { get; set; }

    public double? Gircarpan { get; set; }

    public string? Girbrim { get; set; }

    public string? Sayackod { get; set; }

    public int? TrsId { get; set; }

    public string? Barkod { get; set; }

    public double? TutarKdvli { get; set; }

    public int? Gfirmano { get; set; }

    public int? Cfirmano { get; set; }
}
