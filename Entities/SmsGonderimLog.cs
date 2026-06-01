using System;
using System.Collections.Generic;

namespace AvmB2B.Api.Entities;

public partial class SmsGonderimLog
{
    public int Id { get; set; }

    public int? Firmano { get; set; }

    public int? EntegreTip { get; set; }

    public string? CariTip { get; set; }

    public string? CariKod { get; set; }

    public string? Aciklama { get; set; }

    public string? Cevap { get; set; }

    public bool? Gonderim { get; set; }

    public DateTime? OlusturmaTarihSaat { get; set; }

    public string? OlusturmaKullaniciUnvan { get; set; }

    public DateTime? DegistirmeTarihSaat { get; set; }

    public string? DegistirmeKullaniciUnvan { get; set; }

    public DateTime? SilTarihSaat { get; set; }

    public string? SilKullaniciUnvan { get; set; }

    public bool? Sil { get; set; }

    public int? RemoteId { get; set; }
}
