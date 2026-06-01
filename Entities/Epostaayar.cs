using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Epostaayar
{
    public int Id { get; set; }

    public string? Gonad { get; set; }

    public string? Gonposta { get; set; }

    public string? Host { get; set; }

    public string? Kulkod { get; set; }

    public string? Sif { get; set; }

    public string? Alad { get; set; }

    public string? Alposta { get; set; }

    public string? SmsSunucu { get; set; }

    public string? SmsFirmaKod { get; set; }

    public string? SmsKulKod { get; set; }

    public string? SmsSifre { get; set; }

    public string? SmsAliciCepno { get; set; }

    public int? SmsTip { get; set; }

    public int? PostaGidenPort { get; set; }

    public int? PostaSifreleme { get; set; }
}
