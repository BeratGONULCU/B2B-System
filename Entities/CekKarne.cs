using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class CekKarne
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public int? BankId { get; set; }

    public string? BankKod { get; set; }

    public string? CekSeriNo { get; set; }

    public int? Drm { get; set; }

    public bool? Sil { get; set; }
}
