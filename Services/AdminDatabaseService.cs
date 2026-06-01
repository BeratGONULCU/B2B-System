using System.Security.Claims;
using System.Text.RegularExpressions;
using AvmB2B.Api.Data;
using AvmB2B.Api.DTOs.AdminDatabase;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace AvmB2B.Api.Services;

public class AdminDatabaseService
{
    private readonly IConfiguration _configuration;

    public AdminDatabaseService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<List<DatabaseCandidateDto>> GetCandidatesAsync()
    {
        var currentDb = DatabaseInitializer.GetCurrentDatabaseName(_configuration);
        var connectionString = _configuration.GetConnectionString("PetrolDb")
            ?? throw new Exception("ConnectionStrings:PetrolDb bulunamadı.");

        var result = new List<DatabaseCandidateDto>();

        await using var connection = new SqlConnection(connectionString);
        await connection.OpenAsync();

        var dbNames = await GetPetrolDatabaseNamesAsync(connection);

        foreach (var dbName in dbNames)
        {
            var hasOpenNotification = await HasOpenNotificationAsync(connection, dbName);

            result.Add(new DatabaseCandidateDto
            {
                DatabaseName = dbName,
                IsCurrent = dbName.Equals(currentDb, StringComparison.OrdinalIgnoreCase),
                HasOpenNotification = hasOpenNotification
            });
        }

        return result;
    }

    public async Task<List<DatabaseNotificationDto>> GetActiveNotificationsAsync()
    {
        var connectionString = _configuration.GetConnectionString("PetrolDb")
            ?? throw new Exception("ConnectionStrings:PetrolDb bulunamadı.");

        var result = new List<DatabaseNotificationDto>();

        await using var connection = new SqlConnection(connectionString);
        await connection.OpenAsync();

        var sql = @"
SELECT
    Id,
    DatabaseName,
    ChangeType,
    Title,
    Message,
    IsRequiredAction,
    CreatedAt
FROM dbo.B2B_DatabaseChangeNotifications
WHERE IsResolved = 0
ORDER BY CreatedAt DESC;
";

        await using var command = new SqlCommand(sql, connection);
        await using var reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            result.Add(new DatabaseNotificationDto
            {
                Id = Convert.ToInt32(reader["Id"]),
                DatabaseName = reader["DatabaseName"]?.ToString() ?? "",
                ChangeType = reader["ChangeType"]?.ToString() ?? "",
                Title = reader["Title"]?.ToString() ?? "",
                Message = reader["Message"]?.ToString() ?? "",
                IsRequiredAction = Convert.ToBoolean(reader["IsRequiredAction"]),
                CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
            });
        }

        return result;
    }

    public async Task RunScanAsync()
    {
        var currentDb = DatabaseInitializer.GetCurrentDatabaseName(_configuration);
        var connectionString = _configuration.GetConnectionString("PetrolDb")
            ?? throw new Exception("ConnectionStrings:PetrolDb bulunamadı.");

        await using var connection = new SqlConnection(connectionString);
        await connection.OpenAsync();

        var scanRunId = await CreateScanRunAsync(connection);

        try
        {
            var dbNames = await GetPetrolDatabaseNamesAsync(connection);

            foreach (var dbName in dbNames)
            {
                await InsertDatabaseInventoryAsync(connection, scanRunId, dbName);
            }

            var newestDb = dbNames
                .OrderByDescending(x => x)
                .FirstOrDefault();

            if (!string.IsNullOrWhiteSpace(newestDb) &&
                !newestDb.Equals(currentDb, StringComparison.OrdinalIgnoreCase))
            {
                await CreateNotificationIfNotExistsAsync(
                    connection,
                    newestDb,
                    "NewDatabaseFound",
                    "Yeni veritabanı bulundu",
                    $"Yeni PETROL veritabanı bulundu: {newestDb}. Aktif veritabanı: {currentDb}. Geçiş yapılana kadar bu bildirim adminlere gösterilecektir."
                );
            }

            await CompleteScanRunAsync(connection, scanRunId, dbNames.Count, "Completed", null);
        }
        catch (Exception ex)
        {
            await CompleteScanRunAsync(connection, scanRunId, 0, "Failed", ex.Message);
            throw;
        }
    }

    public async Task<DatabaseCompareResultDto> CompareAsync(
    string sourceDatabase,
    string targetDatabase)
    {
        ValidateDatabaseName(sourceDatabase);
        ValidateDatabaseName(targetDatabase);

        var connectionString = _configuration.GetConnectionString("PetrolDb")
            ?? throw new Exception("ConnectionStrings:PetrolDb bulunamadı.");

        await using var connection = new SqlConnection(connectionString);
        await connection.OpenAsync();

        await EnsureDatabaseExistsAsync(connection, sourceDatabase);
        await EnsureDatabaseExistsAsync(connection, targetDatabase);

        var source = QuoteName(sourceDatabase);
        var target = QuoteName(targetDatabase);

        var sql = $@"
IF OBJECT_ID(N'{sourceDatabase}.dbo.Cari_Kart_Listesi') IS NULL
    THROW 53000, 'Kaynak DB içinde dbo.Cari_Kart_Listesi bulunamadı.', 1;

IF OBJECT_ID(N'{targetDatabase}.dbo.Cari_Kart_Listesi') IS NULL
    THROW 53001, 'Hedef DB içinde dbo.Cari_Kart_Listesi bulunamadı.', 1;

IF OBJECT_ID(N'{sourceDatabase}.dbo.carikart', N'U') IS NULL
    THROW 53002, 'Kaynak DB içinde dbo.carikart bulunamadı.', 1;

IF OBJECT_ID(N'{targetDatabase}.dbo.carikart', N'U') IS NULL
    THROW 53003, 'Hedef DB içinde dbo.carikart bulunamadı.', 1;

SELECT
    SourceCariKartListesiCount =
    (
        SELECT COUNT(*)
        FROM {source}.dbo.Cari_Kart_Listesi
    ),

    TargetCariKartListesiCount =
    (
        SELECT COUNT(*)
        FROM {target}.dbo.Cari_Kart_Listesi
    ),

    SourceCarikartCount =
    (
        SELECT COUNT(*)
        FROM {source}.dbo.carikart
    ),

    TargetCarikartCount =
    (
        SELECT COUNT(*)
        FROM {target}.dbo.carikart
    ),

    B2BUsersTotal =
    (
        SELECT COUNT(*)
        FROM {source}.dbo.B2B_Users u
        WHERE u.UserType = N'Cari'
    ),

    B2BUsersMissingInTargetCariSources =
    (
        SELECT COUNT(*)
        FROM {source}.dbo.B2B_Users u
        WHERE u.UserType = N'Cari'
          AND u.CariKod IS NOT NULL
          AND LTRIM(RTRIM(u.CariKod)) <> N''
          AND NOT EXISTS (
              SELECT 1
              FROM {target}.dbo.Cari_Kart_Listesi c
              WHERE c.kod = u.CariKod
                AND ISNULL(c.sil, 0) = 0
          )
          AND NOT EXISTS (
              SELECT 1
              FROM {target}.dbo.carikart ck
              WHERE ck.kod = u.CariKod
                AND ISNULL(ck.sil, 0) = 0
          )
    ),

    B2BCariLocksTotal =
    (
        SELECT COUNT(*)
        FROM {source}.dbo.B2B_CariLocks l
    ),

    B2BCariLocksMissingInTargetCariSources =
    (
        SELECT COUNT(*)
        FROM {source}.dbo.B2B_CariLocks l
        WHERE l.CariKod IS NOT NULL
          AND LTRIM(RTRIM(l.CariKod)) <> N''
          AND NOT EXISTS (
              SELECT 1
              FROM {target}.dbo.Cari_Kart_Listesi c
              WHERE c.kod = l.CariKod
                AND ISNULL(c.sil, 0) = 0
          )
          AND NOT EXISTS (
              SELECT 1
              FROM {target}.dbo.carikart ck
              WHERE ck.kod = l.CariKod
                AND ISNULL(ck.sil, 0) = 0
          )
    ),

    B2BPaymentsTotal =
    (
        SELECT COUNT(*)
        FROM {source}.dbo.B2B_Payments p
    ),

    B2BPaymentsMissingInTargetCariSources =
    (
        SELECT COUNT(*)
        FROM {source}.dbo.B2B_Payments p
        WHERE p.CariKod IS NOT NULL
          AND LTRIM(RTRIM(p.CariKod)) <> N''
          AND NOT EXISTS (
              SELECT 1
              FROM {target}.dbo.Cari_Kart_Listesi c
              WHERE c.kod = p.CariKod
                AND ISNULL(c.sil, 0) = 0
          )
          AND NOT EXISTS (
              SELECT 1
              FROM {target}.dbo.carikart ck
              WHERE ck.kod = p.CariKod
                AND ISNULL(ck.sil, 0) = 0
          )
    ),

    B2BPaymentLogsWillBeDeleted =
    (
        SELECT COUNT(*)
        FROM {source}.dbo.B2B_PaymentLogs pl
        INNER JOIN {source}.dbo.B2B_Payments p ON p.Id = pl.PaymentId
        WHERE p.CariKod IS NOT NULL
          AND LTRIM(RTRIM(p.CariKod)) <> N''
          AND NOT EXISTS (
              SELECT 1
              FROM {target}.dbo.Cari_Kart_Listesi c
              WHERE c.kod = p.CariKod
                AND ISNULL(c.sil, 0) = 0
          )
          AND NOT EXISTS (
              SELECT 1
              FROM {target}.dbo.carikart ck
              WHERE ck.kod = p.CariKod
                AND ISNULL(ck.sil, 0) = 0
          )
    );
";

        await using var command = new SqlCommand(sql, connection);
        command.CommandTimeout = 180;

        await using var reader = await command.ExecuteReaderAsync();

        if (!await reader.ReadAsync())
            throw new Exception("Veritabanı karşılaştırma sonucu alınamadı.");

        var result = new DatabaseCompareResultDto
        {
            SourceDatabase = sourceDatabase,
            TargetDatabase = targetDatabase,

            SourceCariKartListesiCount = Convert.ToInt32(reader["SourceCariKartListesiCount"]),
            TargetCariKartListesiCount = Convert.ToInt32(reader["TargetCariKartListesiCount"]),

            SourceCarikartCount = Convert.ToInt32(reader["SourceCarikartCount"]),
            TargetCarikartCount = Convert.ToInt32(reader["TargetCarikartCount"]),

            B2BUsersTotal = Convert.ToInt32(reader["B2BUsersTotal"]),
            B2BUsersMissingInTargetCariSources = Convert.ToInt32(reader["B2BUsersMissingInTargetCariSources"]),

            B2BCariLocksTotal = Convert.ToInt32(reader["B2BCariLocksTotal"]),
            B2BCariLocksMissingInTargetCariSources = Convert.ToInt32(reader["B2BCariLocksMissingInTargetCariSources"]),

            B2BPaymentsTotal = Convert.ToInt32(reader["B2BPaymentsTotal"]),
            B2BPaymentsMissingInTargetCariSources = Convert.ToInt32(reader["B2BPaymentsMissingInTargetCariSources"]),

            B2BPaymentLogsWillBeDeleted = Convert.ToInt32(reader["B2BPaymentLogsWillBeDeleted"])
        };

        if (result.B2BUsersMissingInTargetCariSources > 0)
        {
            result.Warnings.Add(
                $"{result.B2BUsersMissingInTargetCariSources} cari kullanıcı hedef veritabanındaki carikart veya Cari_Kart_Listesi içinde bulunamadı. Migration sonrası bu kullanıcılar silinecek."
            );
        }

        if (result.B2BCariLocksMissingInTargetCariSources > 0)
        {
            result.Warnings.Add(
                $"{result.B2BCariLocksMissingInTargetCariSources} cari kilit kaydı hedef veritabanındaki cari kaynaklarında bulunamadı. Migration sonrası silinecek."
            );
        }

        if (result.B2BPaymentsMissingInTargetCariSources > 0)
        {
            result.Warnings.Add(
                $"{result.B2BPaymentsMissingInTargetCariSources} ödeme kaydı hedef veritabanındaki cari kaynaklarında bulunamadı. Migration sonrası bu ödeme kayıtları ve bağlı logları silinecek."
            );
        }

        if (result.B2BPaymentLogsWillBeDeleted > 0)
        {
            result.Warnings.Add(
                $"{result.B2BPaymentLogsWillBeDeleted} ödeme log kaydı silinecek ödeme kayıtlarına bağlı olduğu için silinecek."
            );
        }

        return result;
    }

    public async Task<MigrateDatabaseResponse> MigrateAsync(
        MigrateDatabaseRequest request,
        ClaimsPrincipal user)
    {
        ValidateDatabaseName(request.SourceDatabase);
        ValidateDatabaseName(request.TargetDatabase);

        if (request.SourceDatabase.Equals(request.TargetDatabase, StringComparison.OrdinalIgnoreCase))
        {
            throw new Exception("Kaynak ve hedef veritabanı aynı olamaz.");
        }

        if (!request.ConfirmInvalidCariDataWillBeDeleted)
        {
            throw new Exception("Hedef veritabanında bulunmayan carilere bağlı B2B verilerinin silineceğini onaylamalısınız.");
        }

        if (!request.ConfirmPaymentHistoryWillBeDeletedForInvalidCari)
        {
            throw new Exception("Hedef veritabanında bulunmayan carilere ait ödeme kayıtlarının ve ödeme loglarının silineceğini onaylamalısınız.");
        }

        var userIdText = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        int? userId = int.TryParse(userIdText, out var parsedUserId)
            ? parsedUserId
            : null;

        var username = user.Identity?.Name
            ?? user.FindFirst(ClaimTypes.Name)?.Value
            ?? "UNKNOWN";

        DatabaseInitializer.InitializeForDatabase(_configuration, request.TargetDatabase);

        var targetConnectionString = DatabaseInitializer.BuildConnectionStringForDatabase(
            _configuration,
            request.TargetDatabase
        );

        await using var targetConnection = new SqlConnection(targetConnectionString);
        await targetConnection.OpenAsync();

        var sql = @"
EXEC dbo.B2B_MigrateFromDatabase
    @SourceDatabase = @SourceDatabase,
    @MigratedByUserId = @MigratedByUserId,
    @MigratedByUsername = @MigratedByUsername;
";

        await using var command = new SqlCommand(sql, targetConnection);
        command.CommandTimeout = 600;
        command.Parameters.AddWithValue("@SourceDatabase", request.SourceDatabase);
        command.Parameters.AddWithValue("@MigratedByUserId", (object?)userId ?? DBNull.Value);
        command.Parameters.AddWithValue("@MigratedByUsername", username);

        await command.ExecuteNonQueryAsync();

        var latestHistory = await GetLatestMigrationHistoryAsync(
            targetConnection,
            request.SourceDatabase,
            request.TargetDatabase
        );

        return new MigrateDatabaseResponse
        {
            Success = true,
            Message = "Veritabanı geçişi tamamlandı. Uygulamanın yeni veritabanına bağlanması için connection string güncellenip API servisi yeniden başlatılmalıdır.",
            MigrationHistoryId = latestHistory.historyId,
            WarningCount = latestHistory.warningCount
        };
    }

    private async Task ResolveOpenDatabaseNotificationsAsync(
    string connectionString,
    string databaseName,
    int? resolvedByUserId)
    {
        await using var connection = new SqlConnection(connectionString);
        await connection.OpenAsync();

        const string sql = @"
IF OBJECT_ID('dbo.B2B_DatabaseChangeNotifications', 'U') IS NOT NULL
BEGIN
    UPDATE dbo.B2B_DatabaseChangeNotifications
    SET
        IsResolved = 1,
        ResolvedAt = SYSUTCDATETIME(),
        ResolvedByUserId = @ResolvedByUserId
    WHERE DatabaseName = @DatabaseName
      AND ChangeType = N'NewDatabaseFound'
      AND IsResolved = 0;
END;
";

        await using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@DatabaseName", databaseName);
        command.Parameters.AddWithValue(
            "@ResolvedByUserId",
            (object?)resolvedByUserId ?? DBNull.Value
        );

        await command.ExecuteNonQueryAsync();
    }

    private async Task ResolveOpenDatabaseNotificationsInAllPetrolDatabasesAsync(
        string databaseName,
        int? resolvedByUserId)
    {
        var baseConnectionString = _configuration.GetConnectionString("PetrolDb")
            ?? throw new Exception("ConnectionStrings:PetrolDb bulunamadı.");

        var databaseNames = new List<string>();

        await using (var connection = new SqlConnection(baseConnectionString))
        {
            await connection.OpenAsync();

            const string sql = @"
SELECT name
FROM sys.databases
WHERE name LIKE N'PETROL[_]%'
   OR name = N'PETROL'
ORDER BY name;
";

            await using var command = new SqlCommand(sql, connection);
            await using var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                var dbName = reader["name"]?.ToString();

                if (!string.IsNullOrWhiteSpace(dbName))
                    databaseNames.Add(dbName);
            }
        }

        foreach (var dbName in databaseNames)
        {
            try
            {
                var dbConnectionString = DatabaseInitializer.BuildConnectionStringForDatabase(
                    _configuration,
                    dbName
                );

                await ResolveOpenDatabaseNotificationsAsync(
                    dbConnectionString,
                    databaseName,
                    resolvedByUserId
                );
            }
            catch
            {
                // Bir DB'de tablo yoksa veya yetki yoksa switch işlemini tamamen bozmayalım.
                // İstersen burada loglama ekleyebiliriz.
            }
        }
    }

    private static int? GetUserId(ClaimsPrincipal user)
    {
        var value =
            user.FindFirst("userId")?.Value ??
            user.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (int.TryParse(value, out var id))
            return id;

        return null;
    }

    public async Task<SwitchActiveDatabaseResponse> SwitchActiveDatabaseAsync(
    SwitchActiveDatabaseRequest request,
    ClaimsPrincipal user)
    {
        ValidateDatabaseName(request.TargetDatabase);

        if (!request.ConfirmAppSettingsWillBeUpdated)
            throw new Exception("appsettings.json güncelleneceğini onaylamalısınız.");

        if (!request.ConfirmApiServiceWillRestart)
            throw new Exception("API servisinin yeniden başlatılacağını onaylamalısınız.");

        var resolvedByUserId = GetUserId(user);

        var oldDatabase = DatabaseInitializer.GetCurrentDatabaseName(_configuration);

        var currentConnectionString = _configuration.GetConnectionString("PetrolDb")
            ?? throw new Exception("ConnectionStrings:PetrolDb bulunamadı.");

        await using (var connection = new SqlConnection(currentConnectionString))
        {
            await connection.OpenAsync();
            await EnsureDatabaseExistsAsync(connection, request.TargetDatabase);
        }

        /*
            Önemli:
            Bildirim hangi DB içinde oluştuysa orada kapatılmalı.
            Sende PETROL_2021 içinde PETROL_2026 bildirimi açık kaldı.
            Bu yüzden sadece aktif DB değil, tüm PETROL DB'lerde ilgili bildirimi kapatıyoruz.
        */
        await ResolveOpenDatabaseNotificationsInAllPetrolDatabasesAsync(
            request.TargetDatabase,
            resolvedByUserId
        );

        if (oldDatabase.Equals(request.TargetDatabase, StringComparison.OrdinalIgnoreCase))
        {
            return new SwitchActiveDatabaseResponse
            {
                Success = true,
                Message = "Seçilen veritabanı zaten aktif. Açık veritabanı bildirimleri kapatıldı.",
                OldDatabase = oldDatabase,
                NewDatabase = request.TargetDatabase,
                RestartScheduled = false
            };
        }

        // Hedef DB içinde B2B tablolar / prosedür / ana cari kaynakları hazır mı kontrol et.
        DatabaseInitializer.InitializeForDatabase(_configuration, request.TargetDatabase);

        // Initialize sonrası hedef DB'de yeni notification oluştuysa onu da kapatalım.
        await ResolveOpenDatabaseNotificationsInAllPetrolDatabasesAsync(
            request.TargetDatabase,
            resolvedByUserId
        );

        UpdateAppSettingsConnectionString(request.TargetDatabase);

        ScheduleServiceRestart();

        return new SwitchActiveDatabaseResponse
        {
            Success = true,
            Message = "Aktif veritabanı güncellendi. API servisi birkaç saniye içinde yeniden başlatılacak.",
            OldDatabase = oldDatabase,
            NewDatabase = request.TargetDatabase,
            RestartScheduled = true
        };
    }

    private void UpdateAppSettingsConnectionString(string targetDatabase)
    {
        var appSettingsPath = ResolveAppSettingsPath();

        if (!File.Exists(appSettingsPath))
            throw new Exception($"appsettings.json bulunamadı: {appSettingsPath}");

        var jsonText = File.ReadAllText(appSettingsPath);
        var root = JsonNode.Parse(jsonText)?.AsObject()
            ?? throw new Exception("appsettings.json okunamadı.");

        var connectionStrings = root["ConnectionStrings"]?.AsObject();

        if (connectionStrings == null)
            throw new Exception("appsettings.json içinde ConnectionStrings bölümü bulunamadı.");

        var petrolDb = connectionStrings["PetrolDb"]?.GetValue<string>();

        if (string.IsNullOrWhiteSpace(petrolDb))
            throw new Exception("ConnectionStrings:PetrolDb bulunamadı.");

        var builder = new SqlConnectionStringBuilder(petrolDb)
        {
            InitialCatalog = targetDatabase
        };

        connectionStrings["PetrolDb"] = builder.ConnectionString;

        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        var backupPath = appSettingsPath + ".bak_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

        File.Copy(appSettingsPath, backupPath, overwrite: false);
        File.WriteAllText(appSettingsPath, root.ToJsonString(options));
    }

    private string ResolveAppSettingsPath()
    {
        var baseDirectoryPath = Path.Combine(AppContext.BaseDirectory, "appsettings.json");

        if (File.Exists(baseDirectoryPath))
            return baseDirectoryPath;

        var currentDirectoryPath = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");

        if (File.Exists(currentDirectoryPath))
            return currentDirectoryPath;

        return baseDirectoryPath;
    }

    private void ScheduleServiceRestart()
    {
        var serviceName = _configuration["WindowsService:ServiceName"] ?? "AvmB2b";

        var delaySecondsText = _configuration["WindowsService:RestartDelaySeconds"];
        var delaySeconds = int.TryParse(delaySecondsText, out var parsedDelay)
            ? parsedDelay
            : 5;

        var command =
            $"Start-Sleep -Seconds {delaySeconds}; Restart-Service -Name '{serviceName}' -Force";

        var startInfo = new ProcessStartInfo
        {
            FileName = "powershell.exe",
            Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{command}\"",
            CreateNoWindow = true,
            UseShellExecute = false
        };

        Process.Start(startInfo);
    }

    private async Task<(int? historyId, int warningCount)> GetLatestMigrationHistoryAsync(
        SqlConnection connection,
        string sourceDatabase,
        string targetDatabase)
    {
        var sql = @"
SELECT TOP(1)
    h.Id,
    WarningCount = (
        SELECT COUNT(*)
        FROM dbo.B2B_DatabaseMigrationIssues i
        WHERE i.MigrationHistoryId = h.Id
    )
FROM dbo.B2B_DatabaseMigrationHistory h
WHERE h.SourceDatabase = @SourceDatabase
  AND h.TargetDatabase = @TargetDatabase
ORDER BY h.Id DESC;
";

        await using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@SourceDatabase", sourceDatabase);
        command.Parameters.AddWithValue("@TargetDatabase", targetDatabase);

        await using var reader = await command.ExecuteReaderAsync();

        if (!await reader.ReadAsync())
            return (null, 0);

        return (
            Convert.ToInt32(reader["Id"]),
            Convert.ToInt32(reader["WarningCount"])
        );
    }

    private async Task<int> CreateScanRunAsync(SqlConnection connection)
    {
        var sql = @"
INSERT INTO dbo.B2B_DatabaseScanRuns (Status)
OUTPUT INSERTED.Id
VALUES (N'Started');
";

        await using var command = new SqlCommand(sql, connection);
        return Convert.ToInt32(await command.ExecuteScalarAsync());
    }

    private async Task CompleteScanRunAsync(
        SqlConnection connection,
        int scanRunId,
        int foundDatabaseCount,
        string status,
        string? message)
    {
        var sql = @"
UPDATE dbo.B2B_DatabaseScanRuns
SET
    FinishedAt = SYSUTCDATETIME(),
    Status = @Status,
    Message = @Message,
    FoundDatabaseCount = @FoundDatabaseCount
WHERE Id = @Id;
";

        await using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@Id", scanRunId);
        command.Parameters.AddWithValue("@Status", status);
        command.Parameters.AddWithValue("@Message", (object?)message ?? DBNull.Value);
        command.Parameters.AddWithValue("@FoundDatabaseCount", foundDatabaseCount);

        await command.ExecuteNonQueryAsync();
    }

    private async Task<List<string>> GetPetrolDatabaseNamesAsync(SqlConnection connection)
    {
        var result = new List<string>();

        var sql = @"
SELECT name
FROM sys.databases
WHERE state_desc = 'ONLINE'
  AND name LIKE 'PETROL[_][0-9][0-9][0-9][0-9]'
ORDER BY name DESC;
";

        await using var command = new SqlCommand(sql, connection);
        await using var reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            result.Add(reader["name"].ToString() ?? "");
        }

        return result;
    }

    private async Task InsertDatabaseInventoryAsync(
        SqlConnection connection,
        int scanRunId,
        string databaseName)
    {
        ValidateDatabaseName(databaseName);

        var db = QuoteName(databaseName);

        var sql = $@"
INSERT INTO dbo.B2B_DatabaseInventory
(
    ScanRunId,
    DatabaseName,
    TableName,
    ObjectType,
    RowCountApprox,
    ObjectModifyDate,
    SchemaHash
)
SELECT
    @ScanRunId,
    @DatabaseName,
    s.name + N'.' + t.name AS TableName,
    N'TABLE',
    SUM(p.rows) AS RowCountApprox,
    t.modify_date,
    CONVERT(NVARCHAR(128), HASHBYTES('SHA2_256',
        STRING_AGG(CONVERT(NVARCHAR(MAX), c.name + N':' + ty.name + N':' + CONVERT(NVARCHAR(20), c.max_length)), N'|')
    ), 2) AS SchemaHash
FROM {db}.sys.tables t
JOIN {db}.sys.schemas s ON s.schema_id = t.schema_id
LEFT JOIN {db}.sys.partitions p ON p.object_id = t.object_id AND p.index_id IN (0, 1)
LEFT JOIN {db}.sys.columns c ON c.object_id = t.object_id
LEFT JOIN {db}.sys.types ty ON ty.user_type_id = c.user_type_id
GROUP BY s.name, t.name, t.modify_date;
";

        await using var command = new SqlCommand(sql, connection);
        command.CommandTimeout = 120;
        command.Parameters.AddWithValue("@ScanRunId", scanRunId);
        command.Parameters.AddWithValue("@DatabaseName", databaseName);

        await command.ExecuteNonQueryAsync();
    }

    private async Task CreateNotificationIfNotExistsAsync(
        SqlConnection connection,
        string databaseName,
        string changeType,
        string title,
        string message)
    {
        var sql = @"
IF NOT EXISTS (
    SELECT 1
    FROM dbo.B2B_DatabaseChangeNotifications
    WHERE DatabaseName = @DatabaseName
      AND ChangeType = @ChangeType
      AND IsResolved = 0
)
BEGIN
    INSERT INTO dbo.B2B_DatabaseChangeNotifications
    (
        DatabaseName,
        ChangeType,
        Title,
        Message,
        IsResolved,
        IsRequiredAction
    )
    VALUES
    (
        @DatabaseName,
        @ChangeType,
        @Title,
        @Message,
        0,
        1
    );
END;
";

        await using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@DatabaseName", databaseName);
        command.Parameters.AddWithValue("@ChangeType", changeType);
        command.Parameters.AddWithValue("@Title", title);
        command.Parameters.AddWithValue("@Message", message);

        await command.ExecuteNonQueryAsync();
    }

    private async Task<bool> HasOpenNotificationAsync(SqlConnection connection, string databaseName)
    {
        var sql = @"
SELECT CASE
    WHEN EXISTS (
        SELECT 1
        FROM dbo.B2B_DatabaseChangeNotifications
        WHERE DatabaseName = @DatabaseName
          AND IsResolved = 0
    )
    THEN CAST(1 AS bit)
    ELSE CAST(0 AS bit)
END;
";

        await using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@DatabaseName", databaseName);

        return Convert.ToBoolean(await command.ExecuteScalarAsync());
    }

    private async Task EnsureDatabaseExistsAsync(SqlConnection connection, string databaseName)
    {
        var sql = @"
SELECT CASE
    WHEN DB_ID(@DatabaseName) IS NULL THEN CAST(0 AS bit)
    ELSE CAST(1 AS bit)
END;
";

        await using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@DatabaseName", databaseName);

        var exists = Convert.ToBoolean(await command.ExecuteScalarAsync());

        if (!exists)
            throw new Exception($"Veritabanı bulunamadı: {databaseName}");
    }

    private static void ValidateDatabaseName(string databaseName)
    {
        if (string.IsNullOrWhiteSpace(databaseName))
            throw new Exception("Veritabanı adı boş olamaz.");

        if (!Regex.IsMatch(databaseName, @"^[A-Za-z0-9_]+$"))
            throw new Exception($"Geçersiz veritabanı adı: {databaseName}");
    }

    private static string QuoteName(string value)
    {
        return "[" + value.Replace("]", "]]") + "]";
    }
}