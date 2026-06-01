using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class BulutTahsilat
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public int? TahsilatId { get; set; }

    public int? TahsilatTipId { get; set; }

    public string? TahsilatTipAd { get; set; }

    public int? EntegratorId { get; set; }

    public DateTime? TarihSaat { get; set; }

    public string? BankKod { get; set; }

    public string? BankAd { get; set; }

    public string? BankIban { get; set; }

    public string? Tcvknno { get; set; }

    public string? Unvan { get; set; }

    public double? Tutar { get; set; }

    public string? Aciklama { get; set; }

    public bool? Sil { get; set; }

    public DateTime? KayitTarihSaat { get; set; }

    public int? CariTipId { get; set; }

    public int? CariId { get; set; }

    public int? BankaId { get; set; }

    public int? AktarimId { get; set; }

    public DateTime? AktarimTarihSaat { get; set; }
}
