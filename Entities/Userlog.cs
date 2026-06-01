using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Userlog
{
    public int Id { get; set; }

    public DateTime Tarih { get; set; }

    public double? Firmano { get; set; }

    public string? Usr { get; set; }

    public double Kayitid { get; set; }

    public string? Ack { get; set; }

    public string? Ip { get; set; }

    public string? Pcadi { get; set; }

    public string? Islem { get; set; }

    public string? Tablo { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }
}
