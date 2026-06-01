using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class AppIrsaliyeMa
{
    public int Id { get; set; }

    public string? DeviceId { get; set; }

    public int? FirmaNo { get; set; }

    public string? Seri { get; set; }

    public string? SeriNo { get; set; }

    public DateTime? TarihSaat { get; set; }

    public string? CariKod { get; set; }

    public string? DepoKod { get; set; }

    public DateTime? OlusturmaTarihSaat { get; set; }

    public string? OlusturmaUnvan { get; set; }
}
