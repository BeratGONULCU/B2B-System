using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class StokMuhTanim
{
    public int Id { get; set; }

    public int? FirmaNo { get; set; }

    public int? StkId { get; set; }

    public string? MuhOnKod { get; set; }

    public string? MuhGrsKod { get; set; }

    public string? MuhCksKod { get; set; }

    public string? MuhAlsIadeKod { get; set; }

    public string? MuhSatIadeKod { get; set; }

    public int? RemoteId { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }
}
