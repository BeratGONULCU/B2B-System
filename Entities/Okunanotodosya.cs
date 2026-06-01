using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class Okunanotodosya
{
    public int? Firmano { get; set; }

    public string? Otomasad { get; set; }

    public string? Dosya { get; set; }

    public DateTime? Bastarih { get; set; }

    public DateTime? Sontarih { get; set; }

    public int? Topkayit { get; set; }

    public int? Aktarkayit { get; set; }
}
