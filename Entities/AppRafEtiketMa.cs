using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class AppRafEtiketMa
{
    public int Id { get; set; }

    public string? DeviceId { get; set; }

    public int? FirmaNo { get; set; }

    public DateTime? TarihSaat { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? OlusturmaTarihSaat { get; set; }

    public string? OlusturmaUnvan { get; set; }
}
