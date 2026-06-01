using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class StokRecete
{
    public long Id { get; set; }

    public int? Firmano { get; set; }

    public int? UrunId { get; set; }

    public int? StkTipId { get; set; }

    public int? StkId { get; set; }

    public string? Brm { get; set; }

    public double? Miktar { get; set; }

    public int? TransferStartId { get; set; }

    public int? TransferStopId { get; set; }

    public DateTime? TransferTarihSaat { get; set; }

    public bool? Sil { get; set; }

    public byte? SyncStatus { get; set; }

    public long? RemoteId { get; set; }
}
