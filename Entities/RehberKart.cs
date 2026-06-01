using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class RehberKart
{
    public int Id { get; set; }

    public int? FirmaNo { get; set; }

    public string? Kod { get; set; }

    public string? Unvan { get; set; }

    public string? CepNo { get; set; }

    public int? GrupId { get; set; }

    public DateTime? OlusturmaTarihSaat { get; set; }

    public string? OlusturmaKullaniciUnvan { get; set; }

    public DateTime? DegistirmeTarihSaat { get; set; }

    public string? DegistirmeKullaniciUnvan { get; set; }

    public DateTime? SilTarihSaat { get; set; }

    public string? SilKullaniciUnvan { get; set; }

    public int? RemoteId { get; set; }

    public int? TransferStartId { get; set; }

    public int? TransferStopId { get; set; }

    public bool? Sil { get; set; }

    public string? ParaBirim { get; set; }

    public string? Durum { get; set; }
}
