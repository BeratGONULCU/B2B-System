using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class ResSatRecHrk
{
    public long Id { get; set; }

    public long? ResSatId { get; set; }

    public long? ResSatHrkId { get; set; }

    public int? StokReceteId { get; set; }

    /// <summary>
    /// 1=Recete
    /// 2=Urun
    /// </summary>
    public byte? UretimTipId { get; set; }

    public int? UrunId { get; set; }

    public int? StokTipId { get; set; }

    public string? StokTip { get; set; }

    public int? StokId { get; set; }

    public string? StokKod { get; set; }

    public string? Brm { get; set; }

    public double? Miktar { get; set; }

    public double? BirimFiyat { get; set; }

    public double? BirimMaliyetFiyat { get; set; }

    public bool? Sil { get; set; }

    public long? RemoteId { get; set; }

    public string? OlusturmaKullaniciUnvan { get; set; }

    public DateTime? OlusturmaTarihSaat { get; set; }

    public int? TransferStartId { get; set; }

    public int? TransferStopId { get; set; }

    public DateTime? TransferTarihSaat { get; set; }
}
