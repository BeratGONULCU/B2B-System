using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Faturahrklistesi
{
    public decimal Id { get; set; }

    public double? Fatid { get; set; }

    public string Satirtip { get; set; } = null!;

    public double? Sil { get; set; }

    public int? Firmano { get; set; }

    public string? Stktip { get; set; }

    public string? Stkod { get; set; }

    public double? Mik { get; set; }

    public int MicroStktip { get; set; }

    public double? Brmfiy { get; set; }

    public string? Depkod { get; set; }

    public double? Kdvyuz { get; set; }

    public double? Kdvtut { get; set; }

    public double KdvtevkifatYuzde { get; set; }

    public double KdvtevkifatTutar { get; set; }

    public string KdvtevkifatKod { get; set; } = null!;

    public string KdvtevkifatAck { get; set; } = null!;

    public string? Kdvtip { get; set; }

    public string? Brim { get; set; }

    public double? Satiskyuz { get; set; }

    public double? Satisktut { get; set; }

    public double? AkIskYuz { get; set; }

    public double? AkIskTut { get; set; }

    public double? MrIskYuz { get; set; }

    public double? MrIskTut { get; set; }

    public double? Otvyuz { get; set; }

    public double? Otvtut { get; set; }

    public double? OtvCarpan { get; set; }

    public double? Geniskyuz { get; set; }

    public double? Genisktut { get; set; }

    public string? Ustbrim { get; set; }

    public double? Carpan { get; set; }

    public string? Parabrim { get; set; }

    public double? Otvbrim { get; set; }

    public int? Grupid { get; set; }

    public int? Kayok { get; set; }

    public double? Kaphrkid { get; set; }

    public string? Kaptip { get; set; }

    public double? Giderbrmtut { get; set; }

    public double? TopIskYuz { get; set; }

    public double? TopIskTut { get; set; }
}
