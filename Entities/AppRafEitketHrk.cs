using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class AppRafEitketHrk
{
    public int Id { get; set; }

    public int? AppRafEtiketId { get; set; }

    public string? DeviceId { get; set; }

    public int? SiraNo { get; set; }

    public DateTime? TarihSaat { get; set; }

    public string? BarkodNo { get; set; }

    public DateTime? OlusturmaTarihSaat { get; set; }

    public string? OlusturmaUnvan { get; set; }
}
