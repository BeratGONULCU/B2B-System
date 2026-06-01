using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace AvmB2B.Api.Data;

public static class DatabaseInitializer
{
    public static void Initialize(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("PetrolDb");

        if (string.IsNullOrWhiteSpace(connectionString))
        {
            throw new Exception("ConnectionStrings:PetrolDb bulunamadı.");
        }

        InitializeOnConnectionString(configuration, connectionString);
    }

    public static void InitializeForDatabase(
        IConfiguration configuration,
        string databaseName)
    {
        var connectionString = BuildConnectionStringForDatabase(configuration, databaseName);
        InitializeOnConnectionString(configuration, connectionString);
    }

    public static string BuildConnectionStringForDatabase(
        IConfiguration configuration,
        string databaseName)
    {
        if (!IsSafeDatabaseName(databaseName))
            throw new Exception($"Geçersiz veritabanı adı: {databaseName}");

        var baseConnectionString = configuration.GetConnectionString("PetrolDb");

        if (string.IsNullOrWhiteSpace(baseConnectionString))
            throw new Exception("ConnectionStrings:PetrolDb bulunamadı.");

        var builder = new SqlConnectionStringBuilder(baseConnectionString)
        {
            InitialCatalog = databaseName
        };

        return builder.ConnectionString;
    }

    public static string GetCurrentDatabaseName(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("PetrolDb");

        if (string.IsNullOrWhiteSpace(connectionString))
            throw new Exception("ConnectionStrings:PetrolDb bulunamadı.");

        var builder = new SqlConnectionStringBuilder(connectionString);

        return builder.InitialCatalog;
    }

    private static bool IsSafeDatabaseName(string databaseName)
    {
        if (string.IsNullOrWhiteSpace(databaseName))
            return false;

        return System.Text.RegularExpressions.Regex.IsMatch(
            databaseName,
            @"^[A-Za-z0-9_]+$"
        );
    }

    private static void InitializeOnConnectionString(
        IConfiguration configuration,
        string connectionString)
    {
        using var connection = new SqlConnection(connectionString);
        connection.Open();

        EnsurePetrolCariSourcesExist(connection);

        var needsMigration = CheckNeedsMigration(connection);

        if (needsMigration)
        {
            EnsureCanMigrate(connection);
            ExecuteNonQuery(connection, SchemaSql);
        }

        EnsureCanMigrate(connection);

        ExecuteNonQuery(connection, DatabaseManagementSchemaSql);
        ExecuteSqlScript(connection, DatabaseMigrationProcedureSql);

        SeedOrUpdateDefaultKuveytTurkPosAccount(connection);

        GrantPermissionsToConfiguredDbUserIfExists(connection, connectionString);
        SeedDefaultAdminUser(connection);
    }

    private static void EnsurePetrolCariSourcesExist(SqlConnection connection)
    {
        var sql = @"
IF OBJECT_ID('dbo.Cari_Kart_Listesi') IS NULL
BEGIN
    THROW 51000, 'dbo.Cari_Kart_Listesi bulunamadı. B2B cari listeleme ve cari kullanıcı oluşturma işlemleri bu tablo/view üzerinden çalışacak.', 1;
END;

DECLARE @CariKartListesiObjectId INT = OBJECT_ID('dbo.Cari_Kart_Listesi');

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = @CariKartListesiObjectId AND name = 'id')
    THROW 51001, 'dbo.Cari_Kart_Listesi içinde id kolonu bulunamadı.', 1;

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = @CariKartListesiObjectId AND name = 'kod')
    THROW 51002, 'dbo.Cari_Kart_Listesi içinde kod kolonu bulunamadı.', 1;

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = @CariKartListesiObjectId AND name = 'ad')
    THROW 51003, 'dbo.Cari_Kart_Listesi içinde ad kolonu bulunamadı.', 1;

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = @CariKartListesiObjectId AND name = 'soyad')
    THROW 51004, 'dbo.Cari_Kart_Listesi içinde soyad kolonu bulunamadı.', 1;

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = @CariKartListesiObjectId AND name = 'unvan')
    THROW 51005, 'dbo.Cari_Kart_Listesi içinde unvan kolonu bulunamadı.', 1;

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = @CariKartListesiObjectId AND name = 'tel')
    THROW 51006, 'dbo.Cari_Kart_Listesi içinde tel kolonu bulunamadı.', 1;

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = @CariKartListesiObjectId AND name = 'cep')
    THROW 51007, 'dbo.Cari_Kart_Listesi içinde cep kolonu bulunamadı.', 1;

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = @CariKartListesiObjectId AND name = 'mail')
    THROW 51008, 'dbo.Cari_Kart_Listesi içinde mail kolonu bulunamadı.', 1;

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = @CariKartListesiObjectId AND name = 'drm')
    THROW 51009, 'dbo.Cari_Kart_Listesi içinde drm kolonu bulunamadı.', 1;

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = @CariKartListesiObjectId AND name = 'sil')
    THROW 51010, 'dbo.Cari_Kart_Listesi içinde sil kolonu bulunamadı.', 1;

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = @CariKartListesiObjectId AND name = 'top_bakiye')
    THROW 51011, 'dbo.Cari_Kart_Listesi içinde top_bakiye kolonu bulunamadı.', 1;

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = @CariKartListesiObjectId AND name = 'car_bakiye')
    THROW 51012, 'dbo.Cari_Kart_Listesi içinde car_bakiye kolonu bulunamadı.', 1;

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = @CariKartListesiObjectId AND name = 'brc_bakiye')
    THROW 51013, 'dbo.Cari_Kart_Listesi içinde brc_bakiye kolonu bulunamadı.', 1;

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = @CariKartListesiObjectId AND name = 'alc_bakiye')
    THROW 51014, 'dbo.Cari_Kart_Listesi içinde alc_bakiye kolonu bulunamadı.', 1;

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = @CariKartListesiObjectId AND name = 'sonhrk_tarih')
    THROW 51015, 'dbo.Cari_Kart_Listesi içinde sonhrk_tarih kolonu bulunamadı.', 1;

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = @CariKartListesiObjectId AND name = 'firmano')
    THROW 51016, 'dbo.Cari_Kart_Listesi içinde firmano kolonu bulunamadı.', 1;


/* ---------------------------------------------------------- */
/* carikart ana tablo kontrolü */
/* ---------------------------------------------------------- */

IF OBJECT_ID('dbo.carikart', 'U') IS NULL
BEGIN
    THROW 51100, 'dbo.carikart bulunamadı. B2B DB geçiş karşılaştırması için bu tablo gereklidir.', 1;
END;

DECLARE @CariKartObjectId INT = OBJECT_ID('dbo.carikart');

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = @CariKartObjectId AND name = 'kod')
    THROW 51101, 'dbo.carikart içinde kod kolonu bulunamadı.', 1;

IF NOT EXISTS (SELECT 1 FROM sys.columns WHERE object_id = @CariKartObjectId AND name = 'sil')
    THROW 51102, 'dbo.carikart içinde sil kolonu bulunamadı.', 1;
";

        ExecuteNonQuery(connection, sql);
    }
    private static bool CheckNeedsMigration(SqlConnection connection)
    {
        var sql = @"
DECLARE @NeedsMigration BIT = 0;

/* ---------------------------------------------------------- */
/* TABLO VARLIK KONTROLLERİ */
/* ---------------------------------------------------------- */

IF OBJECT_ID('dbo.B2B_Users', 'U') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PosAccounts', 'U') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PosInstallmentRules', 'U') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_Payments', 'U') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PaymentLogs', 'U') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_CariLocks', 'U') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_InstallmentAllowedBins', 'U') IS NULL
    SET @NeedsMigration = 1;

/* ---------------------------------------------------------- */
/* B2B_Users KOLON / INDEX KONTROLLERİ */
/* ---------------------------------------------------------- */

IF OBJECT_ID('dbo.B2B_Users', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_Users', 'MustChangePassword') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_Users', 'U') IS NOT NULL
   AND NOT EXISTS (
        SELECT 1
        FROM sys.indexes
        WHERE name = 'UX_B2B_Users_Username'
          AND object_id = OBJECT_ID('dbo.B2B_Users')
   )
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_Users', 'U') IS NOT NULL
   AND NOT EXISTS (
        SELECT 1
        FROM sys.indexes
        WHERE name = 'IX_B2B_Users_UserType_CariKod'
          AND object_id = OBJECT_ID('dbo.B2B_Users')
   )
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_Users', 'U') IS NOT NULL
   AND NOT EXISTS (
        SELECT 1
        FROM sys.indexes
        WHERE name = 'UX_B2B_Users_Active_CariKod'
          AND object_id = OBJECT_ID('dbo.B2B_Users')
   )
    SET @NeedsMigration = 1;

/* ---------------------------------------------------------- */
/* B2B_PosAccounts KOLON / INDEX KONTROLLERİ */
/* ---------------------------------------------------------- */

IF OBJECT_ID('dbo.B2B_PosAccounts', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_PosAccounts', 'MerchantUser') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PosAccounts', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_PosAccounts', 'MerchantPasswordEncrypted') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PosAccounts', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_PosAccounts', 'MerchantStoreKeyEncrypted') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PosAccounts', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_PosAccounts', 'ReturnUrl') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PosAccounts', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_PosAccounts', 'UpdatedAt') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PosAccounts', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_PosAccounts', 'AccountingCardType') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PosAccounts', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_PosAccounts', 'AccountingCardCode') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PosAccounts', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_PosAccounts', 'AccountingDescription') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PosAccounts', 'U') IS NOT NULL
   AND NOT EXISTS (
        SELECT 1
        FROM sys.indexes
        WHERE name = 'IX_B2B_PosAccounts_BankCode'
          AND object_id = OBJECT_ID('dbo.B2B_PosAccounts')
   )
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PosAccounts', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_PosAccounts', 'CustomerId') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PosAccounts', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_PosAccounts', 'PayGateUrl') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PosAccounts', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_PosAccounts', 'ProvisionGateUrl') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PosAccounts', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_PosAccounts', 'ApiVersion') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PosAccounts', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_PosAccounts', 'CurrencyCode') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PosAccounts', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_PosAccounts', 'TransactionSecurity') IS NULL
    SET @NeedsMigration = 1;

/* ---------------------------------------------------------- */
/* B2B_PosInstallmentRules KOLON / FK / INDEX KONTROLLERİ */
/* ---------------------------------------------------------- */

IF OBJECT_ID('dbo.B2B_PosInstallmentRules', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_PosInstallmentRules', 'MinAmount') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PosInstallmentRules', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_PosInstallmentRules', 'MaxAmount') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PosInstallmentRules', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_PosInstallmentRules', 'CommissionRate') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PosInstallmentRules', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_PosInstallmentRules', 'UpdatedAt') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PosInstallmentRules', 'U') IS NOT NULL
   AND OBJECT_ID('dbo.B2B_PosAccounts', 'U') IS NOT NULL
   AND OBJECT_ID('dbo.FK_B2B_PosInstallmentRules_PosAccounts', 'F') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PosInstallmentRules', 'U') IS NOT NULL
   AND NOT EXISTS (
        SELECT 1
        FROM sys.indexes
        WHERE name = 'IX_B2B_PosInstallmentRules_PosAccountId'
          AND object_id = OBJECT_ID('dbo.B2B_PosInstallmentRules')
   )
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PosInstallmentRules', 'U') IS NOT NULL
   AND NOT EXISTS (
        SELECT 1
        FROM sys.indexes
        WHERE name = 'IX_B2B_PosInstallmentRules_PosAccountId_Installment'
          AND object_id = OBJECT_ID('dbo.B2B_PosInstallmentRules')
   )
    SET @NeedsMigration = 1;

/* ---------------------------------------------------------- */
/* B2B_Payments KOLON / FK / INDEX KONTROLLERİ */
/* ---------------------------------------------------------- */

IF OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_Payments', 'PosAccountId') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_Payments', 'Installment') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_Payments', 'CardBin') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_Payments', 'CardLast4') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_Payments', 'MaskedCardNo') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_Payments', 'RedirectType') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_Payments', 'RedirectData') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_Payments', 'BankResponseCode') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_Payments', 'BankResponseMessage') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_Payments', 'AuthCode') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_Payments', 'HostRefNo') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_Payments', 'PaidAt') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_Payments', 'CallbackReceivedAt') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_Payments', 'CreatedByUserId') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_Payments', 'CreatedByUsername') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_Payments', 'CreatedByUserType') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
   AND OBJECT_ID('dbo.B2B_PosAccounts', 'U') IS NOT NULL
   AND OBJECT_ID('dbo.FK_B2B_Payments_PosAccounts', 'F') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
   AND NOT EXISTS (
        SELECT 1
        FROM sys.indexes
        WHERE name = 'UX_B2B_Payments_PaymentNo'
          AND object_id = OBJECT_ID('dbo.B2B_Payments')
   )
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
   AND NOT EXISTS (
        SELECT 1
        FROM sys.indexes
        WHERE name = 'UX_B2B_Payments_OrderNumber'
          AND object_id = OBJECT_ID('dbo.B2B_Payments')
   )
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
   AND NOT EXISTS (
        SELECT 1
        FROM sys.indexes
        WHERE name = 'IX_B2B_Payments_CariKod'
          AND object_id = OBJECT_ID('dbo.B2B_Payments')
   )
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
   AND NOT EXISTS (
        SELECT 1
        FROM sys.indexes
        WHERE name = 'IX_B2B_Payments_CreatedAt'
          AND object_id = OBJECT_ID('dbo.B2B_Payments')
   )
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
   AND NOT EXISTS (
        SELECT 1
        FROM sys.indexes
        WHERE name = 'IX_B2B_Payments_Status'
          AND object_id = OBJECT_ID('dbo.B2B_Payments')
   )
    SET @NeedsMigration = 1;

/* ---------------------------------------------------------- */
/* B2B_PaymentLogs KOLON / FK / INDEX KONTROLLERİ */
/* ---------------------------------------------------------- */

IF OBJECT_ID('dbo.B2B_PaymentLogs', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_PaymentLogs', 'LogType') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PaymentLogs', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_PaymentLogs', 'IsSuccess') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PaymentLogs', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_PaymentLogs', 'ErrorCode') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PaymentLogs', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_PaymentLogs', 'ErrorMessage') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PaymentLogs', 'U') IS NOT NULL
   AND OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
   AND OBJECT_ID('dbo.FK_B2B_PaymentLogs_Payments', 'F') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PaymentLogs', 'U') IS NOT NULL
   AND NOT EXISTS (
        SELECT 1
        FROM sys.indexes
        WHERE name = 'IX_B2B_PaymentLogs_PaymentId'
          AND object_id = OBJECT_ID('dbo.B2B_PaymentLogs')
   )
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_PaymentLogs', 'U') IS NOT NULL
   AND NOT EXISTS (
        SELECT 1
        FROM sys.indexes
        WHERE name = 'IX_B2B_PaymentLogs_CreatedAt'
          AND object_id = OBJECT_ID('dbo.B2B_PaymentLogs')
   )
    SET @NeedsMigration = 1;

/* ---------------------------------------------------------- */
/* B2B_CariLocks KOLON / INDEX KONTROLLERİ */
/* ---------------------------------------------------------- */

IF OBJECT_ID('dbo.B2B_CariLocks', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_CariLocks', 'CariKod') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_CariLocks', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_CariLocks', 'IsLocked') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_CariLocks', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_CariLocks', 'Reason') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_CariLocks', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_CariLocks', 'LockedByUserId') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_CariLocks', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_CariLocks', 'LockedAt') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_CariLocks', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_CariLocks', 'UnlockedByUserId') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_CariLocks', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_CariLocks', 'UnlockedAt') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_CariLocks', 'U') IS NOT NULL
   AND NOT EXISTS (
        SELECT 1
        FROM sys.indexes
        WHERE name = 'UX_B2B_CariLocks_CariKod'
          AND object_id = OBJECT_ID('dbo.B2B_CariLocks')
   )
    SET @NeedsMigration = 1;

    IF OBJECT_ID('dbo.B2B_InstallmentAllowedBins', 'U') IS NULL
    SET @NeedsMigration = 1;

/* ---------------------------------------------------------- */
/* B2B_InstallmentAllowedBins KOLON / INDEX KONTROLLERİ */
/* ---------------------------------------------------------- */

IF OBJECT_ID('dbo.B2B_InstallmentAllowedBins', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_InstallmentAllowedBins', 'BankCode') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_InstallmentAllowedBins', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_InstallmentAllowedBins', 'BankName') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_InstallmentAllowedBins', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_InstallmentAllowedBins', 'BinPrefix') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_InstallmentAllowedBins', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_InstallmentAllowedBins', 'IsActive') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_InstallmentAllowedBins', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_InstallmentAllowedBins', 'Note') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_InstallmentAllowedBins', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_InstallmentAllowedBins', 'CreatedAt') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_InstallmentAllowedBins', 'U') IS NOT NULL
   AND COL_LENGTH('dbo.B2B_InstallmentAllowedBins', 'UpdatedAt') IS NULL
    SET @NeedsMigration = 1;

IF OBJECT_ID('dbo.B2B_InstallmentAllowedBins', 'U') IS NOT NULL
   AND NOT EXISTS (
        SELECT 1
        FROM sys.indexes
        WHERE name = 'UX_B2B_InstallmentAllowedBins_BankCode_BinPrefix'
          AND object_id = OBJECT_ID('dbo.B2B_InstallmentAllowedBins')
   )
    SET @NeedsMigration = 1;

SELECT @NeedsMigration;
";

        using var command = new SqlCommand(sql, connection);
        var result = command.ExecuteScalar();

        return Convert.ToInt32(result) == 1;
    }

    private static void EnsureCanMigrate(SqlConnection connection)
    {
        var sql = @"
SELECT 
    SYSTEM_USER AS ServerLogin,
    CURRENT_USER AS DatabaseUser,
    DB_NAME() AS DatabaseName,
    ISNULL(IS_SRVROLEMEMBER('sysadmin'), 0) AS IsSysAdmin,
    ISNULL(IS_MEMBER('db_owner'), 0) AS IsDbOwner,
    ISNULL(HAS_PERMS_BY_NAME(DB_NAME(), 'DATABASE', 'CREATE TABLE'), 0) AS CanCreateTable,
    ISNULL(HAS_PERMS_BY_NAME('dbo', 'SCHEMA', 'ALTER'), 0) AS CanAlterDboSchema;
";

        using var command = new SqlCommand(sql, connection);
        using var reader = command.ExecuteReader();

        if (!reader.Read())
        {
            throw new Exception("SQL yetki kontrolü yapılamadı.");
        }

        var serverLogin = reader["ServerLogin"]?.ToString();
        var databaseUser = reader["DatabaseUser"]?.ToString();
        var databaseName = reader["DatabaseName"]?.ToString();

        var isSysAdmin = Convert.ToInt32(reader["IsSysAdmin"]);
        var isDbOwner = Convert.ToInt32(reader["IsDbOwner"]);
        var canCreateTable = Convert.ToInt32(reader["CanCreateTable"]);
        var canAlterDboSchema = Convert.ToInt32(reader["CanAlterDboSchema"]);

        var hasPermission =
            isSysAdmin == 1 ||
            isDbOwner == 1 ||
            (canCreateTable == 1 && canAlterDboSchema == 1);

        if (!hasPermission)
        {
            throw new Exception($@"
DatabaseInitializer tablo/kolon/index oluşturmak istiyor ama SQL kullanıcısının yetkisi yetersiz.

Bağlanan kullanıcı:
ServerLogin  : {serverLogin}
DatabaseUser : {databaseUser}
Database     : {databaseName}

Gerekli yetki:
- sysadmin
veya
- db_owner
veya
- dbo şeması üzerinde tablo oluşturma/değiştirme yetkisi

Server için önerilen connection string:
Server=.\PETRONET;Database=PETROL_2021;Integrated Security=True;TrustServerCertificate=True;Encrypt=False;
");
        }
    }

    private static void SeedOrUpdateDefaultKuveytTurkPosAccount(SqlConnection connection)
    {
        var sql = @"
IF OBJECT_ID('dbo.B2B_PosAccounts', 'U') IS NOT NULL
BEGIN
    IF EXISTS (
        SELECT 1
        FROM dbo.B2B_PosAccounts
        WHERE BankCode = N'KuveytTurk'
    )
    BEGIN
        UPDATE dbo.B2B_PosAccounts
        SET
            BankName = N'Kuveyt Türk Sanal POS',

            CustomerId = CASE
                WHEN CustomerId IS NULL OR LTRIM(RTRIM(CustomerId)) = N''
                    THEN N'94065771'
                ELSE CustomerId
            END,

            MerchantId = CASE
                WHEN MerchantId IS NULL OR LTRIM(RTRIM(MerchantId)) = N'' OR MerchantId = N'57902'
                    THEN N'765890'
                ELSE MerchantId
            END,

            MerchantUser = CASE
                WHEN MerchantUser IS NULL OR LTRIM(RTRIM(MerchantUser)) = N'' OR MerchantUser = N'TEPKVT2021'
                    THEN N'VP764972'
                ELSE MerchantUser
            END,

            /*
                Şifreyi burada seed etmiyoruz.
                Canlı API şifresi admin panelden girilecek ve backend encrypt ederek kaydedecek.
                Mevcut encrypted şifre varsa korunur.
            */
            MerchantPasswordEncrypted = MerchantPasswordEncrypted,

            /*
                Kuveyt Türk için StoreKey kullanılmıyor.
                Diğer bankalar için alan kalabilir.
                Mevcut değer varsa korunur.
            */
            MerchantStoreKeyEncrypted = MerchantStoreKeyEncrypted,

            TestPlatform = 0,
            IsActive = 1,

            ReturnUrl = N'https://cari.avmakaryakit.com/api/payments/3d-callback',

            PayGateUrl = CASE
                WHEN PayGateUrl IS NULL OR LTRIM(RTRIM(PayGateUrl)) = N''
                    THEN N'https://sanalpos.kuveytturk.com.tr/ServiceGateWay/Home/ThreeDModelPayGate'
                ELSE PayGateUrl
            END,

            ProvisionGateUrl = CASE
                WHEN ProvisionGateUrl IS NULL OR LTRIM(RTRIM(ProvisionGateUrl)) = N''
                    THEN N'https://sanalpos.kuveytturk.com.tr/ServiceGateWay/Home/ThreeDModelProvisionGate'
                ELSE ProvisionGateUrl
            END,

            ApiVersion = CASE
                WHEN ApiVersion IS NULL OR LTRIM(RTRIM(ApiVersion)) = N''
                    THEN N'TDV2.0.0'
                ELSE ApiVersion
            END,

            CurrencyCode = CASE
                WHEN CurrencyCode IS NULL OR LTRIM(RTRIM(CurrencyCode)) = N''
                    THEN N'0949'
                ELSE CurrencyCode
            END,

            TransactionSecurity = CASE
                WHEN TransactionSecurity IS NULL
                    THEN 3
                ELSE TransactionSecurity
            END,

            AccountingCardType = CASE
                WHEN AccountingCardType IS NULL OR LTRIM(RTRIM(AccountingCardType)) = N''
                    THEN N'istkart'
                ELSE AccountingCardType
            END,

            AccountingCardCode = CASE
                WHEN AccountingCardCode IS NULL OR LTRIM(RTRIM(AccountingCardCode)) = N''
                    THEN N'KART0012'
                ELSE AccountingCardCode
            END,

            AccountingDescription = CASE
                WHEN AccountingDescription IS NULL OR LTRIM(RTRIM(AccountingDescription)) = N''
                    THEN N'K.KARTI'
                ELSE AccountingDescription
            END,

            UpdatedAt = GETDATE()
        WHERE BankCode = N'KuveytTurk';
    END
    ELSE
    BEGIN
        INSERT INTO dbo.B2B_PosAccounts
        (
            BankCode,
            BankName,
            CustomerId,
            MerchantId,
            MerchantUser,
            MerchantPasswordEncrypted,
            MerchantStoreKeyEncrypted,
            TestPlatform,
            IsActive,
            ReturnUrl,
            PayGateUrl,
            ProvisionGateUrl,
            ApiVersion,
            CurrencyCode,
            TransactionSecurity,
            AccountingCardType,
            AccountingCardCode,
            AccountingDescription,
            CreatedAt,
            UpdatedAt
        )
        VALUES
        (
            N'KuveytTurk',
            N'Kuveyt Türk Sanal POS',
            N'94065771',
            N'765890',
            N'VP764972',
            NULL,
            NULL,
            0,
            1,
            N'https://cari.avmakaryakit.com/api/payments/3d-callback',
            N'https://sanalpos.kuveytturk.com.tr/ServiceGateWay/Home/ThreeDModelPayGate',
            N'https://sanalpos.kuveytturk.com.tr/ServiceGateWay/Home/ThreeDModelProvisionGate',
            N'TDV2.0.0',
            N'0949',
            3,
            N'istkart',
            N'KART0012',
            N'K.KARTI',
            GETDATE(),
            GETDATE()
        );
    END
END;
";

        ExecuteNonQuery(connection, sql);
    }

    private static void GrantPermissionsToConfiguredDbUserIfExists(
    SqlConnection connection,
    string connectionString)
    {
        var principalName = ResolveConfiguredDbPrincipalName(connection, connectionString);

        if (string.IsNullOrWhiteSpace(principalName))
            return;

        var sql = @"
DECLARE @DbPrincipal SYSNAME = @ConfiguredPrincipal;

IF DATABASE_PRINCIPAL_ID(@DbPrincipal) IS NOT NULL
BEGIN
    IF IS_MEMBER('db_owner') = 1 OR IS_SRVROLEMEMBER('sysadmin') = 1
    BEGIN
        DECLARE @SafePrincipal NVARCHAR(300) = QUOTENAME(@DbPrincipal);
        DECLARE @GrantSql NVARCHAR(MAX);

        IF OBJECT_ID('dbo.B2B_Users', 'U') IS NOT NULL
        BEGIN
            SET @GrantSql = N'GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.B2B_Users TO ' + @SafePrincipal;
            EXEC sp_executesql @GrantSql;
        END;

        IF OBJECT_ID('dbo.B2B_PosAccounts', 'U') IS NOT NULL
        BEGIN
            SET @GrantSql = N'GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.B2B_PosAccounts TO ' + @SafePrincipal;
            EXEC sp_executesql @GrantSql;
        END;

        IF OBJECT_ID('dbo.B2B_PosInstallmentRules', 'U') IS NOT NULL
        BEGIN
            SET @GrantSql = N'GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.B2B_PosInstallmentRules TO ' + @SafePrincipal;
            EXEC sp_executesql @GrantSql;
        END;

        IF OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
        BEGIN
            SET @GrantSql = N'GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.B2B_Payments TO ' + @SafePrincipal;
            EXEC sp_executesql @GrantSql;
        END;

        IF OBJECT_ID('dbo.B2B_PaymentLogs', 'U') IS NOT NULL
        BEGIN
            SET @GrantSql = N'GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.B2B_PaymentLogs TO ' + @SafePrincipal;
            EXEC sp_executesql @GrantSql;
        END;

        IF OBJECT_ID('dbo.B2B_CariLocks', 'U') IS NOT NULL
        BEGIN
            SET @GrantSql = N'GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.B2B_CariLocks TO ' + @SafePrincipal;
            EXEC sp_executesql @GrantSql;
        END;

        IF OBJECT_ID('dbo.B2B_InstallmentAllowedBins', 'U') IS NOT NULL
        BEGIN
            SET @GrantSql = N'GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.B2B_InstallmentAllowedBins TO ' + @SafePrincipal;
            EXEC sp_executesql @GrantSql;
        END;

        /*
            Cari_Kart_Listesi ana PETROL tarafındaki cari liste objesidir.
            B2B bu objeden sadece okuma yapmalı.
        */
        IF OBJECT_ID('dbo.Cari_Kart_Listesi') IS NOT NULL
        BEGIN
            SET @GrantSql = N'GRANT SELECT ON OBJECT::dbo.Cari_Kart_Listesi TO ' + @SafePrincipal;
            EXEC sp_executesql @GrantSql;
        END;

        IF OBJECT_ID('dbo.carikart', 'U') IS NOT NULL
        BEGIN
            SET @GrantSql = N'GRANT SELECT ON dbo.carikart TO ' + @SafePrincipal;
            EXEC sp_executesql @GrantSql;
        END;

        /*
            Paid ödeme sonrası carihrk içine IKK ödeme hareketi yazacağız.
            Bu yüzden SELECT + INSERT gerekli.
        */
        IF OBJECT_ID('dbo.carihrk', 'U') IS NOT NULL
        BEGIN
            SET @GrantSql = N'GRANT SELECT, INSERT ON dbo.carihrk TO ' + @SafePrincipal;
            EXEC sp_executesql @GrantSql;
        END;
    END;
END;
";

        ExecuteNonQuery(
            connection,
            sql,
            new SqlParameter("@ConfiguredPrincipal", principalName)
        );
    }

    private static string? ResolveConfiguredDbPrincipalName(
    SqlConnection connection,
    string connectionString)
    {
        var builder = new SqlConnectionStringBuilder(connectionString);

        if (!builder.IntegratedSecurity &&
            !string.IsNullOrWhiteSpace(builder.UserID))
        {
            return builder.UserID.Trim();
        }

        using var command = new SqlCommand("SELECT USER_NAME();", connection);
        var result = command.ExecuteScalar()?.ToString();

        if (string.IsNullOrWhiteSpace(result))
            return null;

        result = result.Trim();

        // dbo zaten db_owner bağlamı demek. Ona ayrıca GRANT vermeye gerek yok.
        if (result.Equals("dbo", StringComparison.OrdinalIgnoreCase))
            return null;

        return result;
    }

    private static void SeedDefaultAdminUser(SqlConnection connection)
    {
        var sql = @"
IF OBJECT_ID('dbo.B2B_Users', 'U') IS NOT NULL
   AND NOT EXISTS (
        SELECT 1
        FROM dbo.B2B_Users
        WHERE Username = N'ADMIN'
   )
BEGIN
    INSERT INTO dbo.B2B_Users
    (
        UserType,
        Username,
        PasswordHash,
        CariKod,
        IsActive,
        MustChangePassword,
        CreatedAt
    )
    VALUES
    (
        N'Admin',
        N'ADMIN',
        N'$2a$12$xUUgj3PtjQ2Hag1pZrOqTemxm.EeiE94MQjeLGqGIjUUigGxw27AG',
        NULL,
        1,
        0,
        GETDATE()
    );
END;
";

        ExecuteNonQuery(connection, sql);
    }

    private static void ExecuteSqlScript(SqlConnection connection, string sqlScript)
    {
        var batches = System.Text.RegularExpressions.Regex.Split(
            sqlScript,
            @"^\s*GO\s*;?\s*$",
            System.Text.RegularExpressions.RegexOptions.Multiline |
            System.Text.RegularExpressions.RegexOptions.IgnoreCase
        );

        foreach (var batch in batches)
        {
            if (string.IsNullOrWhiteSpace(batch))
                continue;

            using var command = new SqlCommand(batch, connection);
            command.CommandTimeout = 120;
            command.ExecuteNonQuery();
        }
    }

    private static void ExecuteNonQuery(SqlConnection connection, string sql)
    {
        using var command = new SqlCommand(sql, connection);
        command.CommandTimeout = 120;
        command.ExecuteNonQuery();
    }

    private static void ExecuteNonQuery(
    SqlConnection connection,
    string sql,
    params SqlParameter[] parameters)
    {
        using var command = new SqlCommand(sql, connection);
        command.CommandTimeout = 120;

        if (parameters.Length > 0)
            command.Parameters.AddRange(parameters);

        command.ExecuteNonQuery();
    }

    private const string SchemaSql = @"
/* ---------------------------------------------------------- */
/* KULLANICILAR */
/* ---------------------------------------------------------- */

IF NOT EXISTS (
    SELECT 1
    FROM sys.tables
    WHERE name = 'B2B_Users' AND schema_id = SCHEMA_ID('dbo')
)
BEGIN
    CREATE TABLE dbo.B2B_Users (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        UserType NVARCHAR(20) NOT NULL,
        Username NVARCHAR(100) NOT NULL,
        PasswordHash NVARCHAR(500) NOT NULL,
        CariKod NVARCHAR(50) NULL,
        IsActive BIT NOT NULL CONSTRAINT DF_B2B_Users_IsActive DEFAULT 1,
        MustChangePassword BIT NOT NULL CONSTRAINT DF_B2B_Users_MustChangePassword DEFAULT 0,
        CreatedAt DATETIME NOT NULL CONSTRAINT DF_B2B_Users_CreatedAt DEFAULT GETDATE()
    );
END;

IF COL_LENGTH('dbo.B2B_Users', 'MustChangePassword') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_Users
    ADD MustChangePassword BIT NOT NULL
        CONSTRAINT DF_B2B_Users_MustChangePassword_Added DEFAULT 0;
END;

IF NOT EXISTS (
    SELECT 1
    FROM sys.indexes
    WHERE name = 'UX_B2B_Users_Username'
      AND object_id = OBJECT_ID('dbo.B2B_Users')
)
BEGIN
    CREATE UNIQUE INDEX UX_B2B_Users_Username
    ON dbo.B2B_Users(Username);
END;

IF NOT EXISTS (
    SELECT 1
    FROM sys.indexes
    WHERE name = 'IX_B2B_Users_UserType_CariKod'
      AND object_id = OBJECT_ID('dbo.B2B_Users')
)
BEGIN
    CREATE INDEX IX_B2B_Users_UserType_CariKod
    ON dbo.B2B_Users(UserType, CariKod);
END;

IF NOT EXISTS (
    SELECT 1
    FROM sys.indexes
    WHERE name = 'UX_B2B_Users_Active_CariKod'
      AND object_id = OBJECT_ID('dbo.B2B_Users')
)
BEGIN
    IF EXISTS (
        SELECT 1
        FROM dbo.B2B_Users
        WHERE 
            CariKod IS NOT NULL
            AND LTRIM(RTRIM(CariKod)) <> N''
            AND IsActive = 1
        GROUP BY CariKod
        HAVING COUNT(*) > 1
    )
    BEGIN
        DECLARE @DuplicateCariKod NVARCHAR(50);

        SELECT TOP 1 @DuplicateCariKod = CariKod
        FROM dbo.B2B_Users
        WHERE 
            CariKod IS NOT NULL
            AND LTRIM(RTRIM(CariKod)) <> N''
            AND IsActive = 1
        GROUP BY CariKod
        HAVING COUNT(*) > 1;

        DECLARE @DuplicateMessage NVARCHAR(500) =
            N'B2B_Users içinde aynı CariKod için birden fazla aktif kullanıcı var. Önce duplicate kayıtları pasife alın. CariKod: ' 
            + ISNULL(@DuplicateCariKod, N'-');

        THROW 51201, @DuplicateMessage, 1;
    END;

    CREATE UNIQUE INDEX UX_B2B_Users_Active_CariKod
    ON dbo.B2B_Users(CariKod)
    WHERE 
        CariKod IS NOT NULL
        AND CariKod <> N''
        AND IsActive = 1;
END;

/* ---------------------------------------------------------- */
/* POS HESAPLARI */
/* ---------------------------------------------------------- */

IF NOT EXISTS (
    SELECT 1
    FROM sys.tables
    WHERE name = 'B2B_PosAccounts' AND schema_id = SCHEMA_ID('dbo')
)
BEGIN
    CREATE TABLE dbo.B2B_PosAccounts (
        Id INT IDENTITY(1,1) PRIMARY KEY,

        BankCode NVARCHAR(50) NOT NULL,
        BankName NVARCHAR(100) NOT NULL,

        MerchantId NVARCHAR(250) NOT NULL,
        MerchantUser NVARCHAR(250) NULL,
        CustomerId NVARCHAR(100) NULL,
        MerchantPasswordEncrypted NVARCHAR(MAX) NULL,
        MerchantStoreKeyEncrypted NVARCHAR(MAX) NULL,

        TestPlatform BIT NOT NULL CONSTRAINT DF_B2B_PosAccounts_TestPlatform DEFAULT 0,
        IsActive BIT NOT NULL CONSTRAINT DF_B2B_PosAccounts_IsActive DEFAULT 1,

        ReturnUrl NVARCHAR(500) NULL,
        PayGateUrl NVARCHAR(500) NULL,
        ProvisionGateUrl NVARCHAR(500) NULL,
        ApiVersion NVARCHAR(50) NULL,
        CurrencyCode NVARCHAR(10) NULL,
        TransactionSecurity INT NULL,

        AccountingCardType NVARCHAR(50) NULL,
        AccountingCardCode NVARCHAR(50) NULL,
        AccountingDescription NVARCHAR(200) NULL,

        CreatedAt DATETIME NOT NULL CONSTRAINT DF_B2B_PosAccounts_CreatedAt DEFAULT GETDATE(),
        UpdatedAt DATETIME NULL
    );
END;

IF COL_LENGTH('dbo.B2B_PosAccounts', 'MerchantUser') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_PosAccounts ADD MerchantUser NVARCHAR(250) NULL;
END;

IF COL_LENGTH('dbo.B2B_PosAccounts', 'MerchantPasswordEncrypted') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_PosAccounts ADD MerchantPasswordEncrypted NVARCHAR(MAX) NULL;
END;

IF COL_LENGTH('dbo.B2B_PosAccounts', 'MerchantStoreKeyEncrypted') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_PosAccounts ADD MerchantStoreKeyEncrypted NVARCHAR(MAX) NULL;
END;

IF COL_LENGTH('dbo.B2B_PosAccounts', 'ReturnUrl') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_PosAccounts ADD ReturnUrl NVARCHAR(500) NULL;
END;

IF COL_LENGTH('dbo.B2B_PosAccounts', 'UpdatedAt') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_PosAccounts ADD UpdatedAt DATETIME NULL;
END;

IF COL_LENGTH('dbo.B2B_PosAccounts', 'AccountingCardType') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_PosAccounts ADD AccountingCardType NVARCHAR(50) NULL;
END;

IF COL_LENGTH('dbo.B2B_PosAccounts', 'AccountingCardCode') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_PosAccounts ADD AccountingCardCode NVARCHAR(50) NULL;
END;

IF COL_LENGTH('dbo.B2B_PosAccounts', 'AccountingDescription') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_PosAccounts ADD AccountingDescription NVARCHAR(200) NULL;
END;

IF COL_LENGTH('dbo.B2B_PosAccounts', 'CustomerId') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_PosAccounts ADD CustomerId NVARCHAR(100) NULL;
END;

IF COL_LENGTH('dbo.B2B_PosAccounts', 'PayGateUrl') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_PosAccounts ADD PayGateUrl NVARCHAR(500) NULL;
END;

IF COL_LENGTH('dbo.B2B_PosAccounts', 'ProvisionGateUrl') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_PosAccounts ADD ProvisionGateUrl NVARCHAR(500) NULL;
END;

IF COL_LENGTH('dbo.B2B_PosAccounts', 'ApiVersion') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_PosAccounts ADD ApiVersion NVARCHAR(50) NULL;
END;

IF COL_LENGTH('dbo.B2B_PosAccounts', 'CurrencyCode') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_PosAccounts ADD CurrencyCode NVARCHAR(10) NULL;
END;

IF COL_LENGTH('dbo.B2B_PosAccounts', 'TransactionSecurity') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_PosAccounts ADD TransactionSecurity INT NULL;
END;

IF NOT EXISTS (
    SELECT 1
    FROM sys.indexes
    WHERE name = 'IX_B2B_PosAccounts_BankCode'
      AND object_id = OBJECT_ID('dbo.B2B_PosAccounts')
)
BEGIN
    CREATE INDEX IX_B2B_PosAccounts_BankCode
    ON dbo.B2B_PosAccounts(BankCode);
END;

/* ---------------------------------------------------------- */
/* POS TAKSİT KURALLARI */
/* ---------------------------------------------------------- */

IF NOT EXISTS (
    SELECT 1
    FROM sys.tables
    WHERE name = 'B2B_PosInstallmentRules' AND schema_id = SCHEMA_ID('dbo')
)
BEGIN
    CREATE TABLE dbo.B2B_PosInstallmentRules (
        Id INT IDENTITY(1,1) PRIMARY KEY,

        PosAccountId INT NOT NULL,
        Installment INT NOT NULL,

        MinAmount DECIMAL(18,2) NOT NULL CONSTRAINT DF_B2B_PosInstallmentRules_MinAmount DEFAULT 0,
        MaxAmount DECIMAL(18,2) NULL,

        CommissionRate DECIMAL(9,4) NULL,
        IsActive BIT NOT NULL CONSTRAINT DF_B2B_PosInstallmentRules_IsActive DEFAULT 1,

        CreatedAt DATETIME NOT NULL CONSTRAINT DF_B2B_PosInstallmentRules_CreatedAt DEFAULT GETDATE(),
        UpdatedAt DATETIME NULL
    );
END;

IF COL_LENGTH('dbo.B2B_PosInstallmentRules', 'MinAmount') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_PosInstallmentRules
    ADD MinAmount DECIMAL(18,2) NOT NULL
        CONSTRAINT DF_B2B_PosInstallmentRules_MinAmount_Added DEFAULT 0;
END;

IF COL_LENGTH('dbo.B2B_PosInstallmentRules', 'MaxAmount') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_PosInstallmentRules ADD MaxAmount DECIMAL(18,2) NULL;
END;

IF COL_LENGTH('dbo.B2B_PosInstallmentRules', 'CommissionRate') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_PosInstallmentRules ADD CommissionRate DECIMAL(9,4) NULL;
END;

IF COL_LENGTH('dbo.B2B_PosInstallmentRules', 'UpdatedAt') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_PosInstallmentRules ADD UpdatedAt DATETIME NULL;
END;

IF OBJECT_ID('dbo.FK_B2B_PosInstallmentRules_PosAccounts', 'F') IS NULL
   AND OBJECT_ID('dbo.B2B_PosInstallmentRules', 'U') IS NOT NULL
   AND OBJECT_ID('dbo.B2B_PosAccounts', 'U') IS NOT NULL
   AND NOT EXISTS (
        SELECT 1
        FROM dbo.B2B_PosInstallmentRules r
        WHERE NOT EXISTS (
            SELECT 1
            FROM dbo.B2B_PosAccounts p
            WHERE p.Id = r.PosAccountId
        )
   )
BEGIN
    ALTER TABLE dbo.B2B_PosInstallmentRules
    ADD CONSTRAINT FK_B2B_PosInstallmentRules_PosAccounts
        FOREIGN KEY (PosAccountId)
        REFERENCES dbo.B2B_PosAccounts(Id);
END;

IF NOT EXISTS (
    SELECT 1
    FROM sys.indexes
    WHERE name = 'IX_B2B_PosInstallmentRules_PosAccountId'
      AND object_id = OBJECT_ID('dbo.B2B_PosInstallmentRules')
)
BEGIN
    CREATE INDEX IX_B2B_PosInstallmentRules_PosAccountId
    ON dbo.B2B_PosInstallmentRules(PosAccountId);
END;

IF NOT EXISTS (
    SELECT 1
    FROM sys.indexes
    WHERE name = 'IX_B2B_PosInstallmentRules_PosAccountId_Installment'
      AND object_id = OBJECT_ID('dbo.B2B_PosInstallmentRules')
)
BEGIN
    CREATE INDEX IX_B2B_PosInstallmentRules_PosAccountId_Installment
    ON dbo.B2B_PosInstallmentRules(PosAccountId, Installment, IsActive);
END;

/* ---------------------------------------------------------- */
/* CARİ KİLİTLERİ */
/* ---------------------------------------------------------- */

IF NOT EXISTS (
    SELECT 1
    FROM sys.tables
    WHERE name = 'B2B_CariLocks' AND schema_id = SCHEMA_ID('dbo')
)
BEGIN
    CREATE TABLE dbo.B2B_CariLocks (
        Id INT IDENTITY(1,1) PRIMARY KEY,

        CariKod NVARCHAR(50) NOT NULL,

        IsLocked BIT NOT NULL
            CONSTRAINT DF_B2B_CariLocks_IsLocked DEFAULT 1,

        Reason NVARCHAR(500) NULL,

        LockedByUserId INT NULL,
        LockedAt DATETIME NOT NULL
            CONSTRAINT DF_B2B_CariLocks_LockedAt DEFAULT GETDATE(),

        UnlockedByUserId INT NULL,
        UnlockedAt DATETIME NULL
    );
END;

IF COL_LENGTH('dbo.B2B_CariLocks', 'CariKod') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_CariLocks ADD CariKod NVARCHAR(50) NOT NULL
        CONSTRAINT DF_B2B_CariLocks_CariKod_Added DEFAULT '';
END;

IF COL_LENGTH('dbo.B2B_CariLocks', 'IsLocked') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_CariLocks ADD IsLocked BIT NOT NULL
        CONSTRAINT DF_B2B_CariLocks_IsLocked_Added DEFAULT 1;
END;

IF COL_LENGTH('dbo.B2B_CariLocks', 'Reason') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_CariLocks ADD Reason NVARCHAR(500) NULL;
END;

IF COL_LENGTH('dbo.B2B_CariLocks', 'LockedByUserId') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_CariLocks ADD LockedByUserId INT NULL;
END;

IF COL_LENGTH('dbo.B2B_CariLocks', 'LockedAt') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_CariLocks ADD LockedAt DATETIME NOT NULL
        CONSTRAINT DF_B2B_CariLocks_LockedAt_Added DEFAULT GETDATE();
END;

IF COL_LENGTH('dbo.B2B_CariLocks', 'UnlockedByUserId') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_CariLocks ADD UnlockedByUserId INT NULL;
END;

IF COL_LENGTH('dbo.B2B_CariLocks', 'UnlockedAt') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_CariLocks ADD UnlockedAt DATETIME NULL;
END;

IF NOT EXISTS (
    SELECT 1
    FROM sys.indexes
    WHERE name = 'UX_B2B_CariLocks_CariKod'
      AND object_id = OBJECT_ID('dbo.B2B_CariLocks')
)
BEGIN
    CREATE UNIQUE INDEX UX_B2B_CariLocks_CariKod
    ON dbo.B2B_CariLocks(CariKod);
END;

/* ---------------------------------------------------------- */
/* TAKSİTLİ ÖDEME İÇİN İZİNLİ KART BIN LİSTESİ */
/* ---------------------------------------------------------- */

IF NOT EXISTS (
    SELECT 1
    FROM sys.tables
    WHERE name = 'B2B_InstallmentAllowedBins' AND schema_id = SCHEMA_ID('dbo')
)
BEGIN
    CREATE TABLE dbo.B2B_InstallmentAllowedBins (
        Id INT IDENTITY(1,1) PRIMARY KEY,

        BankCode NVARCHAR(50) NOT NULL,
        BankName NVARCHAR(100) NOT NULL,

        BinPrefix NVARCHAR(8) NOT NULL,

        IsActive BIT NOT NULL
            CONSTRAINT DF_B2B_InstallmentAllowedBins_IsActive DEFAULT 1,

        Note NVARCHAR(500) NULL,

        CreatedAt DATETIME NOT NULL
            CONSTRAINT DF_B2B_InstallmentAllowedBins_CreatedAt DEFAULT GETDATE(),

        UpdatedAt DATETIME NULL
    );
END;

IF COL_LENGTH('dbo.B2B_InstallmentAllowedBins', 'BankCode') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_InstallmentAllowedBins
    ADD BankCode NVARCHAR(50) NOT NULL
        CONSTRAINT DF_B2B_InstallmentAllowedBins_BankCode_Added DEFAULT '';
END;

IF COL_LENGTH('dbo.B2B_InstallmentAllowedBins', 'BankName') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_InstallmentAllowedBins
    ADD BankName NVARCHAR(100) NOT NULL
        CONSTRAINT DF_B2B_InstallmentAllowedBins_BankName_Added DEFAULT '';
END;

IF COL_LENGTH('dbo.B2B_InstallmentAllowedBins', 'BinPrefix') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_InstallmentAllowedBins
    ADD BinPrefix NVARCHAR(8) NOT NULL
        CONSTRAINT DF_B2B_InstallmentAllowedBins_BinPrefix_Added DEFAULT '';
END;

IF COL_LENGTH('dbo.B2B_InstallmentAllowedBins', 'IsActive') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_InstallmentAllowedBins
    ADD IsActive BIT NOT NULL
        CONSTRAINT DF_B2B_InstallmentAllowedBins_IsActive_Added DEFAULT 1;
END;

IF COL_LENGTH('dbo.B2B_InstallmentAllowedBins', 'Note') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_InstallmentAllowedBins
    ADD Note NVARCHAR(500) NULL;
END;

IF COL_LENGTH('dbo.B2B_InstallmentAllowedBins', 'CreatedAt') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_InstallmentAllowedBins
    ADD CreatedAt DATETIME NOT NULL
        CONSTRAINT DF_B2B_InstallmentAllowedBins_CreatedAt_Added DEFAULT GETDATE();
END;

IF COL_LENGTH('dbo.B2B_InstallmentAllowedBins', 'UpdatedAt') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_InstallmentAllowedBins
    ADD UpdatedAt DATETIME NULL;
END;

IF NOT EXISTS (
    SELECT 1
    FROM sys.indexes
    WHERE name = 'UX_B2B_InstallmentAllowedBins_BankCode_BinPrefix'
      AND object_id = OBJECT_ID('dbo.B2B_InstallmentAllowedBins')
)
BEGIN
    CREATE UNIQUE INDEX UX_B2B_InstallmentAllowedBins_BankCode_BinPrefix
    ON dbo.B2B_InstallmentAllowedBins(BankCode, BinPrefix);
END;

/* ---------------------------------------------------------- */
/* ÖDEMELER */
/* ---------------------------------------------------------- */

IF NOT EXISTS (
    SELECT 1
    FROM sys.tables
    WHERE name = 'B2B_Payments' AND schema_id = SCHEMA_ID('dbo')
)
BEGIN
    CREATE TABLE dbo.B2B_Payments (
        Id INT IDENTITY(1,1) PRIMARY KEY,

        PaymentNo NVARCHAR(50) NOT NULL,
        CariKod NVARCHAR(50) NOT NULL,
        Amount DECIMAL(18,2) NOT NULL,
        Currency NVARCHAR(10) NOT NULL CONSTRAINT DF_B2B_Payments_Currency DEFAULT 'TRY',
        Status NVARCHAR(30) NOT NULL,

        BankCode NVARCHAR(50) NULL,
        PosAccountId INT NULL,
        Installment INT NOT NULL CONSTRAINT DF_B2B_Payments_Installment DEFAULT 1,

        OrderNumber NVARCHAR(100) NOT NULL,
        BankTransactionId NVARCHAR(200) NULL,
        ErrorMessage NVARCHAR(1000) NULL,

        CardBin NVARCHAR(10) NULL,
        CardLast4 NVARCHAR(4) NULL,
        MaskedCardNo NVARCHAR(30) NULL,

        RedirectType NVARCHAR(30) NULL,
        RedirectData NVARCHAR(MAX) NULL,

        BankResponseCode NVARCHAR(100) NULL,
        BankResponseMessage NVARCHAR(1000) NULL,
        AuthCode NVARCHAR(100) NULL,
        HostRefNo NVARCHAR(100) NULL,

        CreatedByUserId INT NULL,
        CreatedByUsername NVARCHAR(100) NULL,
        CreatedByUserType NVARCHAR(30) NULL,

        CreatedAt DATETIME NOT NULL CONSTRAINT DF_B2B_Payments_CreatedAt DEFAULT GETDATE(),
        UpdatedAt DATETIME NULL,
        PaidAt DATETIME NULL,
        CallbackReceivedAt DATETIME NULL
    );
END;

IF COL_LENGTH('dbo.B2B_Payments', 'PosAccountId') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_Payments ADD PosAccountId INT NULL;
END;

IF COL_LENGTH('dbo.B2B_Payments', 'Installment') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_Payments
    ADD Installment INT NOT NULL
        CONSTRAINT DF_B2B_Payments_Installment_Added DEFAULT 1;
END;

IF COL_LENGTH('dbo.B2B_Payments', 'CardBin') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_Payments ADD CardBin NVARCHAR(10) NULL;
END;

IF COL_LENGTH('dbo.B2B_Payments', 'CardLast4') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_Payments ADD CardLast4 NVARCHAR(4) NULL;
END;

IF COL_LENGTH('dbo.B2B_Payments', 'MaskedCardNo') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_Payments ADD MaskedCardNo NVARCHAR(30) NULL;
END;

IF COL_LENGTH('dbo.B2B_Payments', 'RedirectType') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_Payments ADD RedirectType NVARCHAR(30) NULL;
END;

IF COL_LENGTH('dbo.B2B_Payments', 'RedirectData') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_Payments ADD RedirectData NVARCHAR(MAX) NULL;
END;

IF COL_LENGTH('dbo.B2B_Payments', 'BankResponseCode') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_Payments ADD BankResponseCode NVARCHAR(100) NULL;
END;

IF COL_LENGTH('dbo.B2B_Payments', 'BankResponseMessage') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_Payments ADD BankResponseMessage NVARCHAR(1000) NULL;
END;

IF COL_LENGTH('dbo.B2B_Payments', 'AuthCode') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_Payments ADD AuthCode NVARCHAR(100) NULL;
END;

IF COL_LENGTH('dbo.B2B_Payments', 'HostRefNo') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_Payments ADD HostRefNo NVARCHAR(100) NULL;
END;

IF COL_LENGTH('dbo.B2B_Payments', 'PaidAt') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_Payments ADD PaidAt DATETIME NULL;
END;

IF COL_LENGTH('dbo.B2B_Payments', 'CallbackReceivedAt') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_Payments ADD CallbackReceivedAt DATETIME NULL;
END;

IF COL_LENGTH('dbo.B2B_Payments', 'CreatedByUserId') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_Payments ADD CreatedByUserId INT NULL;
END;

IF COL_LENGTH('dbo.B2B_Payments', 'CreatedByUsername') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_Payments ADD CreatedByUsername NVARCHAR(100) NULL;
END;

IF COL_LENGTH('dbo.B2B_Payments', 'CreatedByUserType') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_Payments ADD CreatedByUserType NVARCHAR(30) NULL;
END;

IF OBJECT_ID('dbo.FK_B2B_Payments_PosAccounts', 'F') IS NULL
   AND OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
   AND OBJECT_ID('dbo.B2B_PosAccounts', 'U') IS NOT NULL
   AND NOT EXISTS (
        SELECT 1
        FROM dbo.B2B_Payments p
        WHERE p.PosAccountId IS NOT NULL
          AND NOT EXISTS (
              SELECT 1
              FROM dbo.B2B_PosAccounts a
              WHERE a.Id = p.PosAccountId
          )
   )
BEGIN
    ALTER TABLE dbo.B2B_Payments
    ADD CONSTRAINT FK_B2B_Payments_PosAccounts
        FOREIGN KEY (PosAccountId)
        REFERENCES dbo.B2B_PosAccounts(Id);
END;

IF NOT EXISTS (
    SELECT 1
    FROM sys.indexes
    WHERE name = 'UX_B2B_Payments_PaymentNo'
      AND object_id = OBJECT_ID('dbo.B2B_Payments')
)
BEGIN
    CREATE UNIQUE INDEX UX_B2B_Payments_PaymentNo
    ON dbo.B2B_Payments(PaymentNo);
END;

IF NOT EXISTS (
    SELECT 1
    FROM sys.indexes
    WHERE name = 'UX_B2B_Payments_OrderNumber'
      AND object_id = OBJECT_ID('dbo.B2B_Payments')
)
BEGIN
    CREATE UNIQUE INDEX UX_B2B_Payments_OrderNumber
    ON dbo.B2B_Payments(OrderNumber);
END;

IF NOT EXISTS (
    SELECT 1
    FROM sys.indexes
    WHERE name = 'IX_B2B_Payments_CariKod'
      AND object_id = OBJECT_ID('dbo.B2B_Payments')
)
BEGIN
    CREATE INDEX IX_B2B_Payments_CariKod
    ON dbo.B2B_Payments(CariKod);
END;

IF NOT EXISTS (
    SELECT 1
    FROM sys.indexes
    WHERE name = 'IX_B2B_Payments_CreatedAt'
      AND object_id = OBJECT_ID('dbo.B2B_Payments')
)
BEGIN
    CREATE INDEX IX_B2B_Payments_CreatedAt
    ON dbo.B2B_Payments(CreatedAt DESC);
END;

IF NOT EXISTS (
    SELECT 1
    FROM sys.indexes
    WHERE name = 'IX_B2B_Payments_Status'
      AND object_id = OBJECT_ID('dbo.B2B_Payments')
)
BEGIN
    CREATE INDEX IX_B2B_Payments_Status
    ON dbo.B2B_Payments(Status);
END;

/* ---------------------------------------------------------- */
/* ÖDEME LOGLARI */
/* ---------------------------------------------------------- */

IF NOT EXISTS (
    SELECT 1
    FROM sys.tables
    WHERE name = 'B2B_PaymentLogs' AND schema_id = SCHEMA_ID('dbo')
)
BEGIN
    CREATE TABLE dbo.B2B_PaymentLogs (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        PaymentId INT NULL,
        Direction NVARCHAR(30) NOT NULL,
        LogType NVARCHAR(100) NULL,
        RawData NVARCHAR(MAX) NULL,
        IsSuccess BIT NULL,
        ErrorCode NVARCHAR(100) NULL,
        ErrorMessage NVARCHAR(1000) NULL,
        CreatedAt DATETIME NOT NULL CONSTRAINT DF_B2B_PaymentLogs_CreatedAt DEFAULT GETDATE()
    );
END;

IF COL_LENGTH('dbo.B2B_PaymentLogs', 'LogType') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_PaymentLogs ADD LogType NVARCHAR(100) NULL;
END;

IF COL_LENGTH('dbo.B2B_PaymentLogs', 'IsSuccess') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_PaymentLogs ADD IsSuccess BIT NULL;
END;

IF COL_LENGTH('dbo.B2B_PaymentLogs', 'ErrorCode') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_PaymentLogs ADD ErrorCode NVARCHAR(100) NULL;
END;

IF COL_LENGTH('dbo.B2B_PaymentLogs', 'ErrorMessage') IS NULL
BEGIN
    ALTER TABLE dbo.B2B_PaymentLogs ADD ErrorMessage NVARCHAR(1000) NULL;
END;

IF OBJECT_ID('dbo.FK_B2B_PaymentLogs_Payments', 'F') IS NULL
   AND OBJECT_ID('dbo.B2B_PaymentLogs', 'U') IS NOT NULL
   AND OBJECT_ID('dbo.B2B_Payments', 'U') IS NOT NULL
   AND NOT EXISTS (
        SELECT 1
        FROM dbo.B2B_PaymentLogs l
        WHERE l.PaymentId IS NOT NULL
          AND NOT EXISTS (
              SELECT 1
              FROM dbo.B2B_Payments p
              WHERE p.Id = l.PaymentId
          )
   )
BEGIN
    ALTER TABLE dbo.B2B_PaymentLogs
    ADD CONSTRAINT FK_B2B_PaymentLogs_Payments
        FOREIGN KEY (PaymentId)
        REFERENCES dbo.B2B_Payments(Id);
END;

IF NOT EXISTS (
    SELECT 1
    FROM sys.indexes
    WHERE name = 'IX_B2B_PaymentLogs_PaymentId'
      AND object_id = OBJECT_ID('dbo.B2B_PaymentLogs')
)
BEGIN
    CREATE INDEX IX_B2B_PaymentLogs_PaymentId
    ON dbo.B2B_PaymentLogs(PaymentId);
END;

IF NOT EXISTS (
    SELECT 1
    FROM sys.indexes
    WHERE name = 'IX_B2B_PaymentLogs_CreatedAt'
      AND object_id = OBJECT_ID('dbo.B2B_PaymentLogs')
)
BEGIN
    CREATE INDEX IX_B2B_PaymentLogs_CreatedAt
    ON dbo.B2B_PaymentLogs(CreatedAt DESC);
END;


";

    private const string DatabaseManagementSchemaSql = @"
/* ---------------------------------------------------------- */
/* DB TARAMA KAYITLARI */
/* ---------------------------------------------------------- */

IF NOT EXISTS (
    SELECT 1 FROM sys.tables
    WHERE name = 'B2B_DatabaseScanRuns' AND schema_id = SCHEMA_ID('dbo')
)
BEGIN
    CREATE TABLE dbo.B2B_DatabaseScanRuns (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        StartedAt DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
        FinishedAt DATETIME2 NULL,
        Status NVARCHAR(30) NOT NULL,
        Message NVARCHAR(MAX) NULL,
        FoundDatabaseCount INT NOT NULL DEFAULT 0
    );
END;

IF NOT EXISTS (
    SELECT 1 FROM sys.tables
    WHERE name = 'B2B_DatabaseInventory' AND schema_id = SCHEMA_ID('dbo')
)
BEGIN
    CREATE TABLE dbo.B2B_DatabaseInventory (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        ScanRunId INT NOT NULL,
        DatabaseName NVARCHAR(128) NOT NULL,
        TableName NVARCHAR(256) NULL,
        ObjectType NVARCHAR(30) NULL,
        RowCountApprox BIGINT NULL,
        ObjectModifyDate DATETIME NULL,
        SchemaHash NVARCHAR(128) NULL,
        CreatedAt DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME()
    );
END;

IF NOT EXISTS (
    SELECT 1 FROM sys.indexes
    WHERE name = 'IX_B2B_DatabaseInventory_DatabaseName'
      AND object_id = OBJECT_ID('dbo.B2B_DatabaseInventory')
)
BEGIN
    CREATE INDEX IX_B2B_DatabaseInventory_DatabaseName
    ON dbo.B2B_DatabaseInventory(DatabaseName);
END;

/* ---------------------------------------------------------- */
/* DB DEĞİŞİM BİLDİRİMLERİ */
/* ---------------------------------------------------------- */

IF NOT EXISTS (
    SELECT 1 FROM sys.tables
    WHERE name = 'B2B_DatabaseChangeNotifications' AND schema_id = SCHEMA_ID('dbo')
)
BEGIN
    CREATE TABLE dbo.B2B_DatabaseChangeNotifications (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        DatabaseName NVARCHAR(128) NOT NULL,
        ChangeType NVARCHAR(50) NOT NULL,
        Title NVARCHAR(200) NOT NULL,
        Message NVARCHAR(MAX) NULL,
        IsResolved BIT NOT NULL CONSTRAINT DF_B2B_DatabaseChangeNotifications_IsResolved DEFAULT 0,
        IsRequiredAction BIT NOT NULL CONSTRAINT DF_B2B_DatabaseChangeNotifications_IsRequiredAction DEFAULT 1,
        CreatedAt DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
        ResolvedAt DATETIME2 NULL,
        ResolvedByUserId INT NULL
    );
END;

IF NOT EXISTS (
    SELECT 1 FROM sys.indexes
    WHERE name = 'IX_B2B_DatabaseChangeNotifications_IsResolved'
      AND object_id = OBJECT_ID('dbo.B2B_DatabaseChangeNotifications')
)
BEGIN
    CREATE INDEX IX_B2B_DatabaseChangeNotifications_IsResolved
    ON dbo.B2B_DatabaseChangeNotifications(IsResolved, CreatedAt DESC);
END;

IF NOT EXISTS (
    SELECT 1 FROM sys.indexes
    WHERE name = 'UX_B2B_DatabaseChangeNotifications_Open'
      AND object_id = OBJECT_ID('dbo.B2B_DatabaseChangeNotifications')
)
BEGIN
    CREATE UNIQUE INDEX UX_B2B_DatabaseChangeNotifications_Open
    ON dbo.B2B_DatabaseChangeNotifications(DatabaseName, ChangeType, IsResolved)
    WHERE IsResolved = 0;
END;

/* ---------------------------------------------------------- */
/* DB GEÇİŞ GEÇMİŞİ */
/* ---------------------------------------------------------- */

IF NOT EXISTS (
    SELECT 1 FROM sys.tables
    WHERE name = 'B2B_DatabaseMigrationHistory' AND schema_id = SCHEMA_ID('dbo')
)
BEGIN
    CREATE TABLE dbo.B2B_DatabaseMigrationHistory (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        SourceDatabase NVARCHAR(128) NOT NULL,
        TargetDatabase NVARCHAR(128) NOT NULL,
        StartedAt DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
        FinishedAt DATETIME2 NULL,
        Status NVARCHAR(30) NOT NULL,
        Message NVARCHAR(MAX) NULL,
        MigratedByUserId INT NULL,
        MigratedByUsername NVARCHAR(100) NULL
    );
END;

/* ---------------------------------------------------------- */
/* DB GEÇİŞ UYARI / SORUN KAYITLARI */
/* ---------------------------------------------------------- */

IF NOT EXISTS (
    SELECT 1 FROM sys.tables
    WHERE name = 'B2B_DatabaseMigrationIssues' AND schema_id = SCHEMA_ID('dbo')
)
BEGIN
    CREATE TABLE dbo.B2B_DatabaseMigrationIssues (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        MigrationHistoryId INT NOT NULL,
        Severity NVARCHAR(20) NOT NULL,
        IssueType NVARCHAR(100) NOT NULL,
        TableName NVARCHAR(128) NULL,
        RecordKey NVARCHAR(200) NULL,
        CariKod NVARCHAR(50) NULL,
        Message NVARCHAR(MAX) NOT NULL,
        CreatedAt DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME()
    );
END;

IF NOT EXISTS (
    SELECT 1 FROM sys.indexes
    WHERE name = 'IX_B2B_DatabaseMigrationIssues_MigrationHistoryId'
      AND object_id = OBJECT_ID('dbo.B2B_DatabaseMigrationIssues')
)
BEGIN
    CREATE INDEX IX_B2B_DatabaseMigrationIssues_MigrationHistoryId
    ON dbo.B2B_DatabaseMigrationIssues(MigrationHistoryId);
END;
";

    private const string DatabaseMigrationProcedureSql = @"
IF OBJECT_ID('dbo.B2B_MigrateFromDatabase', 'P') IS NOT NULL
    DROP PROCEDURE dbo.B2B_MigrateFromDatabase;
GO

CREATE PROCEDURE dbo.B2B_MigrateFromDatabase
    @SourceDatabase SYSNAME,
    @MigratedByUserId INT = NULL,
    @MigratedByUsername NVARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE @TargetDatabase SYSNAME = DB_NAME();
    DECLARE @Sql NVARCHAR(MAX);
    DECLARE @HistoryId INT;

    IF @SourceDatabase IS NULL OR LTRIM(RTRIM(@SourceDatabase)) = ''
        THROW 52000, 'SourceDatabase boş olamaz.', 1;

    IF DB_ID(@SourceDatabase) IS NULL
        THROW 52001, 'SourceDatabase bulunamadı.', 1;

    IF @SourceDatabase = @TargetDatabase
        THROW 52002, 'SourceDatabase ve TargetDatabase aynı olamaz.', 1;

    IF OBJECT_ID('dbo.Cari_Kart_Listesi') IS NULL
        THROW 52003, 'Hedef veritabanında dbo.Cari_Kart_Listesi bulunamadı.', 1;

    IF OBJECT_ID('dbo.carihrk', 'U') IS NULL
        THROW 52004, 'Hedef veritabanında dbo.carihrk bulunamadı.', 1;

    IF OBJECT_ID('dbo.carikart', 'U') IS NULL
    THROW 52005, 'Hedef veritabanında dbo.carikart bulunamadı.', 1;

    INSERT INTO dbo.B2B_DatabaseMigrationHistory
    (
        SourceDatabase,
        TargetDatabase,
        Status,
        MigratedByUserId,
        MigratedByUsername
    )
    VALUES
    (
        @SourceDatabase,
        @TargetDatabase,
        N'Started',
        @MigratedByUserId,
        @MigratedByUsername
    );

    SET @HistoryId = SCOPE_IDENTITY();

    BEGIN TRY
        BEGIN TRAN;

        /* ---------------------------------------------------------- */
        /* B2B_Users */
        /* ---------------------------------------------------------- */

        SET @Sql = N'
        IF OBJECT_ID(N''' + QUOTENAME(@SourceDatabase) + N'.dbo.B2B_Users'', N''U'') IS NOT NULL
        BEGIN
            SET IDENTITY_INSERT dbo.B2B_Users ON;

            MERGE dbo.B2B_Users AS T
            USING ' + QUOTENAME(@SourceDatabase) + N'.dbo.B2B_Users AS S
            ON T.Id = S.Id
            WHEN MATCHED THEN
                UPDATE SET
                    T.UserType = S.UserType,
                    T.Username = S.Username,
                    T.PasswordHash = S.PasswordHash,
                    T.CariKod = S.CariKod,
                    T.IsActive = S.IsActive,
                    T.MustChangePassword = S.MustChangePassword,
                    T.CreatedAt = S.CreatedAt
            WHEN NOT MATCHED BY TARGET THEN
                INSERT
                (
                    Id,
                    UserType,
                    Username,
                    PasswordHash,
                    CariKod,
                    IsActive,
                    MustChangePassword,
                    CreatedAt
                )
                VALUES
                (
                    S.Id,
                    S.UserType,
                    S.Username,
                    S.PasswordHash,
                    S.CariKod,
                    S.IsActive,
                    S.MustChangePassword,
                    S.CreatedAt
                );

            SET IDENTITY_INSERT dbo.B2B_Users OFF;
        END;
        ';

        EXEC sp_executesql @Sql;

                /* ---------------------------------------------------------- */
        /* B2B_PosAccounts */
        /* ---------------------------------------------------------- */

        SET @Sql = N'
        IF OBJECT_ID(N''' + QUOTENAME(@SourceDatabase) + N'.dbo.B2B_PosAccounts'', N''U'') IS NOT NULL
        BEGIN
            SET IDENTITY_INSERT dbo.B2B_PosAccounts ON;

            MERGE dbo.B2B_PosAccounts AS T
            USING ' + QUOTENAME(@SourceDatabase) + N'.dbo.B2B_PosAccounts AS S
            ON T.Id = S.Id
            WHEN MATCHED THEN
                UPDATE SET
                    T.BankCode = S.BankCode,
                    T.BankName = S.BankName,
                    T.CustomerId = S.CustomerId,
                    T.MerchantId = S.MerchantId,
                    T.MerchantUser = S.MerchantUser,
                    T.MerchantPasswordEncrypted = S.MerchantPasswordEncrypted,
                    T.MerchantStoreKeyEncrypted = S.MerchantStoreKeyEncrypted,
                    T.TestPlatform = S.TestPlatform,
                    T.IsActive = S.IsActive,
                    T.ReturnUrl = S.ReturnUrl,
                    T.PayGateUrl = S.PayGateUrl,
                    T.ProvisionGateUrl = S.ProvisionGateUrl,
                    T.ApiVersion = S.ApiVersion,
                    T.CurrencyCode = S.CurrencyCode,
                    T.TransactionSecurity = S.TransactionSecurity,
                    T.AccountingCardType = S.AccountingCardType,
                    T.AccountingCardCode = S.AccountingCardCode,
                    T.AccountingDescription = S.AccountingDescription,
                    T.CreatedAt = S.CreatedAt,
                    T.UpdatedAt = S.UpdatedAt
            WHEN NOT MATCHED BY TARGET THEN
                INSERT
                (
                    Id,
                    BankCode,
                    BankName,
                    CustomerId,
                    MerchantId,
                    MerchantUser,
                    MerchantPasswordEncrypted,
                    MerchantStoreKeyEncrypted,
                    TestPlatform,
                    IsActive,
                    ReturnUrl,
                    PayGateUrl,
                    ProvisionGateUrl,
                    ApiVersion,
                    CurrencyCode,
                    TransactionSecurity,
                    AccountingCardType,
                    AccountingCardCode,
                    AccountingDescription,
                    CreatedAt,
                    UpdatedAt
                )
                VALUES
                (
                    S.Id,
                    S.BankCode,
                    S.BankName,
                    S.CustomerId,
                    S.MerchantId,
                    S.MerchantUser,
                    S.MerchantPasswordEncrypted,
                    S.MerchantStoreKeyEncrypted,
                    S.TestPlatform,
                    S.IsActive,
                    S.ReturnUrl,
                    S.PayGateUrl,
                    S.ProvisionGateUrl,
                    S.ApiVersion,
                    S.CurrencyCode,
                    S.TransactionSecurity,
                    S.AccountingCardType,
                    S.AccountingCardCode,
                    S.AccountingDescription,
                    S.CreatedAt,
                    S.UpdatedAt
                );

            SET IDENTITY_INSERT dbo.B2B_PosAccounts OFF;
        END;
        ';

        EXEC sp_executesql @Sql;

        /* ---------------------------------------------------------- */
        /* B2B_PosInstallmentRules */
        /* ---------------------------------------------------------- */

        SET @Sql = N'
        IF OBJECT_ID(N''' + QUOTENAME(@SourceDatabase) + N'.dbo.B2B_PosInstallmentRules'', N''U'') IS NOT NULL
        BEGIN
            SET IDENTITY_INSERT dbo.B2B_PosInstallmentRules ON;

            MERGE dbo.B2B_PosInstallmentRules AS T
            USING ' + QUOTENAME(@SourceDatabase) + N'.dbo.B2B_PosInstallmentRules AS S
            ON T.Id = S.Id
            WHEN MATCHED THEN
                UPDATE SET
                    T.PosAccountId = S.PosAccountId,
                    T.Installment = S.Installment,
                    T.MinAmount = S.MinAmount,
                    T.MaxAmount = S.MaxAmount,
                    T.CommissionRate = S.CommissionRate,
                    T.IsActive = S.IsActive,
                    T.CreatedAt = S.CreatedAt,
                    T.UpdatedAt = S.UpdatedAt
            WHEN NOT MATCHED BY TARGET THEN
                INSERT
                (
                    Id,
                    PosAccountId,
                    Installment,
                    MinAmount,
                    MaxAmount,
                    CommissionRate,
                    IsActive,
                    CreatedAt,
                    UpdatedAt
                )
                VALUES
                (
                    S.Id,
                    S.PosAccountId,
                    S.Installment,
                    S.MinAmount,
                    S.MaxAmount,
                    S.CommissionRate,
                    S.IsActive,
                    S.CreatedAt,
                    S.UpdatedAt
                );

            SET IDENTITY_INSERT dbo.B2B_PosInstallmentRules OFF;
        END;
        ';

        EXEC sp_executesql @Sql;

        /* ---------------------------------------------------------- */
        /* B2B_InstallmentAllowedBins */
        /* ---------------------------------------------------------- */

        SET @Sql = N'
        IF OBJECT_ID(N''' + QUOTENAME(@SourceDatabase) + N'.dbo.B2B_InstallmentAllowedBins'', N''U'') IS NOT NULL
        BEGIN
            SET IDENTITY_INSERT dbo.B2B_InstallmentAllowedBins ON;

            MERGE dbo.B2B_InstallmentAllowedBins AS T
            USING ' + QUOTENAME(@SourceDatabase) + N'.dbo.B2B_InstallmentAllowedBins AS S
            ON T.Id = S.Id
            WHEN MATCHED THEN
                UPDATE SET
                    T.BankCode = S.BankCode,
                    T.BankName = S.BankName,
                    T.BinPrefix = S.BinPrefix,
                    T.IsActive = S.IsActive,
                    T.Note = S.Note,
                    T.CreatedAt = S.CreatedAt,
                    T.UpdatedAt = S.UpdatedAt
            WHEN NOT MATCHED BY TARGET THEN
                INSERT
                (
                    Id,
                    BankCode,
                    BankName,
                    BinPrefix,
                    IsActive,
                    Note,
                    CreatedAt,
                    UpdatedAt
                )
                VALUES
                (
                    S.Id,
                    S.BankCode,
                    S.BankName,
                    S.BinPrefix,
                    S.IsActive,
                    S.Note,
                    S.CreatedAt,
                    S.UpdatedAt
                );

            SET IDENTITY_INSERT dbo.B2B_InstallmentAllowedBins OFF;
        END;
        ';

        EXEC sp_executesql @Sql;

        /* ---------------------------------------------------------- */
        /* B2B_CariLocks */
        /* ---------------------------------------------------------- */

        SET @Sql = N'
        IF OBJECT_ID(N''' + QUOTENAME(@SourceDatabase) + N'.dbo.B2B_CariLocks'', N''U'') IS NOT NULL
        BEGIN
            SET IDENTITY_INSERT dbo.B2B_CariLocks ON;

            MERGE dbo.B2B_CariLocks AS T
            USING ' + QUOTENAME(@SourceDatabase) + N'.dbo.B2B_CariLocks AS S
            ON T.Id = S.Id
            WHEN MATCHED THEN
                UPDATE SET
                    T.CariKod = S.CariKod,
                    T.IsLocked = S.IsLocked,
                    T.Reason = S.Reason,
                    T.LockedByUserId = S.LockedByUserId,
                    T.LockedAt = S.LockedAt,
                    T.UnlockedByUserId = S.UnlockedByUserId,
                    T.UnlockedAt = S.UnlockedAt
            WHEN NOT MATCHED BY TARGET THEN
                INSERT
                (
                    Id,
                    CariKod,
                    IsLocked,
                    Reason,
                    LockedByUserId,
                    LockedAt,
                    UnlockedByUserId,
                    UnlockedAt
                )
                VALUES
                (
                    S.Id,
                    S.CariKod,
                    S.IsLocked,
                    S.Reason,
                    S.LockedByUserId,
                    S.LockedAt,
                    S.UnlockedByUserId,
                    S.UnlockedAt
                );

            SET IDENTITY_INSERT dbo.B2B_CariLocks OFF;
        END;
        ';

        EXEC sp_executesql @Sql;

        /* ---------------------------------------------------------- */
        /* B2B_Payments */
        /* ---------------------------------------------------------- */

        SET @Sql = N'
        IF OBJECT_ID(N''' + QUOTENAME(@SourceDatabase) + N'.dbo.B2B_Payments'', N''U'') IS NOT NULL
        BEGIN
            SET IDENTITY_INSERT dbo.B2B_Payments ON;

            MERGE dbo.B2B_Payments AS T
            USING ' + QUOTENAME(@SourceDatabase) + N'.dbo.B2B_Payments AS S
            ON T.Id = S.Id
            WHEN MATCHED THEN
                UPDATE SET
                    T.PaymentNo = S.PaymentNo,
                    T.CariKod = S.CariKod,
                    T.Amount = S.Amount,
                    T.Currency = S.Currency,
                    T.Status = S.Status,
                    T.BankCode = S.BankCode,
                    T.PosAccountId = S.PosAccountId,
                    T.Installment = S.Installment,
                    T.OrderNumber = S.OrderNumber,
                    T.BankTransactionId = S.BankTransactionId,
                    T.ErrorMessage = S.ErrorMessage,
                    T.CardBin = S.CardBin,
                    T.CardLast4 = S.CardLast4,
                    T.MaskedCardNo = S.MaskedCardNo,
                    T.RedirectType = S.RedirectType,
                    T.RedirectData = S.RedirectData,
                    T.BankResponseCode = S.BankResponseCode,
                    T.BankResponseMessage = S.BankResponseMessage,
                    T.AuthCode = S.AuthCode,
                    T.HostRefNo = S.HostRefNo,
                    T.CreatedByUserId = S.CreatedByUserId,
                    T.CreatedByUsername = S.CreatedByUsername,
                    T.CreatedByUserType = S.CreatedByUserType,
                    T.CreatedAt = S.CreatedAt,
                    T.UpdatedAt = S.UpdatedAt,
                    T.PaidAt = S.PaidAt,
                    T.CallbackReceivedAt = S.CallbackReceivedAt
            WHEN NOT MATCHED BY TARGET THEN
                INSERT
                (
                    Id,
                    PaymentNo,
                    CariKod,
                    Amount,
                    Currency,
                    Status,
                    BankCode,
                    PosAccountId,
                    Installment,
                    OrderNumber,
                    BankTransactionId,
                    ErrorMessage,
                    CardBin,
                    CardLast4,
                    MaskedCardNo,
                    RedirectType,
                    RedirectData,
                    BankResponseCode,
                    BankResponseMessage,
                    AuthCode,
                    HostRefNo,
                    CreatedByUserId,
                    CreatedByUsername,
                    CreatedByUserType,
                    CreatedAt,
                    UpdatedAt,
                    PaidAt,
                    CallbackReceivedAt
                )
                VALUES
                (
                    S.Id,
                    S.PaymentNo,
                    S.CariKod,
                    S.Amount,
                    S.Currency,
                    S.Status,
                    S.BankCode,
                    S.PosAccountId,
                    S.Installment,
                    S.OrderNumber,
                    S.BankTransactionId,
                    S.ErrorMessage,
                    S.CardBin,
                    S.CardLast4,
                    S.MaskedCardNo,
                    S.RedirectType,
                    S.RedirectData,
                    S.BankResponseCode,
                    S.BankResponseMessage,
                    S.AuthCode,
                    S.HostRefNo,
                    S.CreatedByUserId,
                    S.CreatedByUsername,
                    S.CreatedByUserType,
                    S.CreatedAt,
                    S.UpdatedAt,
                    S.PaidAt,
                    S.CallbackReceivedAt
                );

            SET IDENTITY_INSERT dbo.B2B_Payments OFF;
        END;
        ';

        EXEC sp_executesql @Sql;

        /* ---------------------------------------------------------- */
        /* B2B_PaymentLogs */
        /* ---------------------------------------------------------- */

        SET @Sql = N'
        IF OBJECT_ID(N''' + QUOTENAME(@SourceDatabase) + N'.dbo.B2B_PaymentLogs'', N''U'') IS NOT NULL
        BEGIN
            SET IDENTITY_INSERT dbo.B2B_PaymentLogs ON;

            MERGE dbo.B2B_PaymentLogs AS T
            USING ' + QUOTENAME(@SourceDatabase) + N'.dbo.B2B_PaymentLogs AS S
            ON T.Id = S.Id
            WHEN MATCHED THEN
                UPDATE SET
                    T.PaymentId = S.PaymentId,
                    T.Direction = S.Direction,
                    T.LogType = S.LogType,
                    T.RawData = S.RawData,
                    T.IsSuccess = S.IsSuccess,
                    T.ErrorCode = S.ErrorCode,
                    T.ErrorMessage = S.ErrorMessage,
                    T.CreatedAt = S.CreatedAt
            WHEN NOT MATCHED BY TARGET THEN
                INSERT
                (
                    Id,
                    PaymentId,
                    Direction,
                    LogType,
                    RawData,
                    IsSuccess,
                    ErrorCode,
                    ErrorMessage,
                    CreatedAt
                )
                VALUES
                (
                    S.Id,
                    S.PaymentId,
                    S.Direction,
                    S.LogType,
                    S.RawData,
                    S.IsSuccess,
                    S.ErrorCode,
                    S.ErrorMessage,
                    S.CreatedAt
                );

            SET IDENTITY_INSERT dbo.B2B_PaymentLogs OFF;
        END;
        ';

        EXEC sp_executesql @Sql;

        /* ---------------------------------------------------------- */
        /* Hedef DB'de carikart veya Cari_Kart_Listesi içinde olmayan */
        /* cari kodlarına bağlı B2B verilerini sil */
        /* ---------------------------------------------------------- */

        IF OBJECT_ID('tempdb..#InvalidCariKod') IS NOT NULL
            DROP TABLE #InvalidCariKod;

        CREATE TABLE #InvalidCariKod
        (
            CariKod NVARCHAR(50) NOT NULL PRIMARY KEY
        );

        INSERT INTO #InvalidCariKod (CariKod)
        SELECT DISTINCT u.CariKod
        FROM dbo.B2B_Users u
        WHERE u.UserType = N'Cari'
          AND u.CariKod IS NOT NULL
          AND LTRIM(RTRIM(u.CariKod)) <> N''
          AND NOT EXISTS (
              SELECT 1
              FROM dbo.Cari_Kart_Listesi c
              WHERE c.kod = u.CariKod
                AND ISNULL(c.sil, 0) = 0
          )
          AND NOT EXISTS (
              SELECT 1
              FROM dbo.carikart ck
              WHERE ck.kod = u.CariKod
                AND ISNULL(ck.sil, 0) = 0
          );

        INSERT INTO #InvalidCariKod (CariKod)
        SELECT DISTINCT p.CariKod
        FROM dbo.B2B_Payments p
        WHERE p.CariKod IS NOT NULL
          AND LTRIM(RTRIM(p.CariKod)) <> N''
          AND NOT EXISTS (
              SELECT 1 FROM #InvalidCariKod x WHERE x.CariKod = p.CariKod
          )
          AND NOT EXISTS (
              SELECT 1
              FROM dbo.Cari_Kart_Listesi c
              WHERE c.kod = p.CariKod
                AND ISNULL(c.sil, 0) = 0
          )
          AND NOT EXISTS (
              SELECT 1
              FROM dbo.carikart ck
              WHERE ck.kod = p.CariKod
                AND ISNULL(ck.sil, 0) = 0
          );

        INSERT INTO #InvalidCariKod (CariKod)
        SELECT DISTINCT l.CariKod
        FROM dbo.B2B_CariLocks l
        WHERE l.CariKod IS NOT NULL
          AND LTRIM(RTRIM(l.CariKod)) <> N''
          AND NOT EXISTS (
              SELECT 1 FROM #InvalidCariKod x WHERE x.CariKod = l.CariKod
          )
          AND NOT EXISTS (
              SELECT 1
              FROM dbo.Cari_Kart_Listesi c
              WHERE c.kod = l.CariKod
                AND ISNULL(c.sil, 0) = 0
          )
          AND NOT EXISTS (
              SELECT 1
              FROM dbo.carikart ck
              WHERE ck.kod = l.CariKod
                AND ISNULL(ck.sil, 0) = 0
          );

        INSERT INTO dbo.B2B_DatabaseMigrationIssues
        (
            MigrationHistoryId,
            Severity,
            IssueType,
            TableName,
            RecordKey,
            CariKod,
            Message
        )
        SELECT
            @HistoryId,
            N'Warning',
            N'InvalidCariKodDeleted',
            N'B2B',
            x.CariKod,
            x.CariKod,
            N'Cari kod hedef veritabanındaki carikart veya Cari_Kart_Listesi içinde bulunamadığı için bu cariye bağlı B2B kayıtları silindi.'
        FROM #InvalidCariKod x;

        IF OBJECT_ID('tempdb..#DeletePaymentIds') IS NOT NULL
            DROP TABLE #DeletePaymentIds;

        CREATE TABLE #DeletePaymentIds
        (
            Id INT NOT NULL PRIMARY KEY
        );

        INSERT INTO #DeletePaymentIds (Id)
        SELECT DISTINCT p.Id
        FROM dbo.B2B_Payments p
        INNER JOIN #InvalidCariKod x ON x.CariKod = p.CariKod;

        INSERT INTO #DeletePaymentIds (Id)
        SELECT DISTINCT p.Id
        FROM dbo.B2B_Payments p
        INNER JOIN dbo.B2B_Users u ON u.Id = p.CreatedByUserId
        INNER JOIN #InvalidCariKod x ON x.CariKod = u.CariKod
        WHERE NOT EXISTS (
            SELECT 1 FROM #DeletePaymentIds d WHERE d.Id = p.Id
        );

        DELETE pl
        FROM dbo.B2B_PaymentLogs pl
        INNER JOIN #DeletePaymentIds d ON d.Id = pl.PaymentId;

        DELETE p
        FROM dbo.B2B_Payments p
        INNER JOIN #DeletePaymentIds d ON d.Id = p.Id;

        DELETE l
        FROM dbo.B2B_CariLocks l
        INNER JOIN #InvalidCariKod x ON x.CariKod = l.CariKod;

        DELETE u
        FROM dbo.B2B_Users u
        INNER JOIN #InvalidCariKod x ON x.CariKod = u.CariKod
        WHERE u.UserType = N'Cari';

        COMMIT;

        UPDATE dbo.B2B_DatabaseMigrationHistory
        SET
            Status = N'Completed',
            FinishedAt = SYSUTCDATETIME(),
            Message = N'Migration completed.'
        WHERE Id = @HistoryId;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK;

        UPDATE dbo.B2B_DatabaseMigrationHistory
        SET
            Status = N'Failed',
            FinishedAt = SYSUTCDATETIME(),
            Message = ERROR_MESSAGE()
        WHERE Id = @HistoryId;

        THROW;
    END CATCH
END;
";

}