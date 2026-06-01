using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Pomvardima
{
    public decimal Id { get; set; }

    public double Varno { get; set; }

    public int? Varok { get; set; }

    public int? Firmano { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public string? Varad { get; set; }

    public int? Dataok { get; set; }

    public int? Sil { get; set; }

    public int? Adabag { get; set; }

    public double? Aksatmik { get; set; }

    public double? Aksattop { get; set; }

    public double? Naktestop { get; set; }

    public double? Postop { get; set; }

    public double? Veresitop { get; set; }

    public double? Malsattop { get; set; }

    public double? Gelirtop { get; set; }

    public double? Gidertop { get; set; }

    public double? Tahtop { get; set; }

    public double? Odetop { get; set; }

    public DateTime? Kaptar { get; set; }

    public string? Kapsaat { get; set; }

    public int? Otocheck { get; set; }

    public double? Otomastop { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Varackfaztip { get; set; }

    public double? Poscartop { get; set; }

    public double? Cektop { get; set; }

    public double? Bankatop { get; set; }

    public int? RemoteId { get; set; }

    public double? Veresimik { get; set; }

    public double? Otomasmik { get; set; }

    public bool? Admin { get; set; }

    public DateTime? EntegreAktar { get; set; }

    public string? EntegreTip { get; set; }

    public bool? Entegre { get; set; }

    public int? TransferStartId { get; set; }

    public int? TransferStopId { get; set; }

    public DateTime? TransferDateTime { get; set; }

    public string? EntegreBelgeNo { get; set; }

    public int? AracSayi { get; set; }
}
