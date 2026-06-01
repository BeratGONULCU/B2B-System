using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Otomaskart
{
    public decimal Id { get; set; }

    public int? Firmano { get; set; }

    public string Otmaskod { get; set; } = null!;

    public string? Klasor { get; set; }

    public int? Bassatir { get; set; }

    public string? Dosuznti { get; set; }

    public string? Tarformat { get; set; }

    public string? Dostan { get; set; }

    public double? Sonid { get; set; }

    public string? Otomascari { get; set; }

    public string? Otomasper { get; set; }

    public string? Otomascartip { get; set; }

    public string? Otofiload { get; set; }

    public double? Basid { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustar { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Host { get; set; }

    public string? Beg { get; set; }

    public string? Users { get; set; }

    public string? Pass { get; set; }

    public bool? Sil { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? SubeKod { get; set; }

    public byte? SaleTag { get; set; }

    public bool? KartanPlaka { get; set; }

    public string? TtsKey { get; set; }

    public bool? OtomasPartner { get; set; }

    public string? OtomasPartnercari { get; set; }

    public bool? CariFisNakitCevir { get; set; }

    public bool? OtomasGift { get; set; }

    public string? OtomasGiftcari { get; set; }

    public string? Ttsseri { get; set; }
}
