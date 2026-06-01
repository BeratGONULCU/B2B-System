using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class BanknotHrk
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public int? HrkId { get; set; }

    public int? Varno { get; set; }

    public int? Varok { get; set; }

    public int? Sil { get; set; }

    public int? Tip { get; set; }

    public int? Adet { get; set; }

    public double? Deger { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public string? Yertip { get; set; }

    public string? Yerad { get; set; }

    public string? Deguser { get; set; }

    public DateTime? Degtarsaat { get; set; }
}
