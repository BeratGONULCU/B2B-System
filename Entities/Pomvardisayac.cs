using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Pomvardisayac
{
    public decimal Id { get; set; }

    public int? Firmano { get; set; }

    public double Varno { get; set; }

    public int? Varok { get; set; }

    public int? Sil { get; set; }

    public string? Perkod { get; set; }

    public string? Perad { get; set; }

    public string? Adad { get; set; }

    public string? Sayackod { get; set; }

    public double? Ilkendk { get; set; }

    public double? Sonendk { get; set; }

    public double? Digermik { get; set; }

    public double? Satmik { get; set; }

    public double? Testmik { get; set; }

    public double? Transfermik { get; set; }

    public decimal? Brimfiy { get; set; }

    public double? Tutar { get; set; }

    public string? Sayacad { get; set; }

    public string? Tankod { get; set; }

    public string? Transfertank { get; set; }

    public string? Stkod { get; set; }

    public int? Adaid { get; set; }

    public string? Stktip { get; set; }

    public double? Kdvyuz { get; set; }

    public string? Enktur { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Otomaskod { get; set; }

    public double? OncekiSonEndk { get; set; }

    public string? GecPerKod { get; set; }

    public int? RemoteId { get; set; }

    public int? TransferStartId { get; set; }

    public int? TransferStopId { get; set; }

    public DateTime? TransferDateTime { get; set; }
}
