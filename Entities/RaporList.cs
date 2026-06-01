using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class RaporList
{
    public int Id { get; set; }

    public string? RapKod { get; set; }

    public string? Ack { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Saat { get; set; }

    public bool? Sil { get; set; }

    public int? FirmaNo { get; set; }

    public int? RemoteId { get; set; }

    public string? OlusUser { get; set; }

    public DateTime? OlusTarSaat { get; set; }
}
