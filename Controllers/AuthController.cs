using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AvmB2B.Api.Data;
using AvmB2B.Api.DTOs.Auth;
using AvmB2B.Api.Entities;
using AvmB2B.Api.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authorization;
using System.Globalization;

namespace AvmB2B.Api.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly PetrolDbContext _context;
    private readonly IConfiguration _configuration;

    public AuthController(PetrolDbContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
    }

    [Authorize]
    [HttpPost("create-cari-user")]
    public async Task<IActionResult> CreateCariUser([FromBody] CreateCariUserRequest request)
    {
        var userType = User.FindFirst("userType")?.Value;

        if (userType != "Admin")
            return Forbid();

        if (string.IsNullOrWhiteSpace(request.CariKod))
        {
            return BadRequest(new
            {
                success = false,
                message = "Cari kod boş olamaz."
            });
        }

        var cariKod = request.CariKod.Trim();

        var cari = await _context.CariKartListesis
            .AsNoTracking()
            .Where(x => x.Kod == cariKod && x.Sil == 0)
            .Select(x => new
            {
                Kod = x.Kod,
                Unvan = x.Unvan,
                Ad = x.Ad,
                Soyad = x.Soyad
            })
            .FirstOrDefaultAsync();

        if (cari == null)
        {
            return NotFound(new
            {
                success = false,
                message = "Cari kart bulunamadı.",
                cariKod = cariKod
            });
        }

        var existingActiveUserForCari = await _context.B2BUsers
            .AsNoTracking()
            .FirstOrDefaultAsync(x =>
                x.CariKod == cari.Kod &&
                x.IsActive);

        if (existingActiveUserForCari != null)
        {
            return Conflict(new
            {
                success = false,
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

        var plainPassword = B2BCredentialGenerator.GeneratePassword(
            cari.Unvan,
            cari.Ad,
            cari.Soyad,
            cari.Kod
        );

        var user = new B2BUser
        {
            UserType = "Cari",
            Username = username,
            PasswordHash = BCrypt.Net.BCrypt.HashPassword(plainPassword, workFactor: 12),
            CariKod = cari.Kod,
            IsActive = true,
            MustChangePassword = true,
            CreatedAt = DateTime.Now
        };

        _context.B2BUsers.Add(user);
        await _context.SaveChangesAsync();

        return Ok(new
        {
            success = true,
            message = "Cari kullanıcı başarıyla oluşturuldu.",
            username = username,
            password = plainPassword,
            cariKod = cari.Kod,
            cariUnvan = cari.Unvan,
            mustChangePassword = user.MustChangePassword
        });
    }

    [Authorize]
    [HttpGet("users")]
    public async Task<IActionResult> GetUsers()
    {
        var userType = User.FindFirst("userType")?.Value;

        if (userType != "Admin")
            return Forbid();

        var users = await _context.B2BUsers
            .AsNoTracking()
            .OrderByDescending(x => x.CreatedAt)
            .Select(x => new
            {
                id = x.Id,
                username = x.Username,
                userType = x.UserType,
                cariKod = x.CariKod,
                isActive = x.IsActive,
                mustChangePassword = x.MustChangePassword,
                createdAt = x.CreatedAt
            })
            .ToListAsync();

        return Ok(users);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Username))
            return Unauthorized("Kullanıcı adı veya şifre hatalı.");

        if (string.IsNullOrWhiteSpace(request.Password))
            return Unauthorized("Kullanıcı adı veya şifre hatalı.");

        var inputUsername = request.Username.Trim();
        var password = request.Password.Trim();

        var usernameCandidates = BuildLoginUsernameCandidates(inputUsername);

        B2BUser? user = null;

        foreach (var candidate in usernameCandidates)
        {
            user = await _context.B2BUsers
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Username == candidate);

            if (user != null)
                break;
        }

        if (user == null)
            return Unauthorized("Kullanıcı adı veya şifre hatalı.");

        if (!user.IsActive)
            return Unauthorized("Kullanıcı pasif.");

        var passwordValid = BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);

        if (!passwordValid)
            return Unauthorized("Kullanıcı adı veya şifre hatalı.");

        var token = GenerateJwtToken(user);

        return Ok(new LoginResponse
        {
            Token = token,
            Username = user.Username,
            UserType = user.UserType,
            CariKod = user.CariKod,
            MustChangePassword = user.MustChangePassword
        });
    }

    [HttpPost("create-admin")]
    public async Task<IActionResult> CreateAdmin([FromBody] CreateAdminRequest request)
    {
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

    [Authorize]
    [HttpGet("me")]
    public async Task<IActionResult> Me()
    {
        var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (string.IsNullOrWhiteSpace(userId))
            return Unauthorized();

        var user = await _context.B2BUsers
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == int.Parse(userId));

        if (user == null)
            return Unauthorized();

        return Ok(new
        {
            user.Id,
            user.Username,
            user.UserType,
            user.CariKod,
            user.IsActive,
            user.MustChangePassword
        });
    }

    [Authorize]
    [HttpPost("change-password")]
    public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.CurrentPassword))
            return BadRequest("Mevcut şifre boş olamaz.");

        if (string.IsNullOrWhiteSpace(request.NewPassword))
            return BadRequest("Yeni şifre boş olamaz.");

        if (request.NewPassword.Length <= 4)
            return BadRequest("Yeni şifre en az 4 karakter olmalı.");

        var userIdText = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (!int.TryParse(userIdText, out var userId))
            return Unauthorized("Kullanıcı bilgisi okunamadı.");

        var user = await _context.B2BUsers
            .FirstOrDefaultAsync(x => x.Id == userId);

        if (user == null)
            return NotFound("Kullanıcı bulunamadı.");

        if (!user.IsActive)
            return Unauthorized("Kullanıcı pasif.");

        var currentPasswordValid = BCrypt.Net.BCrypt.Verify(
            request.CurrentPassword,
            user.PasswordHash
        );

        if (!currentPasswordValid)
            return BadRequest("Mevcut şifre hatalı.");

        user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.NewPassword, workFactor: 12);
        user.MustChangePassword = false;

        await _context.SaveChangesAsync();

        return Ok(new
        {
            message = "Şifre başarıyla değiştirildi."
        });
    }

    private string GenerateJwtToken(B2BUser user)
    {
        var key = _configuration["Jwt:Key"]!;
        var issuer = _configuration["Jwt:Issuer"]!;
        var audience = _configuration["Jwt:Audience"]!;
        var expireMinutes = int.Parse(_configuration["Jwt:ExpireMinutes"] ?? "120");

        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.Username),
            new Claim("userType", user.UserType),
            new Claim("mustChangePassword", user.MustChangePassword.ToString())
        };

        if (!string.IsNullOrWhiteSpace(user.CariKod))
            claims.Add(new Claim("cariKod", user.CariKod));

        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: issuer,
            audience: audience,
            claims: claims,
            expires: DateTime.Now.AddMinutes(expireMinutes),
            signingCredentials: credentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    private async Task<string> GenerateUniqueUsernameAsync(
    string? ad,
    string? soyad,
    string? unvan,
    string cariKod)
    {
        var baseUsername = BuildUsernameBase(ad, soyad, unvan, cariKod);

        var username = baseUsername;
        var counter = 2;

        while (await UsernameExistsAsync(username))
        {
            username = $"{baseUsername}{counter}";
            counter++;
        }

        return username;
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