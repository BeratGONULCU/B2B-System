using System.Globalization;
using AvmB2B.Api.Data;
using AvmB2B.Api.DTOs.Auth;
using AvmB2B.Api.Entities;
using AvmB2B.Api.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace AvmB2B.Api.Controllers;

[ApiController]
[Authorize]
[Route("api/admin/users")]
public class AdminUsersController : ControllerBase
{
    private readonly PetrolDbContext _context;

    public AdminUsersController(PetrolDbContext context)
    {
        _context = context;
    }

    private bool IsAdmin()
    {
        return User.FindFirst("userType")?.Value == "Admin";
    }

    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
        if (!IsAdmin())
            return Forbid();

        var users = await _context.B2BUsers
            .AsNoTracking()
            .OrderByDescending(x => x.Id)
            .Select(x => new
            {
                x.Id,
                x.UserType,
                x.Username,
                x.CariKod,
                x.IsActive,
                x.MustChangePassword,
                x.CreatedAt
            })
            .ToListAsync();

        return Ok(users);
    }

    [HttpPut("{id:int}/passive")]
    public async Task<IActionResult> PassiveUser(int id)
    {
        if (!IsAdmin())
            return Forbid();

        var user = await _context.B2BUsers.FirstOrDefaultAsync(x => x.Id == id);

        if (user == null)
            return NotFound("Kullanıcı bulunamadı.");

        user.IsActive = false;
        await _context.SaveChangesAsync();

        return Ok(new { message = "Kullanıcı pasifleştirildi." });
    }

    [HttpPut("{id:int}/active")]
    public async Task<IActionResult> ActiveUser(int id)
    {
        if (!IsAdmin())
            return Forbid();

        var user = await _context.B2BUsers.FirstOrDefaultAsync(x => x.Id == id);

        if (user == null)
            return NotFound("Kullanıcı bulunamadı.");

        if (!string.IsNullOrWhiteSpace(user.CariKod))
        {
            var existingActiveUserForCari = await _context.B2BUsers
                .AsNoTracking()
                .FirstOrDefaultAsync(x =>
                    x.Id != user.Id &&
                    x.CariKod == user.CariKod &&
                    x.IsActive);

            if (existingActiveUserForCari != null)
            {
                return Conflict(new
                {
                    message = $"Bu cari için zaten aktif kullanıcı var. Kullanıcı: {existingActiveUserForCari.Username}, Tip: {existingActiveUserForCari.UserType}",
                    username = existingActiveUserForCari.Username,
                    userType = existingActiveUserForCari.UserType,
                    cariKod = existingActiveUserForCari.CariKod
                });
            }
        }

        user.IsActive = true;
        await _context.SaveChangesAsync();

        return Ok(new { message = "Kullanıcı aktifleştirildi." });
    }

    [HttpPut("{id:int}/reset-password")]
    public async Task<IActionResult> ResetPassword(int id)
    {
        if (!IsAdmin())
            return Forbid();

        var user = await _context.B2BUsers.FirstOrDefaultAsync(x => x.Id == id);

        if (user == null)
            return NotFound("Kullanıcı bulunamadı.");

        if (string.IsNullOrWhiteSpace(user.CariKod))
            return BadRequest("Bu kullanıcı için cari kod yok.");

        var cari = await _context.CariKartListesis
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Kod == user.CariKod && x.Sil == 0);

        if (cari == null)
            return NotFound("Cari kart bulunamadı.");

        var newPassword = B2BCredentialGenerator.GeneratePassword(
            cari.Unvan,
            cari.Ad,
            cari.Soyad,
            cari.Kod
        );

        user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(newPassword, workFactor: 12);
        user.MustChangePassword = true;

        await _context.SaveChangesAsync();

        return Ok(new
        {
            message = "Şifre sıfırlandı.",
            username = user.Username,
            password = newPassword
        });
    }

    [HttpPost("create-admin")]
    public async Task<IActionResult> CreateAdmin([FromBody] CreateAdminRequest request)
    {
        if (!IsAdmin())
            return Forbid();

        if (string.IsNullOrWhiteSpace(request.Username))
            return BadRequest("Kullanıcı adı boş olamaz.");

        if (string.IsNullOrWhiteSpace(request.Password))
            return BadRequest("Şifre boş olamaz.");

        var username = request.Username.Trim();

        var usernameCandidates = BuildLoginUsernameCandidates(username);

        var exists = await UsernameExistsAsync(usernameCandidates);

        if (exists)
            return Conflict("Bu kullanıcı adı zaten var.");

        var admin = new B2BUser
        {
            UserType = "Admin",
            Username = username,
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password, workFactor: 12),
            CariKod = null,
            IsActive = true,
            MustChangePassword = false,
            CreatedAt = DateTime.Now
        };

        _context.B2BUsers.Add(admin);
        await _context.SaveChangesAsync();

        return Ok(new
        {
            message = "Admin kullanıcı oluşturuldu.",
            username = admin.Username
        });
    }

    [HttpPost("create-admin-for-cari")]
    public async Task<IActionResult> CreateAdminForCari([FromBody] CreateAdminForCariRequest request)
    {
        if (!IsAdmin())
            return Forbid();

        if (string.IsNullOrWhiteSpace(request.CariKod))
            return BadRequest(new { message = "Cari kod boş olamaz." });

        var cariKod = request.CariKod.Trim();

        var cari = await _context.CariKartListesis
            .AsNoTracking()
            .Where(x => x.Kod == cariKod && x.Sil == 0)
            .Select(x => new
            {
                x.Kod,
                x.Unvan,
                x.Ad,
                x.Soyad
            })
            .FirstOrDefaultAsync();

        if (cari == null)
            return NotFound(new { message = "Cari kart bulunamadı." });


        var existingActiveUserForCari = await _context.B2BUsers
            .AsNoTracking()
            .FirstOrDefaultAsync(x =>
                x.CariKod == cari.Kod &&
                x.IsActive);

        if (existingActiveUserForCari != null)
        {
            return Conflict(new
            {
                message = $"Bu cari için zaten aktif kullanıcı var. Kullanıcı: {existingActiveUserForCari.Username}, Tip: {existingActiveUserForCari.UserType}",
                username = existingActiveUserForCari.Username,
                userType = existingActiveUserForCari.UserType,
                cariKod = existingActiveUserForCari.CariKod
            });
        }

        var username = await GenerateUniqueUsernameAsync(
            ad: cari.Ad,
            soyad: cari.Soyad,
            unvan: cari.Unvan,
            cariKod: cari.Kod
        );

        var password = B2BCredentialGenerator.GeneratePassword(
            cari.Unvan,
            cari.Ad,
            cari.Soyad,
            cari.Kod
        );

        var adminUser = new B2BUser
        {
            UserType = "Admin",
            Username = username,
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(password, workFactor: 12),
            CariKod = cari.Kod,
            IsActive = true,
            MustChangePassword = true,
            CreatedAt = DateTime.Now
        };

        _context.B2BUsers.Add(adminUser);
        await _context.SaveChangesAsync();

        return Ok(new
        {
            message = "Seçili cari için admin kullanıcı oluşturuldu.",
            username = adminUser.Username,
            password,
            cariKod = cari.Kod,
            cariUnvan = string.IsNullOrWhiteSpace(cari.Unvan)
                ? $"{cari.Ad} {cari.Soyad}".Trim()
                : cari.Unvan
        });
    }

    [HttpGet("cariler")]
    public async Task<IActionResult> GetCariKartlar(
    [FromQuery] string? cariKod = null,
    [FromQuery] string? cariUnvan = null,
    [FromQuery] string? search = null
)
    {
        if (!IsAdmin())
            return Forbid();

        var kodText = (cariKod ?? "").Trim();
        var unvanText = (cariUnvan ?? "").Trim();
        var searchText = (search ?? "").Trim();

        // Hiç filtre yoksa veya çok kısa arama varsa tabloyu boşuna tarama.
        var hasAnyFilter =
            !string.IsNullOrWhiteSpace(kodText) ||
            !string.IsNullOrWhiteSpace(unvanText) ||
            !string.IsNullOrWhiteSpace(searchText);

        if (!hasAnyFilter)
            return Ok(Array.Empty<object>());

        if (kodText.Length == 1 && string.IsNullOrWhiteSpace(unvanText) && string.IsNullOrWhiteSpace(searchText))
            return Ok(Array.Empty<object>());

        if (unvanText.Length == 1 && string.IsNullOrWhiteSpace(kodText) && string.IsNullOrWhiteSpace(searchText))
            return Ok(Array.Empty<object>());

        if (searchText.Length == 1 && string.IsNullOrWhiteSpace(kodText) && string.IsNullOrWhiteSpace(unvanText))
            return Ok(Array.Empty<object>());

        var query = _context.CariKartListesis
            .AsNoTracking()
            .Where(x => x.Sil == 0)
            .Where(x => x.Drm == null || x.Drm == "" || x.Drm == "Aktif");

        if (!string.IsNullOrWhiteSpace(kodText))
        {
            query = query.Where(x =>
                x.Kod != null &&
                EF.Functions.Like(x.Kod, EscapeLike(kodText) + "%", "\\")
            );
        }

        if (!string.IsNullOrWhiteSpace(unvanText))
        {
            var like = "%" + EscapeLike(unvanText) + "%";

            query = query.Where(x =>
                (x.Unvan != null && EF.Functions.Like(x.Unvan, like, "\\")) ||
                (x.Ad != null && EF.Functions.Like(x.Ad, like, "\\")) ||
                (x.Soyad != null && EF.Functions.Like(x.Soyad, like, "\\"))
            );
        }

        if (!string.IsNullOrWhiteSpace(searchText))
        {
            var searchLike = "%" + EscapeLike(searchText) + "%";
            var searchStarts = EscapeLike(searchText) + "%";

            query = query.Where(x =>
                (x.Kod != null && EF.Functions.Like(x.Kod, searchStarts, "\\")) ||
                (x.Unvan != null && EF.Functions.Like(x.Unvan, searchLike, "\\")) ||
                (x.Ad != null && EF.Functions.Like(x.Ad, searchLike, "\\")) ||
                (x.Soyad != null && EF.Functions.Like(x.Soyad, searchLike, "\\"))
            );
        }

        var carilerRaw = await query
    .OrderByDescending(x => x.SonhrkTarih)
    .ThenBy(x => x.Kod)
    .Take(50)
    .Select(x => new
    {
        cariKod = x.Kod,
        unvan = x.Unvan,
        ad = x.Ad,
        soyad = x.Soyad,
        tel = x.Tel,
        cep = x.Cep,
        mail = x.Mail,
        durum = x.Drm,

        topBakiye = x.TopBakiye,
        cariBakiye = x.CarBakiye,
        borcBakiye = x.BrcBakiye,
        alacakBakiye = x.AlcBakiye,
        sonHareketTarihi = x.SonhrkTarih
    })
    .ToListAsync();

        var kullaniciOlanCariKodlar = await _context.B2BUsers
            .AsNoTracking()
            .Where(x => x.IsActive && x.CariKod != null && x.CariKod != "")
            .Select(x => x.CariKod!)
            .Distinct()
            .ToListAsync();

        var kullaniciSet = kullaniciOlanCariKodlar.ToHashSet(
            StringComparer.OrdinalIgnoreCase
        );

        var result = carilerRaw.Select(x => new
        {
            x.cariKod,
            x.unvan,
            x.ad,
            x.soyad,
            x.tel,
            x.cep,
            x.mail,
            x.durum,

            x.topBakiye,
            x.cariBakiye,
            x.borcBakiye,
            x.alacakBakiye,
            x.sonHareketTarihi,

            hasUser = !string.IsNullOrWhiteSpace(x.cariKod) &&
                      kullaniciSet.Contains(x.cariKod)
        });

        return Ok(result);
    }

    private static string EscapeLike(string value)
    {
        return value
            .Trim()
            .Replace("\\", "\\\\")
            .Replace("%", "\\%")
            .Replace("_", "\\_")
            .Replace("[", "\\[");
    }
    private async Task<string> GenerateUniqueUsernameAsync(
    string? ad,
    string? soyad,
    string? unvan,
    string cariKod,
    string? prefix = null)
    {
        var baseUsername = BuildUsernameBase(ad, soyad, unvan, cariKod);

        var cleanPrefix = NormalizeUsernamePart(prefix);

        if (!string.IsNullOrWhiteSpace(cleanPrefix))
            baseUsername = $"{cleanPrefix}.{baseUsername}";

        var username = baseUsername;
        var counter = 2;

        while (await UsernameExistsAsync(username))
        {
            username = $"{baseUsername}{counter}";
            counter++;
        }

        return username;
    }

    private async Task<bool> UsernameExistsAsync(List<string> usernameCandidates)
{
    foreach (var candidate in usernameCandidates)
    {
        var exists = await _context.B2BUsers
            .AsNoTracking()
            .AnyAsync(x => x.Username == candidate);

        if (exists)
            return true;
    }

    return false;
}

private async Task<bool> UsernameExistsAsync(string username)
{
    var usernameCandidates = BuildLoginUsernameCandidates(username);
    return await UsernameExistsAsync(usernameCandidates);
}

    private static string BuildUsernameBase(
        string? ad,
        string? soyad,
        string? unvan,
        string cariKod)
    {
        var cleanAd = NormalizeUsernamePart(ad);
        var cleanSoyad = NormalizeUsernamePart(soyad);

        if (!string.IsNullOrWhiteSpace(cleanAd) &&
            !string.IsNullOrWhiteSpace(cleanSoyad))
        {
            return $"{cleanAd}.{cleanSoyad}";
        }

        if (!string.IsNullOrWhiteSpace(cleanAd))
            return cleanAd;

        if (!string.IsNullOrWhiteSpace(cleanSoyad))
            return cleanSoyad;

        var cleanUnvan = NormalizeUsernamePart(unvan);

        if (!string.IsNullOrWhiteSpace(cleanUnvan))
            return cleanUnvan;

        return NormalizeUsernamePart(cariKod);
    }

    private static List<string> BuildLoginUsernameCandidates(string username)
    {
        var value = username.Trim();

        var candidates = new List<string>();

        void Add(string? item)
        {
            if (string.IsNullOrWhiteSpace(item))
                return;

            item = item.Trim();

            if (!candidates.Contains(item, StringComparer.Ordinal))
                candidates.Add(item);
        }

        // 1) Kullanıcı nasıl yazdıysa önce onu dene.
        Add(value);

        // 2) Cari/admin create endpointlerinde üretilen normalize kullanıcı adı.
        // Örn: CİHAN -> cihan, Çağrı -> cagri
        Add(NormalizeUsernamePart(value));

        // 3) Eski create-admin endpointi için: CIHAN
        Add(value.ToUpperInvariant());

        // 4) Türkçe büyük harf için: CİHAN
        Add(value.ToUpper(new CultureInfo("tr-TR")));

        // 5) Küçük harf varyasyonları.
        Add(value.ToLowerInvariant());
        Add(value.ToLower(new CultureInfo("tr-TR")));

        return candidates;
    }

    private static int UsernameMatchPriority(string dbUsername, List<string> candidates)
    {
        var index = candidates.FindIndex(x => x == dbUsername);
        return index < 0 ? int.MaxValue : index;
    }

    private static string NormalizeUsernamePart(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return "";

        var text = value.Trim().ToLower(new CultureInfo("tr-TR"));

        text = text
            .Replace("ç", "c")
            .Replace("ğ", "g")
            .Replace("ı", "i")
            .Replace("i̇", "i")
            .Replace("ö", "o")
            .Replace("ş", "s")
            .Replace("ü", "u");

        var normalized = text.Normalize(NormalizationForm.FormD);
        var sb = new StringBuilder();

        var lastWasDot = false;

        foreach (var ch in normalized)
        {
            var category = CharUnicodeInfo.GetUnicodeCategory(ch);

            if (category == UnicodeCategory.NonSpacingMark)
                continue;

            if (char.IsLetterOrDigit(ch))
            {
                sb.Append(ch);
                lastWasDot = false;
            }
            else if (!lastWasDot)
            {
                sb.Append('.');
                lastWasDot = true;
            }
        }

        return sb.ToString().Trim('.');
    }

}

public class CreateAdminForCariRequest
{
    public string CariKod { get; set; } = "";
}

