using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class AppSayim
{
    public int Id { get; set; }

    public int? BackSayimId { get; set; }

    public string? DeviceId { get; set; }

    public int? AppSayimId { get; set; }

    public int? SiraNo { get; set; }

    public DateTime? TarihSaat { get; set; }

    public string? BarkodNo { get; set; }

    public double? Miktar { get; set; }

    public string? StokTip { get; set; }

    public string? StokKod { get; set; }

    public DateTime? OlusturmaTarihSaat { get; set; }

    public string? OlusturmaUnvan { get; set; }
}
