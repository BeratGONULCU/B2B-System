using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Stokfiyathistory
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public string? Kaytip { get; set; }

    public string Kod { get; set; } = null!;

    public string? Tip { get; set; }

    public double? Sat1fiy { get; set; }

    public double? Sat1kdv { get; set; }

    public string? Sat1kdvtip { get; set; }

    public string? Sat1pbrm { get; set; }

    public double? Sat2fiy { get; set; }

    public double? Sat2kdv { get; set; }

    public string? Sat2kdvtip { get; set; }

    public string? Sat2pbrm { get; set; }

    public double? Sat3fiy { get; set; }

    public double? Sat3kdv { get; set; }

    public string? Sat3kdvtip { get; set; }

    public string? Sat3pbrm { get; set; }

    public double? Sat4fiy { get; set; }

    public double? Sat4kdv { get; set; }

    public string? Sat4kdvtip { get; set; }

    public string? Sat4pbrm { get; set; }

    public double? Alsfiy { get; set; }

    public double? Alskdv { get; set; }

    public string? Alskdvtip { get; set; }

    public string? Alspbrm { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }
}
