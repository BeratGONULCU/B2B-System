using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class GenelKart
{
    public decimal Id { get; set; }

    public double? Firmano { get; set; }

    public int? Sl { get; set; }

    public string? Kod { get; set; }

    public string? Ad { get; set; }

    public int? Grp1 { get; set; }

    public int? Grp2 { get; set; }

    public int? Grp3 { get; set; }

    public int? PromGrp1 { get; set; }

    public string? Fatunvan { get; set; }

    public string Cartp { get; set; } = null!;

    public int TipId { get; set; }

    public int? PerId { get; set; }

    public string? Muhkod { get; set; }

    public string? Muhonkod { get; set; }

    public int Crno { get; set; }

    public string? Tcno { get; set; }

    public string? Tel { get; set; }

    public string? Fax { get; set; }

    public string? Cep { get; set; }

    public string? Mail { get; set; }

    public string? VergiKno { get; set; }

    public string? VergiEposta { get; set; }

    public int? Efatura { get; set; }

    public int? EfaturaTip { get; set; }

    public string? TicSicilNo { get; set; }

    public string? Webadres { get; set; }

    public string? Grupad1 { get; set; }

    public string? Tip { get; set; }

    public int? TurId { get; set; }

    public string? Adres { get; set; }

    public string? Adres2 { get; set; }

    public string? Evil { get; set; }

    public string? Evilce { get; set; }

    public string? Vergidaire { get; set; }

    public string? Vergino { get; set; }

    public double? FisIskonto { get; set; }

    public double? FatIskonto { get; set; }

    public int? OtoFisVadeFark { get; set; }

    public string? BankaKod { get; set; }

    public string? BankaDbs { get; set; }

    public string? BankaAd { get; set; }
}
