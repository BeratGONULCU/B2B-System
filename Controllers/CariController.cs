using AvmB2B.Api.Data;
using AvmB2B.Api.DTOs.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AvmB2B.Api.Controllers;

[ApiController]
[Authorize]
[Route("api/cari")]
public class CariController : ControllerBase
{
    private readonly PetrolDbContext _context;

    public CariController(PetrolDbContext context)
    {
        _context = context;
    }

    [HttpGet("profil")]
    public async Task<IActionResult> Profil()
    {
        var userType = User.FindFirst("userType")?.Value;
        var tokenCariKod = User.FindFirst("cariKod")?.Value;

        if (userType != "Cari")
            return Forbid();

        if (string.IsNullOrWhiteSpace(tokenCariKod))
            return Forbid();

        var cariKod = tokenCariKod.Trim();

        var cari = await _context.CariKartListesis
            .AsNoTracking()
            .Where(x => x.Kod == cariKod && x.Sil == 0)
            .Select(x => new
            {
                Id = x.Id,
                CariKod = x.Kod,
                Unvan = x.Unvan,
                Ad = x.Ad,
                Soyad = x.Soyad,
                Tel = x.Tel,
                Cep = x.Cep,
                Mail = x.Mail,
                Adres = x.Adres,
                Evil = x.Evil,
                Evilce = x.Evilce,
                Vergidaire = x.Vergidaire,
                Vergino = x.Vergino,

                // Cari_Kart_Listesi tarafındaki güncel bakiye alanları
                Carbak = x.CarBakiye,
                Fisbak = x.FisBakiye,
                TopBakiye = x.TopBakiye,
                BorcBakiye = x.BrcBakiye,
                AlacakBakiye = x.AlcBakiye,

                RiskLimit = x.RiskLimit,
                Toplamlimit = x.Toplamlimit,
                Toplamteminat = x.Toplamteminat,
                Parabrm = x.Parabrm,
                SonHareketTarihi = x.SonhrkTarih
            })
            .FirstOrDefaultAsync();

        if (cari == null)
            return NotFound("Cari bulunamadı.");

        return Ok(cari);
    }

    /*
    [HttpPut("update-profile")]
    public async Task<IActionResult> UpdateProfil([FromBody] UpdateProfil request)
    {
    }
    */
}