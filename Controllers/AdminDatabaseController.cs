using System.Security.Claims;
using AvmB2B.Api.DTOs.AdminDatabase;
using AvmB2B.Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AvmB2B.Api.Controllers;

[ApiController]
[Route("api/admin/database")]
[Authorize]
public class AdminDatabaseController : ControllerBase
{
    private readonly AdminDatabaseService _service;

    public AdminDatabaseController(AdminDatabaseService service)
    {
        _service = service;
    }

    [HttpGet("notifications/active")]
    public async Task<IActionResult> GetActiveNotifications()
    {
        if (!IsAdmin())
            return Forbid();

        var result = await _service.GetActiveNotificationsAsync();
        return Ok(result);
    }

    [HttpGet("candidates")]
    public async Task<IActionResult> GetCandidates()
    {
        if (!IsAdmin())
            return Forbid();

        var result = await _service.GetCandidatesAsync();
        return Ok(result);
    }

    [HttpPost("scan")]
    public async Task<IActionResult> Scan()
    {
        if (!IsAdmin())
            return Forbid();

        await _service.RunScanAsync();

        return Ok(new
        {
            success = true,
            message = "Veritabanı kontrolü tamamlandı."
        });
    }

    [HttpGet("compare")]
    public async Task<IActionResult> Compare(
        [FromQuery] string sourceDatabase,
        [FromQuery] string targetDatabase)
    {
        if (!IsAdmin())
            return Forbid();

        var result = await _service.CompareAsync(sourceDatabase, targetDatabase);
        return Ok(result);
    }

    [HttpPost("migrate")]
    public async Task<IActionResult> Migrate([FromBody] MigrateDatabaseRequest request)
    {
        if (!IsAdmin())
            return Forbid();

        var result = await _service.MigrateAsync(request, User);
        return Ok(result);
    }

    [HttpPost("switch-active")]
    public async Task<IActionResult> SwitchActiveDatabase(
    [FromBody] SwitchActiveDatabaseRequest request)
    {
        if (!IsAdmin())
            return Forbid();

        var result = await _service.SwitchActiveDatabaseAsync(request, User);
        return Ok(result);
    }

    private bool IsAdmin()
    {
        var userType = User.FindFirst("userType")?.Value;

        if (string.Equals(userType, "Admin", StringComparison.OrdinalIgnoreCase))
            return true;

        var role = User.FindFirst(ClaimTypes.Role)?.Value;

        return string.Equals(role, "Admin", StringComparison.OrdinalIgnoreCase);
    }
}