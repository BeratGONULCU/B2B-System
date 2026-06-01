using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace AvmB2B.Api.Controllers;

[ApiController]
[Authorize(Policy = "AdminOnly")]
[Route("api/system")]
public class SystemController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public SystemController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpGet("databases")]
    public async Task<IActionResult> GetDatabases()
    {
        var connectionString = _configuration.GetConnectionString("PetrolDb");

        var builder = new SqlConnectionStringBuilder(connectionString)
        {
            InitialCatalog = "master"
        };

        var databases = new List<string>();

        using (var conn = new SqlConnection(builder.ConnectionString))
        {
            await conn.OpenAsync();

            var cmd = new SqlCommand("SELECT name FROM sys.databases WHERE database_id > 4", conn);

            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                databases.Add(reader.GetString(0));
            }
        }

        return Ok(databases);
    }
}