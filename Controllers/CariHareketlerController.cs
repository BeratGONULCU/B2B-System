using AvmB2B.Api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace AvmB2B.Api.Controllers;

[ApiController]
[Authorize]
[Route("api/cari-hareketler")]
public class CariHareketlerController : ControllerBase
{
    private readonly PetrolDbContext _context;

    public CariHareketlerController(PetrolDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetCariHareketler(
        [FromQuery] string? carkod,
        [FromQuery] DateTime? baslangicTarihi,
        [FromQuery] DateTime? bitisTarihi,
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 50)
    {
        if (page < 1) page = 1;
        if (pageSize < 1) pageSize = 50;
        if (pageSize > 500) pageSize = 500;

        var userType = User.FindFirst("userType")?.Value;
        var tokenCariKod = User.FindFirst("cariKod")?.Value;

        var query =
            from h in _context.Carihrks.AsNoTracking()
            join c in _context.Carikarts.AsNoTracking()
                on h.Carkod equals c.Kod
            where h.Sil == 0 && c.Sil == 0
            select new
            {
                HareketId = h.Id,
                h.Carhrkid,
                h.Firmano,

                CariKod = h.Carkod,
                CariUnvan = c.Unvan,
                CariAd = c.Ad,
                CariSoyad = c.Soyad,
                CariTelefon = c.Tel,
                CariCep = c.Cep,
                CariMail = c.Mail,

                h.Gctip,
                h.Islmtip,
                h.Islmtipad,
                h.Islmhrk,
                h.Islmhrkad,

                Borc = h.Borc ?? 0,
                Alacak = h.Alacak ?? 0,

                // Eğer carihrk.bakiye doluysa onu kullanır.
                // Boşsa en azından borç - alacak üzerinden hesaplar.
                Bakiye = h.Bakiye ?? ((h.Borc ?? 0) - (h.Alacak ?? 0)),

                ParaBirimi = h.Parabrm,

                h.Tarih,
                h.Saat,
                VadeTarihi = h.Vadetar,
                BelgeNo = h.Belno,
                Aciklama = h.Ack,

                h.Plaka,
                h.Surucu,
                KartSahibi = h.Surucu,

                h.CarId,
                h.Cartip,
                h.CartipId
            };

        if (userType == "Cari")
        {
            if (string.IsNullOrWhiteSpace(tokenCariKod))
                return Forbid();

            query = query.Where(x => x.CariKod == tokenCariKod);
        }
        else if (userType == "Admin")
        {
            if (!string.IsNullOrWhiteSpace(carkod))
                query = query.Where(x => x.CariKod == carkod);
        }
        else
        {
            return Forbid();
        }

        if (baslangicTarihi.HasValue)
        {
            query = query.Where(x => x.Tarih >= baslangicTarihi.Value);
        }

        if (bitisTarihi.HasValue)
        {
            query = query.Where(x => x.Tarih <= bitisTarihi.Value);
        }

        var totalCount = await query.CountAsync();
        var totalPages = totalCount == 0 ? 1 : (int)Math.Ceiling(totalCount / (double)pageSize);

        var orderedRows = await query
    .OrderBy(x => x.Tarih)
    .ThenBy(x => x.HareketId)
    .ToListAsync();

        double runningBalance = 0;

        var rowsWithBalance = orderedRows
            .Select(x =>
            {
                runningBalance += x.Borc - x.Alacak;

                return new
                {
                    x.HareketId,
                    x.Carhrkid,
                    x.Firmano,

                    x.CariKod,
                    x.CariUnvan,
                    x.CariAd,
                    x.CariSoyad,
                    x.CariTelefon,
                    x.CariCep,
                    x.CariMail,

                    x.Gctip,
                    x.Islmtip,
                    x.Islmtipad,
                    x.Islmhrk,
                    x.Islmhrkad,

                    x.Borc,
                    x.Alacak,

                    // Her satırdaki işlem sonrası bakiye
                    Bakiye = runningBalance,

                    x.ParaBirimi,

                    x.Tarih,
                    x.Saat,
                    x.VadeTarihi,
                    x.BelgeNo,
                    x.Aciklama,

                    x.Plaka,
                    x.Surucu,
                    x.KartSahibi,

                    x.CarId,
                    x.Cartip,
                    x.CartipId
                };
            })
            .Reverse()
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        return Ok(new
        {
            page,
            pageSize,
            totalCount,
            totalPages,
            items = rowsWithBalance,
            data = rowsWithBalance
        });
    }

    [HttpGet("{carkod}")]
    public async Task<IActionResult> GetByCariKod(
        string carkod,
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 50)
    {
        if (page < 1) page = 1;
        if (pageSize < 1) pageSize = 50;
        if (pageSize > 500) pageSize = 500;

        var userType = User.FindFirst("userType")?.Value;
        var tokenCariKod = User.FindFirst("cariKod")?.Value;

        if (userType == "Cari")
        {
            if (string.IsNullOrWhiteSpace(tokenCariKod))
                return Forbid();

            if (!string.Equals(tokenCariKod, carkod, StringComparison.OrdinalIgnoreCase))
                return Forbid();
        }
        else if (userType != "Admin")
        {
            return Forbid();
        }

        var query =
            from h in _context.Carihrks.AsNoTracking()
            join c in _context.Carikarts.AsNoTracking()
                on h.Carkod equals c.Kod
            where h.Sil == 0
                  && c.Sil == 0
                  && h.Carkod == carkod
            select new
            {
                HareketId = h.Id,
                h.Carhrkid,
                h.Firmano,

                CariKod = h.Carkod,
                CariUnvan = c.Unvan,
                CariAd = c.Ad,
                CariSoyad = c.Soyad,
                CariTelefon = c.Tel,
                CariCep = c.Cep,
                CariMail = c.Mail,

                h.Gctip,
                h.Islmtip,
                h.Islmtipad,
                h.Islmhrk,
                h.Islmhrkad,

                Borc = h.Borc ?? 0,
                Alacak = h.Alacak ?? 0,

                // Dashboard'daki mantığa yakın güvenli fallback.
                Bakiye = h.Bakiye ?? ((h.Borc ?? 0) - (h.Alacak ?? 0)),

                ParaBirimi = h.Parabrm,

                h.Tarih,
                h.Saat,
                VadeTarihi = h.Vadetar,
                BelgeNo = h.Belno,
                Aciklama = h.Ack,

                h.Plaka,
                h.Surucu,
                KartSahibi = h.Surucu,

                h.CarId,
                h.Cartip,
                h.CartipId
            };

        var totalCount = await query.CountAsync();
        var totalPages = totalCount == 0 ? 1 : (int)Math.Ceiling(totalCount / (double)pageSize);

        var orderedRows = await query
    .OrderBy(x => x.Tarih)
    .ThenBy(x => x.HareketId)
    .ToListAsync();

        double runningBalance = 0;

        var rowsWithBalance = orderedRows
            .Select(x =>
            {
                runningBalance += x.Borc - x.Alacak;

                return new
                {
                    x.HareketId,
                    x.Carhrkid,
                    x.Firmano,

                    x.CariKod,
                    x.CariUnvan,
                    x.CariAd,
                    x.CariSoyad,
                    x.CariTelefon,
                    x.CariCep,
                    x.CariMail,

                    x.Gctip,
                    x.Islmtip,
                    x.Islmtipad,
                    x.Islmhrk,
                    x.Islmhrkad,

                    x.Borc,
                    x.Alacak,

                    // Her satırdaki işlem sonrası bakiye
                    Bakiye = runningBalance,

                    x.ParaBirimi,

                    x.Tarih,
                    x.Saat,
                    x.VadeTarihi,
                    x.BelgeNo,
                    x.Aciklama,

                    x.Plaka,
                    x.Surucu,
                    x.KartSahibi,

                    x.CarId,
                    x.Cartip,
                    x.CartipId
                };
            })
            .Reverse()
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        return Ok(new
        {
            page,
            pageSize,
            totalCount,
            totalPages,
            items = rowsWithBalance,
            data = rowsWithBalance
        });
    }

    [HttpGet("ozet")]
    public async Task<IActionResult> Ozet([FromQuery] string? carkod)
    {
        var userType = User.FindFirst("userType")?.Value;
        var tokenCariKod = User.FindFirst("cariKod")?.Value;

        string? hedefCariKod;

        if (userType == "Cari")
        {
            if (string.IsNullOrWhiteSpace(tokenCariKod))
                return Forbid();

            hedefCariKod = tokenCariKod;
        }
        else if (userType == "Admin")
        {
            hedefCariKod = carkod;

            if (string.IsNullOrWhiteSpace(hedefCariKod))
            {
                return BadRequest(new
                {
                    message = "Admin için carkod parametresi zorunludur."
                });
            }
        }
        else
        {
            return Forbid();
        }

        var result = await _context.CariKartListesiOzetleri
            .AsNoTracking()
            .Where(x => x.Kod == hedefCariKod && (x.Sil == null || x.Sil == 0))
            .Select(x => new
            {
                cariKod = x.Kod,
                cariUnvan = x.Unvan,

                toplamBorc = x.BrcBakiye ?? 0,
                toplamAlacak = x.AlcBakiye ?? 0,

                // Ana bakiye buradan gelecek.
                bakiye = x.CarBakiye ?? x.TopBakiye ?? 0,

                brcTopBakiye = x.BrcTopBakiye ?? 0,
                alcTopBakiye = x.AlcTopBakiye ?? 0,
                topBakiye = x.TopBakiye ?? 0,

                sonHareketTarihi = x.SonHareketTarihi
            })
            .FirstOrDefaultAsync();

        if (result == null)
        {
            return Ok(new
            {
                cariKod = hedefCariKod,
                cariUnvan = "",
                toplamBorc = 0m,
                toplamAlacak = 0m,
                bakiye = 0m,
                brcTopBakiye = 0m,
                alcTopBakiye = 0m,
                topBakiye = 0m,
                sonHareketTarihi = (DateTime?)null
            });
        }

        return Ok(result);
    }
}