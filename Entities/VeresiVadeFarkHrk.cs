using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class VeresiVadeFarkHrk
{
    public int Id { get; set; }

    public int? CarTip { get; set; }

    public int? CarId { get; set; }

    public DateTime? Tarih { get; set; }

    public double? VadeOran { get; set; }

    public double? Borc { get; set; }

    public double? Alacak { get; set; }

    public double? VadeFark { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }
}
