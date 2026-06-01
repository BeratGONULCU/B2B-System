using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class OtoOnlParam
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public int? Tip { get; set; }

    public string? Sure { get; set; }

    public int? Satir { get; set; }

    public int? Sonsatirno { get; set; }

    public string? Sondosya { get; set; }

    public DateTime? Sontarih { get; set; }

    public string? Olususer { get; set; }

    public DateTime? Olustarsaat { get; set; }

    public bool? YenileCh { get; set; }

    public string? YenileSure { get; set; }

    public string? Otomasad { get; set; }

    public bool? ChGecmis { get; set; }

    public byte? FilterTip { get; set; }

    public bool? OtoFis { get; set; }

    public int? PrintFisSayi { get; set; }
}
