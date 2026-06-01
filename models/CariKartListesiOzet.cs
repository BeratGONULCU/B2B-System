using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AvmB2B.Api.Models;

[Keyless]
public class CariKartListesiOzet
{
    [Column("kod")]
    public string Kod { get; set; } = "";

    [Column("unvan")]
    public string? Unvan { get; set; }

    [Column("sil")]
    public int? Sil { get; set; }

    [Column("brc_bakiye")]
    public decimal? BrcBakiye { get; set; }

    [Column("alc_bakiye")]
    public decimal? AlcBakiye { get; set; }

    [Column("brc_top_bakiye")]
    public decimal? BrcTopBakiye { get; set; }

    [Column("alc_top_bakiye")]
    public decimal? AlcTopBakiye { get; set; }

    [Column("car_bakiye")]
    public decimal? CarBakiye { get; set; }

    [Column("top_bakiye")]
    public decimal? TopBakiye { get; set; }

    [Column("sonhrk_tarih")]
    public DateTime? SonHareketTarihi { get; set; }
}