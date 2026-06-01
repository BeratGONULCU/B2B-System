using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AvmB2B.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddB2BPosAndPaymentFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ana_menu_hrk",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    name = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    @class = table.Column<string>(name: "class", type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    icon_index = table.Column<int>(type: "int", nullable: true),
                    cap_tr = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Modul = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ana_menu__3213E83F9D732E72", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ana_menu_mas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    kisayol_cap = table.Column<bool>(type: "bit", nullable: true),
                    style = table.Column<byte>(type: "tinyint", nullable: true),
                    coklu_satir = table.Column<bool>(type: "bit", nullable: true),
                    Modul = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Eski_Style = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AppIrsaliyeHrk",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppIrsaliyeId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    DeviceId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SiraNo = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    BarkodNo = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Miktar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Fiyat = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    StokTip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    StokKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OlusturmaTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlusturmaUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AppIrsal__3214EC0708238C5B", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppIrsaliyeMas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FirmaNo = table.Column<int>(type: "int", nullable: true),
                    Seri = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    SeriNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    CariKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DepoKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OlusturmaTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlusturmaUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AppIrsal__3214EC07A9D680AC", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRafEitketHrk",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppRafEtiketId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    DeviceId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SiraNo = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    BarkodNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OlusturmaTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlusturmaUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AppRafEi__3214EC07F28D35CC", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRafEtiketMas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FirmaNo = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Aciklama = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    OlusturmaTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlusturmaUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AppRafEt__3214EC07014D1872", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppSayim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BackSayimId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    DeviceId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AppSayimId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    SiraNo = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    BarkodNo = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Miktar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    StokTip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    StokKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OlusturmaTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlusturmaUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AppSayim__3214EC079DB37C91", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "B2B_PaymentLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentId = table.Column<int>(type: "int", nullable: true),
                    Direction = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LogType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RawData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsSuccess = table.Column<bool>(type: "bit", nullable: true),
                    ErrorCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_B2B_PaymentLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "B2B_Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CariKod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BankCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PosAccountId = table.Column<int>(type: "int", nullable: true),
                    Installment = table.Column<int>(type: "int", nullable: false),
                    OrderNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BankTransactionId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ErrorMessage = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CardBin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardLast4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaskedCardNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RedirectType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RedirectData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankResponseCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankResponseMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HostRefNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    PaidAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CallbackReceivedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_B2B_Payments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "B2B_Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CariKod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    MustChangePassword = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_B2B_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "B2BPosAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MerchantId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MerchantUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchantPasswordEncrypted = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchantStoreKeyEncrypted = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestPlatform = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ReturnUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_B2BPosAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "B2BPosInstallmentRules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PosAccountId = table.Column<int>(type: "int", nullable: false),
                    Installment = table.Column<int>(type: "int", nullable: false),
                    MinAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CommissionRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_B2BPosInstallmentRules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bankahrk",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bankod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    bankhrkid = table.Column<double>(type: "float", nullable: false),
                    varno = table.Column<double>(type: "float", nullable: false),
                    masterid = table.Column<double>(type: "float", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    gctip = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    islmtip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    islmtipad = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    islmhrk = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    islmhrkad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    yertip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    yerad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    perkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    adaid = table.Column<int>(type: "int", nullable: true),
                    borc = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    alacak = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    carkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cartur = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    cartip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    belno = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ack = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    kur = table.Column<double>(type: "float", nullable: true),
                    varok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    kaskod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true, defaultValue: ""),
                    pro = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    fisfattip = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true, defaultValue: "KENDI"),
                    fisfatid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    karsihestip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    karsiheskod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    fisid = table.Column<int>(type: "int", nullable: true),
                    gidkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    gidtutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    vadetar = table.Column<DateTime>(type: "datetime", nullable: true),
                    entegre_aktar = table.Column<DateTime>(type: "datetime", nullable: true),
                    entegre_tip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    fatid = table.Column<int>(type: "int", nullable: true),
                    tahodeid = table.Column<int>(type: "int", nullable: true),
                    bank_id = table.Column<int>(type: "int", nullable: true),
                    cartip_id = table.Column<byte>(type: "tinyint", nullable: true),
                    car_id = table.Column<int>(type: "int", nullable: true),
                    gid_id = table.Column<int>(type: "int", nullable: true),
                    kas_id = table.Column<int>(type: "int", nullable: true),
                    belrap_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    rg = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)1),
                    cekid = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    faiz_oran = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Faiz_tutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Taksit_BasTar = table.Column<DateTime>(type: "datetime", nullable: true),
                    Taksit_Say = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Taksit_BitTar = table.Column<DateTime>(type: "datetime", nullable: true),
                    devir = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Karsi_KartTip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Karsi_KartKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    CariAvans = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Entegre = table.Column<bool>(type: "bit", nullable: true),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    TopluKayitId = table.Column<int>(type: "int", nullable: true),
                    TopluKayitHrkId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__bankahrk__8FE79CF732C9E9A8", x => new { x.id, x.varno, x.masterid, x.bankod, x.bankhrkid });
                });

            migrationBuilder.CreateTable(
                name: "bankakart",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: false),
                    sil = table.Column<int>(type: "int", nullable: false),
                    ad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    muhkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    hesno = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ilgili = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    tel = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    drm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    fax = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    grp1 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    grp2 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    grp3 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    borc = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    alacak = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    actutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    muhonkod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    cekmuhkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Remote_id = table.Column<int>(type: "int", nullable: true),
                    Iban = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__bankakar__DAB2FC2B70970815", x => new { x.id, x.kod, x.sil, x.firmano });
                });

            migrationBuilder.CreateTable(
                name: "Banknot_hrk",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true),
                    hrk_id = table.Column<int>(type: "int", nullable: true),
                    varno = table.Column<int>(type: "int", nullable: true),
                    varok = table.Column<int>(type: "int", nullable: true),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Tip = table.Column<int>(type: "int", nullable: true),
                    adet = table.Column<int>(type: "int", nullable: true),
                    deger = table.Column<double>(type: "float", nullable: true),
                    olususer = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    yertip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    yerad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    deguser = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Banknot___3213E83FADD70C92", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Banknot_Tip",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ack = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Deger = table.Column<double>(type: "float", nullable: true),
                    olususer = table.Column<int>(type: "int", nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    sil = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Banknot___3213E83F1879D53A", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "barkod",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    tip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    barkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    carpan = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    brim = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    tip_id = table.Column<byte>(type: "tinyint", nullable: true),
                    stk_id = table.Column<int>(type: "int", nullable: true),
                    Remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Terazi = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Master = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__barkod__DFEE6686B05E93D4", x => new { x.id, x.kod });
                });

            migrationBuilder.CreateTable(
                name: "BarkodBedelsiz",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tip_id = table.Column<byte>(type: "tinyint", nullable: false),
                    stk_id = table.Column<int>(type: "int", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    tip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Barkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    olususer = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    deguser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    carpan = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    brim = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Terazi = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("BarkodBedelsiz_pk", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "bolum",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true),
                    ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    sfirmano = table.Column<int>(type: "int", nullable: true),
                    havuz = table.Column<bool>(type: "bit", nullable: true),
                    anaformnesne = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modul = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BulutTahsilat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TahsilatId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TahsilatTipId = table.Column<int>(type: "int", nullable: true),
                    TahsilatTipAd = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    EntegratorId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    BankKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BankAd = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    BankIBAN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TCVKNNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Unvan = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Tutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Aciklama = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    KayitTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    CariTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    CariId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    BankaId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    AktarimId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    AktarimTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BulutTah__3214EC077CAA0BA0", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cari_Calisma_Sart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Ad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    fatvadtip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fatvadsur = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    fisvadtip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fisvadsur = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    fatisk = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    fisvadfark = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    fatvadfark = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    TtsBayisk = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    TtsDagisk = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    TtsBayVadFark = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    TtsDagVadFark = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    ToplamLimit = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    limit_tip = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Risk_Limit = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    TTS_OdeTip = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    DBS_RefNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Oto_FisVadeFark = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    AvansTakip = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    fisisk = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    WebAvans = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    WebFatura = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    WebCariHrk = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    WebCariBakiye = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    WebFisOdendi = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    WebFaturaOdendi = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    WebPos = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    WebFisIskontoluTahsil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Web = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    WebFis = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    WebFaturaIskontoluTahsil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    WebFaturaTahsil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    WebFisTahsil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Cari_Calisma_Urun_Iskonto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mas_Id = table.Column<int>(type: "int", nullable: true),
                    Tip = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    StkTip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true, defaultValue: "akykt"),
                    StkTip_id = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    Stk_id = table.Column<int>(type: "int", nullable: true),
                    Stk_Kod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Iskonto_Oran = table.Column<double>(type: "float", nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    OlusUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    OlusTarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegisUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DegisTarSaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Cari_Fat_Urun_Iskonto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    StkTip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true, defaultValue: "akykt"),
                    StkTip_id = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    Stk_id = table.Column<int>(type: "int", nullable: true),
                    Stk_Kod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    cartip_id = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    Car_id = table.Column<int>(type: "int", nullable: true),
                    Car_Kod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Iskonto_Oran = table.Column<double>(type: "float", nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Iskonto_Tip = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValue: "%")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Cari_Fat__3214EC07178347D1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cari_Surucu",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    cartip_id = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    car_kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    car_id = table.Column<int>(type: "int", nullable: true),
                    ad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Cari_Sur__3213E83FE9019E56", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Cari_Tip",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tip = table.Column<int>(type: "int", nullable: true),
                    Kod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ack_tr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ack_en = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ack_al = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ack_ru = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Cari_Tip__3213E83F3C788F3A", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Cari_Tur",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Cari_Tur__3213E83F6A6B5FD4", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "carihrk",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    carhrkid = table.Column<double>(type: "float", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    gctip = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    masterid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    islmtip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    islmtipad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    islmhrk = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    islmhrkad = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: true),
                    yerad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    yertip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cartip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    carkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    borc = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    alacak = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    bakiye = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    olususer = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    vadetar = table.Column<DateTime>(type: "datetime", nullable: true),
                    belno = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true, defaultValue: ""),
                    ack = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    varno = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    kur = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    pro = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    varok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    perkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    adaid = table.Column<int>(type: "int", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    karsihestip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    karsiheskod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    kdvyuz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    fisaktip = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true, defaultValue: ""),
                    fisfattip = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true, defaultValue: "KENDI"),
                    fisfatid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    marsatid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    fisid = table.Column<int>(type: "int", nullable: true),
                    permasmasid = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    fatstkhrkid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    carvardmasid = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    maas_gun = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    entegre_aktar = table.Column<DateTime>(type: "datetime", nullable: true),
                    entegre_tip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    fatid = table.Column<int>(type: "int", nullable: true),
                    fis_cariborc_id = table.Column<int>(type: "int", nullable: true),
                    plaka = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fisstkhrkid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    tahodeid = table.Column<int>(type: "int", nullable: true),
                    fis_alc_id = table.Column<int>(type: "int", nullable: true),
                    car_id = table.Column<int>(type: "int", nullable: true),
                    cartip_id = table.Column<byte>(type: "tinyint", nullable: true),
                    FisStkAnaid = table.Column<double>(type: "float", nullable: true),
                    FatStkAnaid = table.Column<double>(type: "float", nullable: true),
                    belrap_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Surucu = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Promid = table.Column<long>(type: "bigint", nullable: true),
                    PromStkAnaid = table.Column<long>(type: "bigint", nullable: true),
                    rg = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)1),
                    Poshrk_id = table.Column<int>(type: "int", nullable: true),
                    kasahrk_id = table.Column<int>(type: "int", nullable: true),
                    Cek_id = table.Column<int>(type: "int", nullable: true),
                    Bankahrk_id = table.Column<int>(type: "int", nullable: true),
                    isthrk_id = table.Column<int>(type: "int", nullable: true),
                    say_id = table.Column<int>(type: "int", nullable: true),
                    irsid = table.Column<int>(type: "int", nullable: true),
                    cekid = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    fis_brc_id = table.Column<int>(type: "int", nullable: true),
                    devir = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Fireid = table.Column<int>(type: "int", nullable: true),
                    Karsi_KartTip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Karsi_KartKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ResSatId = table.Column<int>(type: "int", nullable: true),
                    irsStkAnaid = table.Column<int>(type: "int", nullable: true),
                    CariAvans = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Entegre = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    FatKapTip = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true, defaultValue: "FAT"),
                    TopluKayitId = table.Column<int>(type: "int", nullable: true),
                    TopluKayitHrkId = table.Column<int>(type: "int", nullable: true),
                    TVirmanKayitId = table.Column<int>(type: "int", nullable: true),
                    TVirmanKayitHrkId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__carihrk__141D4B54ACCBBA29", x => new { x.id, x.carhrkid });
                });

            migrationBuilder.CreateTable(
                name: "carikart",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sil = table.Column<int>(type: "int", nullable: false),
                    kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    ad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    soyad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    unvan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    grp1 = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    grp2 = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    grp3 = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    fisbak = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    carbak = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    fisadet = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    fisakadet = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    cekbak = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    fisaktut = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    actutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    ilgili = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    tel = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fax = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    cep = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    muhkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    drm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    resim = table.Column<byte[]>(type: "image", nullable: true),
                    adres = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    evil = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    evilce = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    vergidaire = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    vergino = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    mail = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    tcno = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    kulkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    sonhrktar = table.Column<DateTime>(type: "datetime", nullable: true),
                    kulsif = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    fatvadtip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fisvadtip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fatvadsur = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    fisvadsur = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    fatisk = table.Column<double>(type: "float", nullable: true),
                    fisvadfark = table.Column<double>(type: "float", nullable: true),
                    fatvadfark = table.Column<double>(type: "float", nullable: true),
                    fisisk = table.Column<double>(type: "float", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    otofisak = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    fatunvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    toplamteminat = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    toplamlimit = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    sonfistutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    sonfistarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    adres2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    notack = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    epostagonder = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    webextre = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    muhonkod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    hesapno = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fat_car_sec = table.Column<byte>(type: "tinyint", nullable: true),
                    Fat_car_kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    fat_car_id = table.Column<int>(type: "int", nullable: true),
                    Prom_Grp1 = table.Column<int>(type: "int", nullable: true),
                    limit_tip = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    per_id = table.Column<int>(type: "int", nullable: true),
                    ykt_alm_def_no = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Arac_Ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Epdk_LisansNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TtsBayisk = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    TtsDagisk = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    TtsBayVadFark = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    TtsDagVadFark = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    vergikimlikno = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    EFatura = table.Column<bool>(type: "bit", nullable: true),
                    VergiEposta = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    EfaturaTip = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TicSicilNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    webadres = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Risk_Limit = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    PerIDIN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TTS_Nakit = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    TTS_OdeTip = table.Column<int>(type: "int", nullable: true, defaultValue: 2),
                    DBS_RefNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Vade_OpsiyonGun = table.Column<int>(type: "int", nullable: true, defaultValue: 30),
                    Oto_FisVadeFark = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    AvansTakip = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    WebAvans = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    WebFatura = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    WebCariHrk = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    WebCariBakiye = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    WebFisOdendi = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    WebFaturaOdendi = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    WebPos = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    WebFisIskontoluTahsil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Web = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    WebFis = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    WebFaturaIskontoluTahsil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    WebFisTahsil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    WebFaturaTahsil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    DogumTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    BankaKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    BankaDbs = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    TurId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    AdresPostaKod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__carikart__E033B95B0AD54F22", x => new { x.id, x.kod, x.sil });
                });

            migrationBuilder.CreateTable(
                name: "cariteminat",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    tip = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    tur = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    tutar = table.Column<double>(type: "float", nullable: true),
                    ack = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__caritemi__DFEE66863285D601", x => new { x.id, x.kod });
                });

            migrationBuilder.CreateTable(
                name: "cariteminattip",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kod = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    ad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__caritemi__3213E83F4DA80363", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cekhrk",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sil = table.Column<int>(type: "int", nullable: false),
                    cekid = table.Column<double>(type: "float", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    drm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    drmad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    gctip = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    yertip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    yerad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    tutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    ack = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    cartip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    carkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    belno = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    gidkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    gidtutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    tahcartip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    tahcarkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    cartip_id = table.Column<byte>(type: "tinyint", nullable: true),
                    car_id = table.Column<int>(type: "int", nullable: true),
                    hrk_no = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Aktif = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__cekhrk__9E5BBA1BF3031C02", x => new { x.id, x.cekid, x.sil });
                });

            migrationBuilder.CreateTable(
                name: "CekKarne",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Bank_id = table.Column<int>(type: "int", nullable: true),
                    Bank_kod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CekSeriNo = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Drm = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CekKarne__3213E83F1D37BDB8", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cekkart",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    islmtip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    cekid = table.Column<double>(type: "float", nullable: false),
                    firmaid = table.Column<int>(type: "int", nullable: true),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    varno = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    varok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    firmano = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    cartip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    carkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    vercartip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    vercarkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    gctip = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    yertip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    yerad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    drm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    drmad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    islmtipad = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    islmhrk = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    cikan = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    giren = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    islmhrkad = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ceksenno = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    banka = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    banksub = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    hesepno = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    refno = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    kesideci = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ack = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    vadetar = table.Column<DateTime>(type: "datetime", nullable: true),
                    odetar = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    masterid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    perkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    adaid = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    kur = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    takvertar = table.Column<DateTime>(type: "datetime", nullable: true),
                    cirotar = table.Column<DateTime>(type: "datetime", nullable: true),
                    taktahtar = table.Column<DateTime>(type: "datetime", nullable: true),
                    eltahtar = table.Column<DateTime>(type: "datetime", nullable: true),
                    sonuc = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    geraltar = table.Column<DateTime>(type: "datetime", nullable: true),
                    iadetar = table.Column<DateTime>(type: "datetime", nullable: true),
                    pro = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    fisfattip = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true, defaultValue: "KENDI"),
                    fisfatid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    hrkid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    belno = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    gidkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    gidtutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    tahcartip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    tahcarkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    fisid = table.Column<int>(type: "int", nullable: true),
                    bankod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    cekkaskod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    fatid = table.Column<int>(type: "int", nullable: true),
                    tahodeid = table.Column<int>(type: "int", nullable: true),
                    cartip_id = table.Column<byte>(type: "tinyint", nullable: true),
                    car_id = table.Column<int>(type: "int", nullable: true),
                    vercartip_id = table.Column<byte>(type: "tinyint", nullable: true),
                    vercar_id = table.Column<int>(type: "int", nullable: true),
                    remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Sonuc_Tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    devir = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    CekSeriNo_id = table.Column<int>(type: "int", nullable: true),
                    Entegre = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__cekkart__408AE7E5A306C0F7", x => new { x.id, x.islmtip, x.cekid });
                });

            migrationBuilder.CreateTable(
                name: "cektip",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kod = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    ad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "dagitim_Firma",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__dagitim___3213E83FE4CB527A", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "depokart",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    sil = table.Column<int>(type: "int", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    deptip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    perkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    drm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Tip_id = table.Column<int>(type: "int", nullable: true, defaultValue: 2)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__depokart__E033B95B8B154C29", x => new { x.id, x.kod, x.sil });
                });

            migrationBuilder.CreateTable(
                name: "EBelge_Entegrator",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WebServis = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "EBelge_Seri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firmano = table.Column<int>(type: "int", nullable: true),
                    EBelgeTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    EntegratorId = table.Column<int>(type: "int", nullable: true),
                    EntegratorSeri = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    EntegratorBayiNo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true, defaultValue: ""),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    OlusUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    OlusTarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DegTarSaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__EBelge_S__3214EC07A5D08FBE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EBelge_Tip",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "EFatura_Brm",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Ad = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "EFatura_Gelen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EFaturaTip = table.Column<int>(type: "int", nullable: true),
                    GUID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Firmano = table.Column<int>(type: "int", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    TCVKNTip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TCVKNNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Unvan = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Tur = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Tip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Durum = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DurumHata = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    BelgeNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    GenelToplam = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    OlusUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    OlusTarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    AktarUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AktarTarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    FatTip = table.Column<int>(type: "int", nullable: true),
                    CarTip_Id = table.Column<int>(type: "int", nullable: true),
                    Car_Id = table.Column<int>(type: "int", nullable: true),
                    Rap_Id = table.Column<int>(type: "int", nullable: true),
                    DepoTipID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    GenelOtvToplam = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    GenelIskToplam = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    GenelKdvToplam = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    EntegreId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    EntegreTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    VadeTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    IrsaliyeIdIn = table.Column<string>(type: "varchar(800)", unicode: false, maxLength: 800, nullable: true),
                    Aciklama = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__EFatura___3214EC07B6E65636", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EFatura_Gelen_Hrk",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EFatId = table.Column<int>(type: "int", nullable: true),
                    Firmano = table.Column<int>(type: "int", nullable: true),
                    SiraNo = table.Column<int>(type: "int", nullable: true),
                    Ad = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Miktar = table.Column<double>(type: "float", nullable: true),
                    Birim = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Fiyat = table.Column<double>(type: "float", nullable: true),
                    IskYuz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    KdvYuz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Carpan = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    OlusUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    OlusTarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DegTarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Stk_Tip = table.Column<int>(type: "int", nullable: true, defaultValue: 2),
                    Stk_Id = table.Column<int>(type: "int", nullable: true),
                    DepoTipID = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Stk_UniqueId = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EFaturaMiktar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    EFaturaFiyat = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Barkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Kesafet = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    EFaturaBirim = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__EFatura___3214EC070AB1DF56", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EFatura_Tip",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    WebServis = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "emtiasat",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    emtid = table.Column<double>(type: "float", nullable: false),
                    varno = table.Column<double>(type: "float", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    perkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    adaid = table.Column<int>(type: "int", nullable: true),
                    stktip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    islmtip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    islmtipad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    yertip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    yerad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    depkod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    stktipad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    stkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    mik = table.Column<double>(type: "float", nullable: true),
                    brmfiy = table.Column<double>(type: "float", nullable: true),
                    tutar = table.Column<double>(type: "float", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    kdvyuz = table.Column<double>(type: "float", nullable: true),
                    varok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    belno = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ack = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    stktip_id = table.Column<int>(type: "int", nullable: true),
                    stk_id = table.Column<int>(type: "int", nullable: true),
                    Fis_id = table.Column<int>(type: "int", nullable: true),
                    Gec_PerKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__emtiasat__5B9C90C9D1CCE6F7", x => new { x.id, x.varno, x.emtid });
                });

            migrationBuilder.CreateTable(
                name: "Entegre",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    tip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    beg = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    host = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    users = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    pass = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    dataname = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Entegre__3213E83FA94A41C9", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "entegre_muh_hes_kod",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true),
                    tip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    kod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ack = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    deger = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    kdv_oran = table.Column<double>(type: "float", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__entegre___3213E83FB046565D", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "epostaayar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gonad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    gonposta = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    host = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    kulkod = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    sif = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    alad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    alposta = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    sms_sunucu = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    sms_firma_kod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    sms_kul_kod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    sms_sifre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    sms_alici_cepno = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    sms_tip = table.Column<int>(type: "int", nullable: true),
                    PostaGidenPort = table.Column<int>(type: "int", nullable: true, defaultValue: 587),
                    PostaSifreleme = table.Column<int>(type: "int", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Evrak_Not",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Table_Ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    mas_id = table.Column<int>(type: "int", nullable: true),
                    ack = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    olususer = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Evrak_No__3213E83F61800409", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Fat_Dep",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fatid = table.Column<int>(type: "int", nullable: true),
                    FatHrk_id = table.Column<int>(type: "int", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Saat = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Sr = table.Column<int>(type: "int", nullable: true),
                    cfirmano = table.Column<int>(type: "int", nullable: true),
                    gfirmano = table.Column<int>(type: "int", nullable: true),
                    Cdepkod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Gdepkod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CStktip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    GStktip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    CStktip_id = table.Column<int>(type: "int", nullable: true),
                    GStktip_id = table.Column<int>(type: "int", nullable: true),
                    CStk_id = table.Column<int>(type: "int", nullable: true),
                    GStk_id = table.Column<int>(type: "int", nullable: true),
                    CStk_kod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    GStk_kod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Miktar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Yerad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Yertip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Sil = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    olususer = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Belno = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ack = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Fat_Dep__3213E83FC6289252", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Fat_Grs_Alan_Tip",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tip_id = table.Column<int>(type: "int", nullable: true),
                    Tab = table.Column<int>(type: "int", nullable: true),
                    ack_tr = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    ack_en = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    ack_al = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    ack_ru = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Fat_Grs___3213E83F2FABE6DB", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "fattip",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    gctip = table.Column<byte>(type: "tinyint", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    tip = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    tur_id = table.Column<int>(type: "int", nullable: true),
                    gc = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Gizli = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__fattip__3213E83F87D526FF", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Fatura_Tur",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ack_tr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ack_en = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ack_al = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ack_ru = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Fatura_T__3213E83FE6E1731E", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "faturahrk",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fatid = table.Column<double>(type: "float", nullable: false),
                    sil = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    stktip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    stkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    mik = table.Column<double>(type: "float", nullable: true),
                    brmfiy = table.Column<double>(type: "float", nullable: true),
                    depkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    kdvyuz = table.Column<double>(type: "float", nullable: true),
                    kdvtut = table.Column<double>(type: "float", nullable: true),
                    kdvtip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true, defaultValue: "Hayır"),
                    brim = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    satiskyuz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    satisktut = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    otvyuz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    otvtut = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    genisktut = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    geniskyuz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    ustbrim = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    carpan = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    parabrim = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    kur = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    otvbrim = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    grupid = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    kayok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    kaphrkid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    kaptip = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true, defaultValue: "FAT"),
                    giderbrmtut = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    kesafet = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    hrk_stk_pro = table.Column<bool>(type: "bit", nullable: true),
                    ak_isk_yuz = table.Column<double>(type: "float", nullable: true),
                    ak_isk_tut = table.Column<double>(type: "float", nullable: true),
                    mr_isk_yuz = table.Column<double>(type: "float", nullable: true),
                    mr_isk_tut = table.Column<double>(type: "float", nullable: true),
                    stktip_id = table.Column<int>(type: "int", nullable: true),
                    stk_id = table.Column<int>(type: "int", nullable: true),
                    dep_id = table.Column<int>(type: "int", nullable: true),
                    Kart_ParaBrm = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Kart_Kur = table.Column<double>(type: "float", nullable: true),
                    Islem_ParaBrm = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Islem_Kur = table.Column<double>(type: "float", nullable: true),
                    gg_isk_yuz = table.Column<double>(type: "float", nullable: true),
                    gg_isk_tut = table.Column<double>(type: "float", nullable: true),
                    masraf_yuz = table.Column<double>(type: "float", nullable: true),
                    masraf_tut = table.Column<double>(type: "float", nullable: true),
                    barkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    top_isk_yuz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    top_isk_tut = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    remote_id = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    top_kdv_tut = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    top_tut_kdvsiz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    top_tut_isk_kdvsiz = table.Column<double>(type: "float", nullable: true),
                    top_tut_isk_kdvli = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Otv_Carpan = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    ack = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Net_Miktar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    OtoTag = table.Column<int>(type: "int", nullable: true),
                    Tesis_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Tesis_AlisFiyat = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Tesis_PrimOran = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Tesis_Fiyat = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    satisktip = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValue: "%"),
                    KdvTevkifatId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    KdvTevkifatYuzde = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    KdvTevkifatTutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__faturahr__D918C0DEB990ED93", x => new { x.id, x.fatid });
                });

            migrationBuilder.CreateTable(
                name: "faturahrk_temp",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    fatid = table.Column<double>(type: "float", nullable: false),
                    sil = table.Column<double>(type: "float", nullable: true),
                    firmano = table.Column<int>(type: "int", nullable: true),
                    stktip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    stkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    mik = table.Column<double>(type: "float", nullable: true),
                    brmfiy = table.Column<double>(type: "float", nullable: true),
                    depkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    kdvyuz = table.Column<double>(type: "float", nullable: true),
                    kdvtut = table.Column<double>(type: "float", nullable: true),
                    kdvtip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    brim = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    satiskyuz = table.Column<double>(type: "float", nullable: true),
                    satisktut = table.Column<double>(type: "float", nullable: true),
                    otvyuz = table.Column<double>(type: "float", nullable: true),
                    otvtut = table.Column<double>(type: "float", nullable: true),
                    genisktut = table.Column<double>(type: "float", nullable: true),
                    geniskyuz = table.Column<double>(type: "float", nullable: true),
                    ustbrim = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    carpan = table.Column<double>(type: "float", nullable: true),
                    parabrim = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    kur = table.Column<double>(type: "float", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true),
                    otvbrim = table.Column<double>(type: "float", nullable: true),
                    grupid = table.Column<int>(type: "int", nullable: true),
                    kayok = table.Column<int>(type: "int", nullable: true),
                    kaphrkid = table.Column<double>(type: "float", nullable: true),
                    kaptip = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    giderbrmtut = table.Column<double>(type: "float", nullable: true),
                    kesafet = table.Column<double>(type: "float", nullable: true),
                    hrk_stk_pro = table.Column<bool>(type: "bit", nullable: true),
                    ak_isk_yuz = table.Column<double>(type: "float", nullable: true),
                    ak_isk_tut = table.Column<double>(type: "float", nullable: true),
                    mr_isk_yuz = table.Column<double>(type: "float", nullable: true),
                    mr_isk_tut = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__faturahr__D918C0DE6B4C5DD9", x => new { x.id, x.fatid });
                });

            migrationBuilder.CreateTable(
                name: "FaturaIadeDetay",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FatId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    BelgeNo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlusturmaTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlusturmaKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DegistirmeTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegistirmeKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SilTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    SilKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    RemoteId = table.Column<int>(type: "int", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tasiyici__3213E83F5920D841_IadeFaturaDetay", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "faturamas",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fatid = table.Column<double>(type: "float", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    fatad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fattip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    fattur = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    fatturad = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    fatseri = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    fatno = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cartip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    carkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    ack = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    geniskyuz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    genisktop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    satisktop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    kdvtop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    yuvtop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    gidertop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    giderkdvtop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    fattop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    otvtop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    kdvtip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    vadtar = table.Column<DateTime>(type: "datetime", nullable: true),
                    depo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    irsaliyeirid = table.Column<double>(type: "float", nullable: true),
                    siparissipid = table.Column<double>(type: "float", nullable: true),
                    kayok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    kur = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    kaptip = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true, defaultValue: "FAT"),
                    odemetop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    marsatid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    yazildi = table.Column<bool>(type: "bit", nullable: true),
                    kapidler = table.Column<string>(type: "varchar(8000)", unicode: false, maxLength: 8000, nullable: true),
                    gen_ind_tip = table.Column<byte>(type: "tinyint", nullable: true),
                    entegre_aktar = table.Column<DateTime>(type: "datetime", nullable: true),
                    entegre_tip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    yertip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    yerad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ykfisno = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    genel_top = table.Column<double>(type: "float", nullable: true),
                    kilit = table.Column<bool>(type: "bit", nullable: true),
                    hrk_car_pro = table.Column<bool>(type: "bit", nullable: true),
                    hrk_stk_pro = table.Column<bool>(type: "bit", nullable: true),
                    plaka = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    genel_isk_top = table.Column<double>(type: "float", nullable: true),
                    isk_tip = table.Column<byte>(type: "tinyint", nullable: true),
                    ak_isk_tip = table.Column<byte>(type: "tinyint", nullable: true),
                    ak_isk_yuz = table.Column<double>(type: "float", nullable: true),
                    ak_isk_top = table.Column<double>(type: "float", nullable: true),
                    mr_isk_tip = table.Column<byte>(type: "tinyint", nullable: true),
                    mr_isk_yuz = table.Column<double>(type: "float", nullable: true),
                    mr_isk_top = table.Column<double>(type: "float", nullable: true),
                    gn_matrah = table.Column<double>(type: "float", nullable: true),
                    ak_matrah = table.Column<double>(type: "float", nullable: true),
                    mr_matrah = table.Column<double>(type: "float", nullable: true),
                    genel_kdv_top = table.Column<double>(type: "float", nullable: true),
                    genel_ara_top = table.Column<double>(type: "float", nullable: true),
                    irs_no = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    gctip = table.Column<int>(type: "int", nullable: true),
                    fattip_id = table.Column<int>(type: "int", nullable: true),
                    fattur_id = table.Column<int>(type: "int", nullable: true),
                    fatrap_id = table.Column<int>(type: "int", nullable: true),
                    car_id = table.Column<int>(type: "int", nullable: true),
                    cartip_id = table.Column<int>(type: "int", nullable: true),
                    Kart_ParaBrm = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Kart_Kur = table.Column<double>(type: "float", nullable: true),
                    Islem_ParaBrm = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Islem_Kur = table.Column<double>(type: "float", nullable: true),
                    gg_matrah = table.Column<double>(type: "float", nullable: true),
                    gg_isk_tip = table.Column<byte>(type: "tinyint", nullable: true),
                    gg_isk_yuz = table.Column<double>(type: "float", nullable: true),
                    gg_isk_top = table.Column<double>(type: "float", nullable: true),
                    KdvOran1 = table.Column<double>(type: "float", nullable: true),
                    KdvTutar1 = table.Column<double>(type: "float", nullable: true),
                    KdvOran2 = table.Column<double>(type: "float", nullable: true),
                    KdvTutar2 = table.Column<double>(type: "float", nullable: true),
                    KdvOran3 = table.Column<double>(type: "float", nullable: true),
                    KdvTutar3 = table.Column<double>(type: "float", nullable: true),
                    KdvOran4 = table.Column<double>(type: "float", nullable: true),
                    KdvTutar4 = table.Column<double>(type: "float", nullable: true),
                    KdvOran5 = table.Column<double>(type: "float", nullable: true),
                    KdvTutar5 = table.Column<double>(type: "float", nullable: true),
                    remote_id = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    genel_net_top = table.Column<double>(type: "float", nullable: true),
                    prom_pro = table.Column<bool>(type: "bit", nullable: true),
                    Varno = table.Column<double>(type: "float", nullable: true),
                    Odeme = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Karsi_Cartip_id = table.Column<int>(type: "int", nullable: true),
                    Karsi_Car_id = table.Column<int>(type: "int", nullable: true),
                    Hrk_Karsi_Pro = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Dep_Dag = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Entegre = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    EFatura = table.Column<bool>(type: "bit", nullable: true),
                    EFatura_Tip = table.Column<int>(type: "int", nullable: true),
                    EFatura_Id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Efatura_Aktar = table.Column<DateTime>(type: "datetime", nullable: true),
                    Per_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    AvansTakip = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    EFaturaEFinansBelgeOId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    EBelgeTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    EBelgeSeriId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    EBelgeEntegrasyonId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    EBelgeGibSeriNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EBelgeMailTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    genel_kdv_tevkifat_top = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__faturama__D918C0DECE3B3CA6", x => new { x.id, x.fatid });
                });

            migrationBuilder.CreateTable(
                name: "faturamas_temp",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    fatid = table.Column<double>(type: "float", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    fatad = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    fattip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    fattur = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    fatturad = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    fatseri = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    fatno = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    cartip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    carkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    ack = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    geniskyuz = table.Column<double>(type: "float", nullable: true),
                    genisktop = table.Column<double>(type: "float", nullable: true),
                    satisktop = table.Column<double>(type: "float", nullable: true),
                    kdvtop = table.Column<double>(type: "float", nullable: true),
                    yuvtop = table.Column<double>(type: "float", nullable: true),
                    gidertop = table.Column<double>(type: "float", nullable: true),
                    giderkdvtop = table.Column<double>(type: "float", nullable: true),
                    fattop = table.Column<double>(type: "float", nullable: true),
                    otvtop = table.Column<double>(type: "float", nullable: true),
                    kdvtip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    vadtar = table.Column<DateTime>(type: "datetime", nullable: true),
                    depo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    sil = table.Column<int>(type: "int", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true),
                    irsaliyeirid = table.Column<double>(type: "float", nullable: true),
                    siparissipid = table.Column<double>(type: "float", nullable: true),
                    kayok = table.Column<int>(type: "int", nullable: true),
                    kur = table.Column<double>(type: "float", nullable: true),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    kaptip = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    odemetop = table.Column<double>(type: "float", nullable: true),
                    marsatid = table.Column<double>(type: "float", nullable: true),
                    yazildi = table.Column<bool>(type: "bit", nullable: true),
                    kapidler = table.Column<string>(type: "varchar(8000)", unicode: false, maxLength: 8000, nullable: true),
                    gen_ind_tip = table.Column<byte>(type: "tinyint", nullable: true),
                    entegre_aktar = table.Column<DateTime>(type: "datetime", nullable: true),
                    entegre_tip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    yertip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    yerad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ykfisno = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    genel_top = table.Column<double>(type: "float", nullable: true),
                    kilit = table.Column<bool>(type: "bit", nullable: true),
                    hrk_car_pro = table.Column<bool>(type: "bit", nullable: true),
                    hrk_stk_pro = table.Column<bool>(type: "bit", nullable: true),
                    plaka = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    genel_isk_top = table.Column<double>(type: "float", nullable: true),
                    isk_tip = table.Column<byte>(type: "tinyint", nullable: true),
                    ak_isk_tip = table.Column<byte>(type: "tinyint", nullable: true),
                    ak_isk_yuz = table.Column<double>(type: "float", nullable: true),
                    ak_isk_top = table.Column<double>(type: "float", nullable: true),
                    mr_isk_tip = table.Column<byte>(type: "tinyint", nullable: true),
                    mr_isk_yuz = table.Column<double>(type: "float", nullable: true),
                    mr_isk_top = table.Column<double>(type: "float", nullable: true),
                    gn_matrah = table.Column<double>(type: "float", nullable: true),
                    ak_matrah = table.Column<double>(type: "float", nullable: true),
                    mr_matrah = table.Column<double>(type: "float", nullable: true),
                    genel_kdv_top = table.Column<double>(type: "float", nullable: true),
                    genel_ara_top = table.Column<double>(type: "float", nullable: true),
                    irs_no = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__faturama__D918C0DE840AE63C", x => new { x.id, x.fatid });
                });

            migrationBuilder.CreateTable(
                name: "Filitre_Hrk",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sec = table.Column<bool>(type: "bit", nullable: true),
                    TanID = table.Column<int>(type: "int", nullable: true),
                    MasID = table.Column<int>(type: "int", nullable: true),
                    Deger = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    Sorgu_Str = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    Deger_Sorgu = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Filitre___3214EC079AEF3DEB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filitre_Mas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrpID = table.Column<int>(type: "int", nullable: true),
                    GrpAd = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlanAd = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AlanAck = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DegerTIP = table.Column<int>(type: "int", nullable: true),
                    Query_Table = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Query_Table_Sorgu = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Filitre___3214EC07A77C779A", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Firma",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    var_otomas = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    on_otomas = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Adres_1 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Adres_2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Tel_No = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Fax_No = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Logo_id = table.Column<int>(type: "int", nullable: true),
                    Kart_Ak_isle = table.Column<int>(type: "int", nullable: true),
                    Pv_AckFaz = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Mv_AckFaz = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Pv_Kasa = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Mv_Kasa = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Entegre_Tip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Entegre_FirmaNo = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Entegre_UserKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Entegre_UserSifre = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Entegre_ZraporOnMuhKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Entegre_ZraporMuhKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    EFatura_Tip = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Efatura_SirketKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Efatura_UserKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Efatura_UserSifre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EFatura_CariKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Entegre_Periot = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Entegre_PosCarMuhKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Entegre_PosGidMuhKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Entegre_PosCarOnMuhKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Entegre_PosGidOnMuhKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Efatura_Seri = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Entegre_SubeNo = table.Column<int>(type: "int", nullable: true),
                    Entegre_BankGidOnMuhKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Entegre_BankGidMuhKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Efatura_IngFaturaNo = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    Earsiv_UserKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Earsiv_UserSifre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Earsiv_Sube = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Earsiv_Kasa = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FatIskGiderKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FisIskGiderKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MarketSatisParaBirim = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    MarketSatisParaBirim1 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    MarketSatisParaBirim2 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    MarketSatisParaBirim3 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    MarketSatisParaBirim4 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ZraporCariKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EFatura_EsasBirim = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    Earsiv_SirketKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EArsiv_EntegratorId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    EFatura_EntegratorId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    EArsiv_FaturaNo = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    EIrsaliye_EntegratorId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    EIrsaliye_UserKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    EIrsaliye_UserSifre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EIrsaliye_SirketKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EIrsaliye_FaturaNo = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    EntegreMarketKdv0OnMuhKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EntegreMarketKdv1OnMuhKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EntegreMarketKdv8OnMuhKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EntegreMarketKdv18OnMuhKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EntegreDepartmanKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BulutTahsilatEntegratorId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    BulutTahsilatSirketKod = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    BulutTahsilatUserKod = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    BulutTahsilatUserSifre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MarketSatisPosKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Firma__3213E83F53F47E94", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "fismas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fisid = table.Column<int>(type: "int", nullable: true),
                    fisno = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    cartip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    carkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    toptut = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    yertip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ack = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true),
                    firmano = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__fismas__3213E83F58CEC241", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "frm",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true),
                    bolumid = table.Column<int>(type: "int", nullable: true),
                    frm = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    frmtr = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    frmen = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    yetkialan = table.Column<bool>(type: "bit", nullable: true),
                    sfirmano = table.Column<int>(type: "int", nullable: true),
                    havuz = table.Column<bool>(type: "bit", nullable: true),
                    anaformnesne = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modul = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "frmkont",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true),
                    bolumid = table.Column<int>(type: "int", nullable: true),
                    frmid = table.Column<int>(type: "int", nullable: true),
                    kont = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    konttr = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    konten = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    yetkialan = table.Column<bool>(type: "bit", nullable: true),
                    sfirmano = table.Column<int>(type: "int", nullable: true),
                    havuz = table.Column<bool>(type: "bit", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    anafrmid = table.Column<int>(type: "int", nullable: true),
                    fat_fis_kont_id = table.Column<int>(type: "int", nullable: true),
                    Modul = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    kont_menu = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Rap_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "gelgidkart",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sil = table.Column<int>(type: "int", nullable: false),
                    kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    ad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    drm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    grp1 = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    grp2 = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    grp3 = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    fisbak = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    carbak = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    muhkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    fiyat = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    toplim = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    kdvtip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    kdv = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    brim = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    fisaktut = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    fisadet = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    fisakadet = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    actutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    gizli = table.Column<bool>(type: "bit", nullable: true),
                    muhonkod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    tip_id = table.Column<int>(type: "int", nullable: true),
                    Prom = table.Column<bool>(type: "bit", nullable: true),
                    Puan_Brm = table.Column<double>(type: "float", nullable: true),
                    Puan_Tip = table.Column<byte>(type: "tinyint", nullable: true),
                    Puan_Nakit = table.Column<double>(type: "float", nullable: true),
                    Puan_KK = table.Column<double>(type: "float", nullable: true),
                    Puan_Fis = table.Column<double>(type: "float", nullable: true),
                    Prom_Sat_Puan = table.Column<double>(type: "float", nullable: true),
                    Prom_Urun = table.Column<bool>(type: "bit", nullable: true),
                    Prom_Sat_Tip = table.Column<byte>(type: "tinyint", nullable: true),
                    Prom_Kac_Satis = table.Column<int>(type: "int", nullable: true),
                    limit_tip = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Remote_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__gelgidka__E033B95BE69A79EA", x => new { x.id, x.kod, x.sil });
                });

            migrationBuilder.CreateTable(
                name: "genelrap_goster",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: true),
                    ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Goster = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Grafik_Rap_Goster",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: true),
                    Tip = table.Column<int>(type: "int", nullable: true),
                    Ack_Tr = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Ack_En = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Goster = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "grup",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tabload = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    sr = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    grp1 = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    grp2 = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    ad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    kar1 = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    kar2 = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    kdv = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    ykkisno = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true, defaultValue: ""),
                    kar3 = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    kar4 = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    muhgrskod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    muhckskod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    muh_als_iad_kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    muh_sat_iad_kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    muh_als_isk_kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    muh_sat_isk_kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    muh_als_otv_kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    muh_sat_otv_kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    muh_sat_mal_kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    muhonkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Restaurant = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    PerIDIN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Calisma_SartId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    MuhasebeGrupKodu = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    YkKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Yerli = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    UretimYerId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    UserIdIn = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Kod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__grup__379B761F35D3D0F6", x => new { x.id, x.tabload });
                });

            migrationBuilder.CreateTable(
                name: "Gunlukrap_Goster",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: true),
                    ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Goster = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Harici_Kart",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tip_id = table.Column<int>(type: "int", nullable: true),
                    tip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    kod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    cartip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    parabrm = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    sil = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Harici_K__3213E83F127755F8", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Hrk_Grup_Kriter",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<int>(type: "int", nullable: true),
                    Ack_Tr = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: true),
                    Tip = table.Column<int>(type: "int", nullable: true),
                    Genel = table.Column<int>(type: "int", nullable: true, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Hrk_Grup__3213E83F85EE369B", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Hrk_Kriter",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    raptip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    kod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    sec = table.Column<byte>(type: "tinyint", nullable: true),
                    User_Id = table.Column<int>(type: "int", nullable: true),
                    Firmano = table.Column<int>(type: "int", nullable: true),
                    Grp_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Hrk_Krit__3213E83F0A92C160", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "il",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kod = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__il__3213E83FC1B6D2F0", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ilce",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    anakod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    kod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ilce__3213E83F1FEB7FB4", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "irsaliyehrk",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    irid = table.Column<double>(type: "float", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    vadtar = table.Column<DateTime>(type: "datetime", nullable: true),
                    kdvtip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    stktip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    stkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    mik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    carpan = table.Column<double>(type: "float", nullable: true),
                    brim = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ustbrim = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    kdvyuz = table.Column<double>(type: "float", nullable: true),
                    kdvtut = table.Column<double>(type: "float", nullable: true),
                    depkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true, defaultValue: ""),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    grupid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    brmfiy = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sipid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    kayok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    parabrim = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    kur = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    stktip_id = table.Column<int>(type: "int", nullable: true),
                    stk_id = table.Column<int>(type: "int", nullable: true),
                    dep_id = table.Column<int>(type: "int", nullable: true),
                    Kart_ParaBrm = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Kart_Kur = table.Column<double>(type: "float", nullable: true),
                    Islem_ParaBrm = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Islem_Kur = table.Column<double>(type: "float", nullable: true),
                    otvbrim = table.Column<double>(type: "float", nullable: true),
                    kesafet = table.Column<double>(type: "float", nullable: true),
                    barkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    remote_id = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    satiskyuz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    satisktut = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    geniskyuz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    genisktut = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    AppSiraNo = table.Column<int>(type: "int", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__irsaliye__AB4860DBC96FBEC2", x => new { x.id, x.irid });
                });

            migrationBuilder.CreateTable(
                name: "irsaliyemas",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    irid = table.Column<double>(type: "float", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    kayok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    irtip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    irad = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    irturad = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    irtur = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    irseri = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    irno = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    vadtar = table.Column<DateTime>(type: "datetime", nullable: true),
                    kdvtip = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    ack = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    kdvtut = table.Column<double>(type: "float", nullable: true),
                    depo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    irtop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    kdvtop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    cartip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    carkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    aktip = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true, defaultValue: "BK"),
                    akid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    aktar = table.Column<DateTime>(type: "datetime", nullable: true),
                    fatid = table.Column<long>(type: "bigint", nullable: true),
                    sevktar = table.Column<DateTime>(type: "datetime", nullable: true),
                    yertip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    yerad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    gctip = table.Column<int>(type: "int", nullable: true),
                    irstip_id = table.Column<int>(type: "int", nullable: true),
                    irstur_id = table.Column<int>(type: "int", nullable: true),
                    irsrap_id = table.Column<int>(type: "int", nullable: true),
                    car_id = table.Column<int>(type: "int", nullable: true),
                    cartip_id = table.Column<int>(type: "int", nullable: true),
                    hrk_car_pro = table.Column<bool>(type: "bit", nullable: true),
                    hrk_stk_pro = table.Column<bool>(type: "bit", nullable: true),
                    Kart_ParaBrm = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Kart_Kur = table.Column<double>(type: "float", nullable: true),
                    Islem_ParaBrm = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Islem_Kur = table.Column<double>(type: "float", nullable: true),
                    genel_ara_top = table.Column<double>(type: "float", nullable: true),
                    genel_top = table.Column<double>(type: "float", nullable: true),
                    genel_kdv_top = table.Column<double>(type: "float", nullable: true),
                    yuvtop = table.Column<double>(type: "float", nullable: true),
                    remote_id = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    genel_net_top = table.Column<double>(type: "float", nullable: true),
                    Entegre_Tip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Entegre_Aktar = table.Column<DateTime>(type: "datetime", nullable: true),
                    Plaka = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Sofor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EBelgeTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    EBelgeSeriId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Entegre = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    EBelgeEntegrasyonId = table.Column<int>(type: "int", nullable: true),
                    EBelgeId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    EBelgeEntegrasyonTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    EBelgeGibSeriNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EBelgeMailTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    EBelgeEntegrasyon = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    EBelgeTasiyiciFirmaId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    EBelgeSoforId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    SevkSaat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    EBelgeTeslimYerId = table.Column<int>(type: "int", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__irsaliye__AB4860DB76BA7263", x => new { x.id, x.irid });
                });

            migrationBuilder.CreateTable(
                name: "islemhrktip",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    tip = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    hrk = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    gc = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__islemhrk__3213E83F683DD5C0", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "islemturtip",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tip = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__islemtur__3213E83FE6F7A32E", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "istkart",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: false),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    bankod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    sahibi = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    muhkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    lim = table.Column<double>(type: "float", nullable: true),
                    sonkultar = table.Column<DateTime>(type: "datetime", nullable: true),
                    heskesgun = table.Column<double>(type: "float", nullable: true),
                    hessongun = table.Column<double>(type: "float", nullable: true),
                    drm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    karttur = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    borc = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    alacak = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    actutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    muhonkod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__istkart__DFEE6686F8B80E13", x => new { x.id, x.kod });
                });

            migrationBuilder.CreateTable(
                name: "istkhrk",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: false),
                    istkhrkid = table.Column<double>(type: "float", nullable: false),
                    istkkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    varno = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    varok = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    gctip = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    perkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    adaid = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    islmtip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    islmtipad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    islmhrk = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    islmhrkad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    yertip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    yerad = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    masterid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    vadetar = table.Column<DateTime>(type: "datetime", nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    carslip = table.Column<int>(type: "int", nullable: true),
                    cartip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cartur = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    carkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    borc = table.Column<double>(type: "float", nullable: true),
                    alacak = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    ack = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    belno = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    kur = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    fisfattip = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true, defaultValue: "KENDI"),
                    fisfatid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    karsihestip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    karsiheskod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    fisid = table.Column<int>(type: "int", nullable: true),
                    fatid = table.Column<int>(type: "int", nullable: true),
                    tahodeid = table.Column<int>(type: "int", nullable: true),
                    iskk_id = table.Column<int>(type: "int", nullable: true),
                    cartip_id = table.Column<byte>(type: "tinyint", nullable: true),
                    car_id = table.Column<int>(type: "int", nullable: true),
                    belrap_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    istkk_id = table.Column<long>(type: "bigint", nullable: true),
                    remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    rg = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)1),
                    devir = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Karsi_KartTip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Karsi_KartKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Entegre = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferDateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__istkhrk__D2897F62AB882B78", x => new { x.id, x.istkhrkid, x.istkkod, x.firmano });
                });

            migrationBuilder.CreateTable(
                name: "kartsumalan",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tabload = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    alanad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__kartsuma__3213E83F82392546", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "karttip",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__karttip__3213E83F020B9412", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "kasa_kapa",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: false),
                    kaskod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: false),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    kapat = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    kasa_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__kasa_kap__3213E83F814B7F0F", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "kasa_kapat",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: false),
                    kaskod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: false),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    drm = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    kasa_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__kasa_kap__3213E83F726A9085", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "kasahrk",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kaskod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    kashrkid = table.Column<double>(type: "float", nullable: false),
                    varno = table.Column<double>(type: "float", nullable: false),
                    masterid = table.Column<double>(type: "float", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    gctip = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    varok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    islmtip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    islmtipad = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    islmhrk = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    islmhrkad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    yertip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    yerad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    perkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    adaid = table.Column<int>(type: "int", nullable: true),
                    giren = table.Column<decimal>(type: "decimal(38,8)", nullable: true, defaultValue: 0m),
                    cikan = table.Column<decimal>(type: "decimal(38,8)", nullable: true, defaultValue: 0m),
                    bakiye = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    carkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cartip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    belno = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ack = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    kur = table.Column<double>(type: "float", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    pro = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    fisfattip = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true, defaultValue: "KENDI"),
                    fisfatid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    karsihestip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    karsiheskod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    fisid = table.Column<int>(type: "int", nullable: true),
                    entegre_aktar = table.Column<DateTime>(type: "datetime", nullable: true),
                    entegre_tip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    fatid = table.Column<int>(type: "int", nullable: true),
                    tahodeid = table.Column<int>(type: "int", nullable: true),
                    kas_id = table.Column<int>(type: "int", nullable: true),
                    cartip_id = table.Column<byte>(type: "tinyint", nullable: true),
                    car_id = table.Column<int>(type: "int", nullable: true),
                    remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    vadetar = table.Column<DateTime>(type: "datetime", nullable: true),
                    MarBozukPara_id = table.Column<int>(type: "int", nullable: true),
                    rg = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)1),
                    Banknot = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    cekid = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Gec_PerKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    devir = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Karsi_KartTip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Karsi_KartKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Entegre = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Transfer = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Transfer_TarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    CariAvans = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    TopluKayitId = table.Column<int>(type: "int", nullable: true),
                    TopluKayitHrkId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__kasahrk__6276BA827E11A768", x => new { x.id, x.varno, x.masterid, x.kaskod, x.kashrkid });
                });

            migrationBuilder.CreateTable(
                name: "kasakart",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tip = table.Column<int>(type: "int", nullable: false),
                    kod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    firmano = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    giren = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    cikan = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sr = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    muhkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    muhonkod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    cekmuhkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Ac_Tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserIdIn = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__kasakart__ED3276DD50DE6573", x => new { x.id, x.kod, x.tip });
                });

            migrationBuilder.CreateTable(
                name: "kdv_oran",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true),
                    oran = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__kdv_oran__3213E83FF9E54ADB", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "KDVTevkifat_Tip",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Kod = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    Ad = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Yuzde = table.Column<int>(type: "int", nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KDVTevki__3214EC07931B5A56", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "kriterkayit",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    form = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    users = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    cekin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    slipin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    alisfatin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    satfatin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fisin = table.Column<string>(type: "varchar(8000)", unicode: false, maxLength: 8000, nullable: true),
                    carigrupin = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    ch_bak_sifir = table.Column<bool>(type: "bit", nullable: true),
                    ch_tarih = table.Column<bool>(type: "bit", nullable: true),
                    ch_devir = table.Column<bool>(type: "bit", nullable: true),
                    fat_ort_brm = table.Column<bool>(type: "bit", nullable: true),
                    Var_Basin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Nesne_Tip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Nesne_Ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Nesne_Deger = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ch_yazdir = table.Column<bool>(type: "bit", nullable: true),
                    vad_krd = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__kriterka__3213E83FD78C431F", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "kurgrs",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    tar = table.Column<DateTime>(type: "datetime", nullable: true),
                    ytl = table.Column<double>(type: "float", nullable: true),
                    usd = table.Column<double>(type: "float", nullable: true),
                    euro = table.Column<double>(type: "float", nullable: true),
                    gbp = table.Column<double>(type: "float", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__kurgrs__3213E83FDFF0D4A1", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Log_Fatura",
                columns: table => new
                {
                    LogId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<long>(type: "bigint", nullable: true),
                    BayiId = table.Column<int>(type: "int", nullable: false),
                    KartTipId = table.Column<int>(type: "int", nullable: true),
                    KartId = table.Column<int>(type: "int", nullable: true),
                    TarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    RaporId = table.Column<int>(type: "int", nullable: true),
                    GenelTipId = table.Column<int>(type: "int", nullable: true),
                    IslemTipId = table.Column<int>(type: "int", nullable: true),
                    FaturaAd = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    FaturaSeri = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FaturaNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ToplamKdvTutar = table.Column<double>(type: "float", nullable: true),
                    ToplamAraTutar = table.Column<double>(type: "float", nullable: true),
                    ToplamIskontoTutar = table.Column<double>(type: "float", nullable: true),
                    ToplamNetTutar = table.Column<double>(type: "float", nullable: true),
                    ToplamGenelTutar = table.Column<double>(type: "float", nullable: true),
                    YuvarlamaTutar = table.Column<double>(type: "float", nullable: true),
                    GiderToplam = table.Column<double>(type: "float", nullable: true),
                    GiderKdvToplam = table.Column<double>(type: "float", nullable: true),
                    OtvToplam = table.Column<double>(type: "float", nullable: true),
                    KdvTipId = table.Column<int>(type: "int", nullable: true),
                    VadeTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Kur = table.Column<double>(type: "float", nullable: true),
                    ParaBirimId = table.Column<int>(type: "int", nullable: true),
                    KapTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    OdemeToplam = table.Column<double>(type: "float", nullable: true),
                    YazarKasaFisno = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Kilit = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    HareketCariYaz = table.Column<bool>(type: "bit", nullable: true),
                    HareketStokYaz = table.Column<bool>(type: "bit", nullable: true),
                    Plaka = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    GenelIskontoYuzde = table.Column<double>(type: "float", nullable: true),
                    GenelIskontoTutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    GenelMatrah = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    AkaryakitIskontoYuzde = table.Column<double>(type: "float", nullable: true),
                    AkaryakitIskontoTutar = table.Column<double>(type: "float", nullable: true),
                    AkaryakitMatrah = table.Column<double>(type: "float", nullable: true),
                    MarketIskontoYuzde = table.Column<double>(type: "float", nullable: true),
                    MarketIskontoTutar = table.Column<double>(type: "float", nullable: true),
                    MarketMatrah = table.Column<double>(type: "float", nullable: true),
                    KartParaBirimId = table.Column<int>(type: "int", nullable: true),
                    KartKur = table.Column<double>(type: "float", nullable: true),
                    IslemParaBirimId = table.Column<int>(type: "int", nullable: true),
                    IslemKur = table.Column<double>(type: "float", nullable: true),
                    KdvOran1 = table.Column<double>(type: "float", nullable: true),
                    KdvTutar1 = table.Column<double>(type: "float", nullable: true),
                    KdvOran2 = table.Column<double>(type: "float", nullable: true),
                    KdvTutar2 = table.Column<double>(type: "float", nullable: true),
                    KdvOran3 = table.Column<double>(type: "float", nullable: true),
                    KdvTutar3 = table.Column<double>(type: "float", nullable: true),
                    KdvOran4 = table.Column<double>(type: "float", nullable: true),
                    KdvTutar4 = table.Column<double>(type: "float", nullable: true),
                    KdvOran5 = table.Column<double>(type: "float", nullable: true),
                    KdvTutar5 = table.Column<double>(type: "float", nullable: true),
                    VardiyaId = table.Column<int>(type: "int", nullable: true),
                    Odeme = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    KarsiKartTipId = table.Column<int>(type: "int", nullable: true),
                    KarsiKartId = table.Column<int>(type: "int", nullable: true),
                    KayitDurum = table.Column<bool>(type: "bit", nullable: false),
                    EFaturaTipId = table.Column<int>(type: "int", nullable: true),
                    EFaturaNo = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    EFaturaId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    EFaturaAktarimTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    EntegreTipId = table.Column<int>(type: "int", nullable: true),
                    EntegreId = table.Column<int>(type: "int", nullable: true),
                    EntegreAktarimTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    OlusturmaKullaniciTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    OlusturmaKullaniciId = table.Column<int>(type: "int", nullable: true),
                    OlusturmaTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegistirmeKullaniciTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    DegistirmeKullaniciId = table.Column<int>(type: "int", nullable: true),
                    DegistirmeTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    SilKullaniciTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    SilKullaniciId = table.Column<int>(type: "int", nullable: true),
                    SilTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    RemoteId = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    SyncStatus = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)1),
                    VergiNumarasi = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Log_Fatu__5E54864811BA53FB", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "Log_FaturaHareket",
                columns: table => new
                {
                    LogId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<long>(type: "bigint", nullable: true),
                    BayiId = table.Column<int>(type: "int", nullable: true),
                    FaturaId = table.Column<int>(type: "int", nullable: true),
                    KartTipId = table.Column<int>(type: "int", nullable: true),
                    KartId = table.Column<int>(type: "int", nullable: true),
                    Barkod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Miktar = table.Column<double>(type: "float", nullable: true),
                    BirimFiyat = table.Column<double>(type: "float", nullable: true),
                    DepoTipId = table.Column<int>(type: "int", nullable: true),
                    DepoId = table.Column<int>(type: "int", nullable: true),
                    KdvYuzde = table.Column<double>(type: "float", nullable: true),
                    KdvTutar = table.Column<double>(type: "float", nullable: true),
                    KdvTipId = table.Column<int>(type: "int", nullable: true),
                    BirimId = table.Column<int>(type: "int", nullable: true),
                    SatirIskontoYuzde = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    SatirIskontoTutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    OtvYuzde = table.Column<double>(type: "float", nullable: true),
                    OtvTutar = table.Column<double>(type: "float", nullable: true),
                    Carpan = table.Column<double>(type: "float", nullable: true),
                    ParaBirimId = table.Column<int>(type: "int", nullable: true),
                    Kur = table.Column<double>(type: "float", nullable: true),
                    Kesafet = table.Column<double>(type: "float", nullable: true),
                    KartParaBirimId = table.Column<int>(type: "int", nullable: true),
                    KartKur = table.Column<double>(type: "float", nullable: true),
                    IslemParaBirimId = table.Column<int>(type: "int", nullable: true),
                    IslemKur = table.Column<double>(type: "float", nullable: true),
                    ToplamIskontoYuzde = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    ToplamIskontoTutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    ToplamTutarIskontoluKdvsiz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    ToplamTutarIskontoluKdvli = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    ToplamKdvTutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    OtvCarpan = table.Column<double>(type: "float", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    OlusturmaKullaniciTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    OlusturmaKullaniciId = table.Column<int>(type: "int", nullable: true),
                    OlusturmaTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegistirmeKullaniciTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    DegistirmeKullaniciId = table.Column<int>(type: "int", nullable: true),
                    DegistirmeTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    SilKullaniciTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    SilKullaniciId = table.Column<int>(type: "int", nullable: true),
                    SilTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    RemoteId = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    SyncStatus = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Log_Fatu__5E5486483FC9CCDF", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "Log_MarketSatis",
                columns: table => new
                {
                    LogId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<long>(type: "bigint", nullable: true),
                    BayiId = table.Column<int>(type: "int", nullable: true),
                    MarketVardiyaId = table.Column<int>(type: "int", nullable: true),
                    DepoKartId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    IslemTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    SatisTutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    IadeTutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    NakitTutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    PosTutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    VeresiyeTutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    GiderTutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    IndirimTutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    YuvarlamaTutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    KartTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    KartId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    VeresiyeId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    FaturaId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    YazarKasaTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    YazarKasaNo = table.Column<int>(type: "int", nullable: true),
                    PersonelKartId = table.Column<int>(type: "int", nullable: true),
                    KayitDurum = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    OlusturmaKullaniciTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    OlusturmaKullaniciId = table.Column<int>(type: "int", nullable: true),
                    OlusturmaTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegistirmeKullaniciTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    DegistirmeKullaniciId = table.Column<int>(type: "int", nullable: true),
                    DegistirmeTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    SilKullaniciTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    SilKullaniciId = table.Column<int>(type: "int", nullable: true),
                    SilTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    RemoteId = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    SyncStatus = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Log_Mark__5E548648F0686EC3", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "Log_MarketSatisHareket",
                columns: table => new
                {
                    LogId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    BayiId = table.Column<int>(type: "int", nullable: true),
                    MarketSatisId = table.Column<int>(type: "int", nullable: true),
                    TarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    KartTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    KartId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Barkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true, defaultValue: ""),
                    FiyatNo = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    Miktar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    BirimFiyat = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    IndirimYuzde = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    KdvYuzde = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    KdvTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    ParaBirimId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    ParaBirimKur = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    BirimId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    OlusturmaKullaniciTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    OlusturmaKullaniciId = table.Column<int>(type: "int", nullable: true),
                    OlusturmaTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegistirmeKullaniciTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    DegistirmeKullaniciId = table.Column<int>(type: "int", nullable: true),
                    DegistirmeTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    SilKullaniciTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    SilKullaniciId = table.Column<int>(type: "int", nullable: true),
                    SilTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    RemoteId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    SyncStatus = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)1),
                    Recete = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Log_Mark__5E54864860F128D9", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "Log_UrunFiyatHistory",
                columns: table => new
                {
                    LogId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    BayiId = table.Column<long>(type: "bigint", nullable: false),
                    KartId = table.Column<int>(type: "int", nullable: false),
                    Fiyat = table.Column<double>(type: "float", nullable: false),
                    Kdv = table.Column<double>(type: "float", nullable: false),
                    KdvTipId = table.Column<int>(type: "int", nullable: false),
                    ParaBirimId = table.Column<int>(type: "int", nullable: false),
                    SyncStatus = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)1),
                    OlusturmaKullaniciTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    OlusturmaKullaniciId = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlusturmaTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegistirmeKullaniciTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    DegistirmeKullaniciId = table.Column<int>(type: "int", nullable: true),
                    DegistirmeTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    SilKullaniciTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    SilKullaniciId = table.Column<int>(type: "int", nullable: true),
                    SilTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    RemoteId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    FiyatNo = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    FiyatTip = table.Column<int>(type: "int", nullable: true, defaultValue: 2),
                    KartTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 10),
                    EskiFiyat = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    DegistirmeKullanici = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Log_Urun__5E548648724BC0C6", x => x.LogId);
                });

            migrationBuilder.CreateTable(
                name: "Log_UrunHareket",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    BayiId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    KartTipId = table.Column<int>(type: "int", nullable: false),
                    KartId = table.Column<int>(type: "int", nullable: false),
                    IslemTipId = table.Column<int>(type: "int", nullable: true),
                    PompaciVardiyaId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    MarketVardiyaId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TankId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    DepoId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Giren = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Cikan = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    BirimFiyatBrutKdvli = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    BirimFiyatNetKdvli = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    KdvYuzde = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Otv = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Aciklama = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    BelgeNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MarketSatisId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    MarketSatisHareketId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    FaturaId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    FaturaHareketId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    IrsaliyeId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    IrsaliyeHareketId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    VeresiyeId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    VeresiyeHareketId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    DepoTransferId = table.Column<int>(type: "int", nullable: true),
                    SayimId = table.Column<decimal>(type: "numeric(18,0)", nullable: true, defaultValue: 0m),
                    StokRenkId = table.Column<int>(type: "int", nullable: true),
                    StokBedenNoId = table.Column<int>(type: "int", nullable: true),
                    ReceteId = table.Column<int>(type: "int", nullable: true),
                    ReceteStokHareketId = table.Column<int>(type: "int", nullable: true),
                    KayitDurum = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    OlusturmaKullaniciTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    OlusturmaKullaniciId = table.Column<int>(type: "int", nullable: true),
                    OlusturmaTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegistirmeKullaniciTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    DegistirmeKullaniciId = table.Column<int>(type: "int", nullable: true),
                    DegistirmeTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    SilKullaniciTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    SilKullaniciId = table.Column<int>(type: "int", nullable: true),
                    SilTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    RemoteId = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    SadakatKartNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, defaultValueSql: "((0))"),
                    SadakatHarcananPuan = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    StokKodu = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    SyncStatus = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)1),
                    StokBarkod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Log_Urun__3214EC0784C1D36B", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogAlan",
                columns: table => new
                {
                    Tablo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Alan = table.Column<string>(type: "varchar(8000)", unicode: false, maxLength: 8000, nullable: true),
                    sfirmano = table.Column<int>(type: "int", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Logo_Transfer_Log",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaNo = table.Column<int>(type: "int", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Tip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BelgeNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ack = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Logo_Tra__3214EC071021A95E", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mail_Ack",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ack = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Mail_Ack__3213E83F391BA343", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "markasahrk",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kashrkid = table.Column<double>(type: "float", nullable: false),
                    varno = table.Column<double>(type: "float", nullable: false),
                    marsatid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    cartip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    carkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    gctip = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    varok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    islmtip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    islmtipad = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    islmhrk = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    islmhrkad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    yertip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    yerad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    perkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    giren = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    cikan = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    kur = table.Column<double>(type: "float", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    kaskod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    cartip_id = table.Column<byte>(type: "tinyint", nullable: true),
                    car_id = table.Column<int>(type: "int", nullable: true),
                    kasa_id = table.Column<int>(type: "int", nullable: true),
                    remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Transfer = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Transfer_TarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferDateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__markasah__DB642EC44DB0984A", x => new { x.id, x.varno, x.kashrkid });
                });

            migrationBuilder.CreateTable(
                name: "marsathrk",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marsatid = table.Column<double>(type: "float", nullable: false),
                    varno = table.Column<double>(type: "float", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    perkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    stktip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    stktipad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    stkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    mik = table.Column<double>(type: "float", nullable: true),
                    brmfiy = table.Column<double>(type: "float", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    kdvyuz = table.Column<double>(type: "float", nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    kdvtip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    kayok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    kur = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    brim = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    barkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    satfiyno = table.Column<int>(type: "int", nullable: true),
                    depkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    islmtip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    islmtipad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    yertip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    yerad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    varok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    indyuz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    gctip = table.Column<byte>(type: "tinyint", nullable: true),
                    stktip_id = table.Column<int>(type: "int", nullable: true),
                    stk_id = table.Column<int>(type: "int", nullable: true),
                    remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Transfer = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Transfer_TarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    ykno = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    RehberKomisyonYuzde = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    RehberIndirimYuzde = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Recete = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    YazarKasaServisLogId = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    StkAd = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Gtip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Bedelsiz = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__marsathr__52FB2F43F9AF2911", x => new { x.id, x.varno, x.marsatid });
                });

            migrationBuilder.CreateTable(
                name: "marsatmas",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marsatid = table.Column<double>(type: "float", nullable: false),
                    varno = table.Column<double>(type: "float", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    varok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    kayok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    islmtip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    islmtipad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    yertip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    yerad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    naktop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    postop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    veresitop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    iadetop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    indtop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    yuvtop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    kur = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    satistop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    gidertop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    cartip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    carkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    islmhrk = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    islmhrkad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    cartip_id = table.Column<int>(type: "int", nullable: true),
                    car_id = table.Column<int>(type: "int", nullable: true),
                    remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    YazarKasa_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Verid = table.Column<int>(type: "int", nullable: true),
                    Fatid = table.Column<int>(type: "int", nullable: true),
                    Fis_No = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Transfer = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Transfer_TarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    RehberBarkodId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    RehberId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    RehberGrupId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    YazarKasaIslemId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    FisYazdirildi = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Zno = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Cikis = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    YazarKasaBankaTerminalNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__marsatma__52FB2F439C75A62D", x => new { x.id, x.varno, x.marsatid });
                });

            migrationBuilder.CreateTable(
                name: "MarSatRecHrk",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarSatId = table.Column<long>(type: "bigint", nullable: true),
                    MarSatHrkId = table.Column<long>(type: "bigint", nullable: true),
                    StokReceteId = table.Column<int>(type: "int", nullable: true),
                    UretimTipId = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)1),
                    UrunId = table.Column<int>(type: "int", nullable: true),
                    StokTipId = table.Column<int>(type: "int", nullable: true),
                    StokTip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    StokId = table.Column<int>(type: "int", nullable: true),
                    StokKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Brm = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Miktar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    BirimFiyat = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    BirimMaliyetFiyat = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    RemoteId = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    OlusturmaKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    OlusturmaTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MarSatRe__3214EC072738705D", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "marvardikap",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    varno = table.Column<double>(type: "float", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    varok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    kaptip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    tutar = table.Column<double>(type: "float", nullable: true),
                    cartip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ackfaz = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferDateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__marvardi__76322BA29839570B", x => new { x.id, x.varno });
                });

            migrationBuilder.CreateTable(
                name: "marvardimas",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    varno = table.Column<double>(type: "float", nullable: false),
                    varok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    varad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    perkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    depkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    iadetop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    naktestop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    postop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    veresitop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    gidertop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    tahtop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    odetop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    kaptar = table.Column<DateTime>(type: "datetime", nullable: true),
                    kapsaat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    satistop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    bozukpara = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    naksattop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    varackfaztip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    gelirtop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    poscartop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Kas_kod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Kur = table.Column<double>(type: "float", nullable: true),
                    parabrm = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    indtop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Yaz_KNo = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Fis_No = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    entegre_aktar = table.Column<DateTime>(type: "datetime", nullable: true),
                    entegre_tip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Transfer = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Transfer_TarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Entegre = table.Column<bool>(type: "bit", nullable: true),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ZNo = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    YazarKasaServis = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    YazarKasaKontrol = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    YazarKasaModel = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    YazarKasaSeriNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    YazarKasaVardiyaNo = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    bankatop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    YazarKasaKasiyerKod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__marvardi__76322BA21F4CD4ED", x => new { x.id, x.varno });
                });

            migrationBuilder.CreateTable(
                name: "marvardiozet",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    varno = table.Column<double>(type: "float", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sil = table.Column<int>(type: "int", nullable: false),
                    varok = table.Column<int>(type: "int", nullable: false),
                    tip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    tipack = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    giris = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    cikis = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    bakiye = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    sr = table.Column<double>(type: "float", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferDateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__marvardi__76322BA2DB94B5B4", x => new { x.id, x.varno });
                });

            migrationBuilder.CreateTable(
                name: "marvardirapgoster",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: true),
                    Ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Goster = table.Column<bool>(type: "bit", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Filitre = table.Column<bool>(type: "bit", nullable: true),
                    Filitre_DegerIn = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    Rap_Tip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Merkez_Kart_Log",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TabloAd = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Tip = table.Column<int>(type: "int", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Merkez_K__3213E83FD5830585", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Mesaj",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Kime_User = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Kime_UserId = table.Column<int>(type: "int", nullable: true),
                    Ack = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    Olus_TarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Olus_User = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    drm = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Remote_Id = table.Column<int>(type: "int", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Mesaj__3213E83F1894E35F", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Msg_Ack",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tip = table.Column<int>(type: "int", nullable: true),
                    no = table.Column<int>(type: "int", nullable: true),
                    ack_tr = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ack_en = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ack_al = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ack_ru = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    frm_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Msg_Ack__3213E83F6540D10D", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "numarator",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    seri = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    numara = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    tip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    tipack = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    uzunluk = table.Column<int>(type: "int", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__numarato__3213E83FDB48B30D", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "oto_onl_param",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true),
                    tip = table.Column<int>(type: "int", nullable: true),
                    sure = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    satir = table.Column<int>(type: "int", nullable: true),
                    sonsatirno = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sondosya = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    sontarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    yenile_ch = table.Column<bool>(type: "bit", nullable: true),
                    yenile_sure = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    otomasad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ch_gecmis = table.Column<bool>(type: "bit", nullable: true),
                    Filter_Tip = table.Column<byte>(type: "tinyint", nullable: true),
                    Oto_Fis = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Print_Fis_Sayi = table.Column<int>(type: "int", nullable: true, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__oto_onl___3213E83F7BB29C3B", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Otomas_Satis",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    otomasid = table.Column<long>(type: "bigint", nullable: false),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: false),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    varno = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    yakit = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    miktar = table.Column<decimal>(type: "numeric(10,3)", nullable: true),
                    tutar = table.Column<decimal>(type: "numeric(18,3)", nullable: true),
                    brimfiy = table.Column<decimal>(type: "numeric(18,3)", nullable: true),
                    adano = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    tabanca = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    sayackod = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    km = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    FisNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    plaka = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    perkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Perad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    carkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    carad = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    ykodemetip = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Ack = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Otomas_S__E8812104BB05B71B", x => new { x.id, x.otomasid, x.tarih, x.saat });
                });

            migrationBuilder.CreateTable(
                name: "otomasdosya",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dosya = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    otomastip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    aktarim = table.Column<bool>(type: "bit", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__otomasdo__3213E83FC6F5701D", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "otomasgenkod",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    otomaskod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true, defaultValue: ""),
                    cartip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    kod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    carkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true, defaultValue: ""),
                    hrktip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true, defaultValue: ""),
                    plaka = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true, defaultValue: ""),
                    otomastip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true, defaultValue: ""),
                    perkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true, defaultValue: ""),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    limit = table.Column<double>(type: "float", nullable: true),
                    limitturu = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    stkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    kartno = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Fis_Grs = table.Column<bool>(type: "bit", nullable: true),
                    Prom_Grs = table.Column<bool>(type: "bit", nullable: true),
                    car_id = table.Column<int>(type: "int", nullable: true),
                    cartip_id = table.Column<int>(type: "int", nullable: true),
                    Km = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Plaka_Gid_Kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Remote_id = table.Column<int>(type: "int", nullable: true),
                    OtoFis = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__otomasge__3213E83F1E7939EF", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "otomaskart",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    otmaskod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    klasor = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    bassatir = table.Column<int>(type: "int", nullable: true),
                    dosuznti = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    tarformat = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    dostan = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    sonid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    otomascari = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    otomasper = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    otomascartip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    otofiload = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    basid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustar = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    host = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    beg = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    users = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    pass = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    sube_kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Sale_Tag = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    Kartan_Plaka = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    tts_Key = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    OtomasPartner = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    otomasPartnercari = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    CariFisNakitCevir = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    OtomasGift = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    OtomasGiftcari = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    TTSSeri = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__otomaska__FAA2E7A82FE9E4D1", x => new { x.id, x.otmaskod });
                });

            migrationBuilder.CreateTable(
                name: "otomaskarthrk",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    otmaskod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    kod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    pos = table.Column<int>(type: "int", nullable: true),
                    uzn = table.Column<int>(type: "int", nullable: true),
                    iptkar = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    onpos = table.Column<int>(type: "int", nullable: true),
                    onuzn = table.Column<int>(type: "int", nullable: true),
                    oku = table.Column<int>(type: "int", nullable: true),
                    sr = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    Sil = table.Column<bool>(type: "bit", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__otomaska__FAA2E7A84B9792AE", x => new { x.id, x.otmaskod });
                });

            migrationBuilder.CreateTable(
                name: "otomasoku",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    otomasid = table.Column<long>(type: "bigint", nullable: false),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: false),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    varno = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    unvan = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    kodu = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    yakit = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    miktar = table.Column<decimal>(type: "numeric(10,5)", nullable: true),
                    tutar = table.Column<decimal>(type: "numeric(18,3)", nullable: true),
                    brimfiy = table.Column<decimal>(type: "numeric(18,3)", nullable: true),
                    adano = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    tabanca = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    tag = table.Column<int>(type: "int", nullable: true),
                    km = table.Column<int>(type: "int", nullable: true),
                    fisno = table.Column<long>(type: "bigint", nullable: true),
                    dosya = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    plaka = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    tip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    aktar = table.Column<bool>(type: "bit", nullable: false),
                    sayackod = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    perkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    carkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    sattip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    cartip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    stkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    carad = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    otomasad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    tankod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    otocarad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    ykodemetip = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    oto_miktar = table.Column<double>(type: "float", nullable: true),
                    oto_ack = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    aktarid = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Promid = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    OtoFis = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    UTTS = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__otomasok__E8812104EFB90C3A", x => new { x.id, x.otomasid, x.tarih, x.saat });
                });

            migrationBuilder.CreateTable(
                name: "otomasonlineoku",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    otomasid = table.Column<long>(type: "bigint", nullable: false),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: false),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    varno = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    unvan = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    kodu = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    yakit = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    miktar = table.Column<decimal>(type: "numeric(10,5)", nullable: true),
                    tutar = table.Column<decimal>(type: "numeric(18,3)", nullable: true),
                    brimfiy = table.Column<decimal>(type: "numeric(18,3)", nullable: true),
                    adano = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    tabanca = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    tag = table.Column<int>(type: "int", nullable: true),
                    km = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    fisno = table.Column<long>(type: "bigint", nullable: true),
                    dosya = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    plaka = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    tip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    islem = table.Column<bool>(type: "bit", nullable: false),
                    sayackod = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    perkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    carkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    sattip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    stkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cartip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    carad = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    otomasad = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    tankod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    otocarad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    ykodemetip = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    aktarid = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    oto_miktar = table.Column<double>(type: "float", nullable: true),
                    oto_ack = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    aktar = table.Column<bool>(type: "bit", nullable: true),
                    Promid = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    OtoFis = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    OtoFisYazdir = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    OtoFisYazdirTarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    UTTS = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__otomason__E8812104E9EB860E", x => new { x.id, x.otomasid, x.tarih, x.saat });
                });

            migrationBuilder.CreateTable(
                name: "otomaspumphrk",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    otomasid = table.Column<int>(type: "int", nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Sayac_Kod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Tank_kod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Stok_Kod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Per_Kod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Litre = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Birim_Fiyat = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Tutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Kayit_Tar_Saat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dosya = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__otomaspu__3213E83FA4143485", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "otomaspumptan",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true),
                    tip = table.Column<byte>(type: "tinyint", nullable: true),
                    kod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    sira = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__otomaspu__3213E83F0380D9C5", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "otomastip",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    onli = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    dosyatip = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__otomasti__3213E83F4F2F71AB", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "OtomasWebServisHrk",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtomasId = table.Column<int>(type: "int", nullable: true),
                    Firmano = table.Column<int>(type: "int", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    YakitId = table.Column<int>(type: "int", nullable: true),
                    YakitUnvan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PersonelKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PersonelUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    PompaNo = table.Column<int>(type: "int", nullable: true),
                    TabancaNo = table.Column<int>(type: "int", nullable: true),
                    BrmFiyat = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Miktar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Tutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Plaka = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OdemeTip = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    OtomasTip = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    FisNo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OtomasWe__3213E83F484974FD", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ozel_fis_tablo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ad = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Ozel_fis__3213E83FE73372A8", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ozel_Kod",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true),
                    tip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    kod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Ozel_Kod__3213E83FCBBB4854", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "para_kur",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true),
                    kod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    dov_alis = table.Column<double>(type: "float", nullable: true),
                    dov_satis = table.Column<double>(type: "float", nullable: true),
                    efk_alis = table.Column<double>(type: "float", nullable: true),
                    efk_satis = table.Column<double>(type: "float", nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__para_kur__3213E83F805274C9", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "parabrm",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "varchar(4)", unicode: false, maxLength: 4, nullable: true),
                    ad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    sabit = table.Column<bool>(type: "bit", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    kurus_kod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__parabrm__3213E83FB9CA0BC8", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Parametre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaNo = table.Column<int>(type: "int", nullable: true),
                    UserKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Ad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Bolum = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Deger = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Pda_FaturaSayim_Hrk",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    fatsayid = table.Column<int>(type: "int", nullable: false),
                    stk_tip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    stk_kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    miktar = table.Column<double>(type: "float", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    stk_barkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Pda_Fatu__3213E83F4B6F9CED", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pda_FaturaSayim_Mas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    cartip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    carkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Stk_Top_Mik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Drm = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    ack = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    bar_capran = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Pda_Fatu__3213E83F5559846B", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pda_OffSayim_Hrk",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Offsayid = table.Column<int>(type: "int", nullable: false),
                    stk_tip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    stk_kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    miktar = table.Column<double>(type: "float", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    stk_barkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    kaymiktar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Pda_OffS__3213E83FB982035F", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pda_OffSayim_Mas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ack = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    drm = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    Stk_Top_Mik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    aktarid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    aktartarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    aktaruser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Pda_OffS__3213E83F667D78B8", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Per_Cari",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Per_id = table.Column<int>(type: "int", nullable: true),
                    Per_Kod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    cartip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CarTip_id = table.Column<int>(type: "int", nullable: true),
                    car_id = table.Column<int>(type: "int", nullable: true),
                    car_kod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olususer = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Per_Cari__3213E83F7E1ABB8E", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "perakendekart",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: false),
                    sil = table.Column<int>(type: "int", nullable: false),
                    kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    drm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    soyad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    unvan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    grp1 = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    grp2 = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    grp3 = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    ilgili = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    tel = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fax = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    cep = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    muhkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    resim = table.Column<byte[]>(type: "image", nullable: true),
                    adres = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    evil = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    evilce = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    vergidaire = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    vergino = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    mail = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    tcno = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    kulkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    kulsif = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    fisbak = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    carbak = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    adres2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fisadet = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    muhonkod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fatunvan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    webextre = table.Column<bool>(type: "bit", nullable: true),
                    Prom_Grp1 = table.Column<int>(type: "int", nullable: true),
                    vergieposta = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    EFatura = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    EfaturaTip = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TicSicilNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DogumTarih = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__perakend__DAB2FC2B8DD86140", x => new { x.id, x.kod, x.sil, x.firmano });
                });

            migrationBuilder.CreateTable(
                name: "perkart",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    drm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    ad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    soyad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    grp1 = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    grp2 = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    grp3 = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    tel = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    fax = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    cep = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    muhkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    resim = table.Column<byte[]>(type: "image", nullable: true),
                    adres = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    evil = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    evilce = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    vergidaire = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    vergino = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    mail = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    tcno = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    toplim = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    maasgun = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    maas = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    prim = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    isk = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    isbastar = table.Column<DateTime>(type: "datetime", nullable: true),
                    isbittar = table.Column<DateTime>(type: "datetime", nullable: true),
                    fisbak = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    carbak = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    gos = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    fisadet = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    fisaktut = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    fisakadet = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    actutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    adres2 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    muhonkod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    sgkno = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    banka_ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    banka_sube = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    hesapno = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    limit_tip = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    FileName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KulKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KulSifre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    KasiyerKod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__perkart__DFEE66863F6B1DD2", x => new { x.id, x.kod });
                });

            migrationBuilder.CreateTable(
                name: "permaashrk",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    permaashrkid = table.Column<int>(type: "int", nullable: true),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    carkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    cartip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    gidkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    kur = table.Column<double>(type: "float", nullable: true),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    tutar = table.Column<double>(type: "float", nullable: true),
                    sil = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    yertip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    yerad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    belno = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ack = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__permaash__3213E83F6855BAB2", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pomvardikap",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    varno = table.Column<double>(type: "float", nullable: false),
                    varok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    kaptip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    tutar = table.Column<double>(type: "float", nullable: true),
                    cartip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ackfaz = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferDateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__pomvardi__76322BA20C31E407", x => new { x.id, x.varno });
                });

            migrationBuilder.CreateTable(
                name: "pomvardimas",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    varno = table.Column<double>(type: "float", nullable: false),
                    varok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    varad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    adabag = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    aksatmik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    aksattop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    naktestop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    postop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    veresitop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    malsattop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    gelirtop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    gidertop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    tahtop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    odetop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    kaptar = table.Column<DateTime>(type: "datetime", nullable: true),
                    kapsaat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    otocheck = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    otomastop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    varackfaztip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    poscartop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    cektop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    bankatop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    veresimik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    otomasmik = table.Column<double>(type: "float", nullable: true),
                    Admin = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    entegre_aktar = table.Column<DateTime>(type: "datetime", nullable: true),
                    entegre_tip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Entegre = table.Column<bool>(type: "bit", nullable: true),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EntegreBelgeNo = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    AracSayi = table.Column<int>(type: "int", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__pomvardi__76322BA21ACEE08A", x => new { x.id, x.varno });
                });

            migrationBuilder.CreateTable(
                name: "pomvardiozet",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    varno = table.Column<double>(type: "float", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    varok = table.Column<int>(type: "int", nullable: false),
                    sil = table.Column<int>(type: "int", nullable: false),
                    tip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    tipack = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    giris = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    cikis = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    bakiye = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    sr = table.Column<double>(type: "float", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferDateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__pomvardi__76322BA211933C9A", x => new { x.id, x.varno });
                });

            migrationBuilder.CreateTable(
                name: "pomvardiper",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    varno = table.Column<double>(type: "float", nullable: false),
                    varok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    per = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    perad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    sr = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    perackfaz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Gec_PerKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferDateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__pomvardi__76322BA2167FF443", x => new { x.id, x.varno });
                });

            migrationBuilder.CreateTable(
                name: "pomvardiperada",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    varno = table.Column<double>(type: "float", nullable: false),
                    varok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    per = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    sr = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    adaid = table.Column<int>(type: "int", nullable: true),
                    adad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferDateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__pomvardi__76322BA255FD4993", x => new { x.id, x.varno });
                });

            migrationBuilder.CreateTable(
                name: "pomvardirapgoster",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: true),
                    Ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Goster = table.Column<bool>(type: "bit", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Filitre = table.Column<bool>(type: "bit", nullable: true),
                    Filitre_DegerIn = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    Rap_Tip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "pomvardisayac",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    varno = table.Column<double>(type: "float", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    varok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    perkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    perad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    adad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    sayackod = table.Column<string>(type: "varchar(53)", unicode: false, maxLength: 53, nullable: true),
                    ilkendk = table.Column<double>(type: "float", nullable: true),
                    sonendk = table.Column<double>(type: "float", nullable: true),
                    digermik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    satmik = table.Column<double>(type: "float", nullable: true),
                    testmik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    transfermik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    brimfiy = table.Column<decimal>(type: "decimal(38,14)", nullable: true),
                    tutar = table.Column<double>(type: "float", nullable: true),
                    sayacad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    tankod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    transfertank = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, defaultValue: ""),
                    stkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    adaid = table.Column<int>(type: "int", nullable: true),
                    stktip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    kdvyuz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    enktur = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    otomaskod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    OncekiSonEndk = table.Column<double>(type: "float", nullable: true),
                    Gec_PerKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferDateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__pomvardi__76322BA2F3CC55C8", x => new { x.id, x.varno });
                });

            migrationBuilder.CreateTable(
                name: "pomvardistok",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    varno = table.Column<double>(type: "float", nullable: false),
                    kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    varok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    stktip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    acmik = table.Column<double>(type: "float", nullable: true),
                    satmik = table.Column<double>(type: "float", nullable: true),
                    kalan = table.Column<double>(type: "float", nullable: true),
                    brimfiy = table.Column<decimal>(type: "decimal(38,14)", nullable: true),
                    tutar = table.Column<double>(type: "float", nullable: true),
                    testmik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    transfer_cks_mik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    kdvyuz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    transfer_grs_mik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferDateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__pomvardi__E8EDF349887FACA6", x => new { x.id, x.varno, x.kod });
                });

            migrationBuilder.CreateTable(
                name: "pomvarditank",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    varno = table.Column<double>(type: "float", nullable: false),
                    kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    varok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sil = table.Column<int>(type: "int", nullable: false),
                    stkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    stktip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    acmik = table.Column<double>(type: "float", nullable: true),
                    satmik = table.Column<double>(type: "float", nullable: true),
                    kalan = table.Column<double>(type: "float", nullable: true),
                    brimfiy = table.Column<decimal>(type: "decimal(38,14)", nullable: true),
                    tutar = table.Column<double>(type: "float", nullable: true),
                    testmik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    transfer_cks_mik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    kdvyuz = table.Column<double>(type: "float", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    transfer_grs_mik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferDateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__pomvardi__E8EDF349CB69A932", x => new { x.id, x.varno, x.kod });
                });

            migrationBuilder.CreateTable(
                name: "poshrk",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    poshrkid = table.Column<double>(type: "float", nullable: false),
                    poskod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    bankod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    varno = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    varok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    perkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    adaid = table.Column<int>(type: "int", nullable: true),
                    islmtip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    islmtipad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    islmhrk = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    islmhrkad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    yertip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    yerad = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    masterid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    gctip = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    carslip = table.Column<int>(type: "int", nullable: true),
                    cartip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    carkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    giren = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    cikan = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    extrakomyuz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    bankomyuz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    ack = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    vadetar = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    belno = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    kur = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    aktar = table.Column<DateTime>(type: "datetime", nullable: true),
                    aktip = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true, defaultValue: "BK"),
                    gerialtar = table.Column<DateTime>(type: "datetime", nullable: true),
                    bagid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ekkomyuz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    akid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    pro = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    fisfattip = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true, defaultValue: "KENDI"),
                    fisfatid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    marsatid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    cartur = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    fisid = table.Column<int>(type: "int", nullable: true),
                    krekartno = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    fatid = table.Column<int>(type: "int", nullable: true),
                    tahodeid = table.Column<int>(type: "int", nullable: true),
                    pos_id = table.Column<int>(type: "int", nullable: true),
                    bank_id = table.Column<int>(type: "int", nullable: true),
                    cartip_id = table.Column<int>(type: "int", nullable: true),
                    car_id = table.Column<int>(type: "int", nullable: true),
                    remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    ana_id = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    belrap_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Car_VadeTar = table.Column<DateTime>(type: "datetime", nullable: true),
                    Gec_PerKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    devir = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Karsi_KartTip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Karsi_KartKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    PosIsle = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    Entegre = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Entegre_Tip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Entegre_Aktar = table.Column<DateTime>(type: "datetime", nullable: true),
                    ResSatId = table.Column<int>(type: "int", nullable: true),
                    Transfer = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Transfer_TarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferDateTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__poshrk__585CD14C2EFD708D", x => new { x.id, x.poshrkid, x.poskod });
                });

            migrationBuilder.CreateTable(
                name: "poskart",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: false),
                    ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    drm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    bankod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    muhkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    kom = table.Column<double>(type: "float", nullable: true),
                    exkom = table.Column<double>(type: "float", nullable: true),
                    vade = table.Column<double>(type: "float", nullable: true),
                    vadetip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    gidhes = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    bekbak = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    kombak = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    muhonkod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Mas_Gid_Kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Remote_id = table.Column<int>(type: "int", nullable: true),
                    YazarKasaBankaTerminalNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__poskart__77FA318536AAFA3A", x => new { x.id, x.kod, x.firmano });
                });

            migrationBuilder.CreateTable(
                name: "Prom_Limit",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    cartip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    cartip_id = table.Column<int>(type: "int", nullable: true),
                    carkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    car_id = table.Column<int>(type: "int", nullable: true),
                    Limit_tip = table.Column<int>(type: "int", nullable: true),
                    Limit_Kosul = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Prom_Lim__3213E83FFBBA4574", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Prom_Puan_Hrk",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firmano = table.Column<int>(type: "int", nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Cartip_id = table.Column<int>(type: "int", nullable: true),
                    Cartip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Car_id = table.Column<int>(type: "int", nullable: true),
                    Carkod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Stktip_id = table.Column<int>(type: "int", nullable: true),
                    Stktip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Stk_id = table.Column<int>(type: "int", nullable: true),
                    Stkkod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Puan_Giren = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Puan_Cikan = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Saat = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    islemTip_id = table.Column<int>(type: "int", nullable: true),
                    islemTip_Ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OdeTip_id = table.Column<int>(type: "int", nullable: true),
                    OdeTip_Ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OlusUser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OlusTarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ack = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DegisUser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DegisTarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Car_Plaka = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Car_KartNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Brm_Fiyat_Kdvli = table.Column<double>(type: "float", nullable: true),
                    Kdv_Oran = table.Column<double>(type: "float", nullable: true),
                    Mik_Giren = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Mik_Cikan = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    BelNo = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Tutar_Kdvli = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Fatid = table.Column<long>(type: "bigint", nullable: true),
                    Fisid = table.Column<long>(type: "bigint", nullable: true),
                    Promid = table.Column<long>(type: "bigint", nullable: true),
                    Yertip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    YerAd = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Varno = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Dep_id = table.Column<int>(type: "int", nullable: true),
                    Dep_Kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Car_KartID = table.Column<int>(type: "int", nullable: true),
                    Puanid = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Hrk_Stk_Pro = table.Column<bool>(type: "bit", nullable: true),
                    Kayok = table.Column<byte>(type: "tinyint", nullable: true),
                    Kur = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Prom_Pua__3213E83F24BBF591", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Prom_Puan_Hrk_Tip",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tip = table.Column<int>(type: "int", nullable: true),
                    ack_tr = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ack_en = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ack_al = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ack_ru = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Prom_Pua__3213E83F5EFF0A87", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Prom_Sat_Baslik",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    promid = table.Column<double>(type: "float", nullable: false),
                    varno = table.Column<double>(type: "float", nullable: false),
                    fatid = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    vtsid = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    varok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    kayok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    fisrap_id = table.Column<int>(type: "int", nullable: true),
                    fistip_id = table.Column<int>(type: "int", nullable: true),
                    fisad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    fistip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    yertip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    yerad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    seri = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    no = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ykno = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    cartip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    carkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    plaka = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    perkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    adaid = table.Column<int>(type: "int", nullable: true),
                    surucu = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    km = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Genel_Top_Kdvli = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Genel_Top_Kdvsiz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    ack = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    aktip = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true, defaultValue: "BK"),
                    aktar = table.Column<DateTime>(type: "datetime", nullable: true),
                    vadtar = table.Column<DateTime>(type: "datetime", nullable: true),
                    bagid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    marsatid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    kur = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    akid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    otocarkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    otocarad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Kartno = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    isktop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    otomas_id = table.Column<int>(type: "int", nullable: true),
                    otomas_ack = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    vts_oto_aktar = table.Column<bool>(type: "bit", nullable: true),
                    hrk_stk_pro = table.Column<bool>(type: "bit", nullable: true),
                    car_id = table.Column<int>(type: "int", nullable: true),
                    cartip_id = table.Column<int>(type: "int", nullable: true),
                    gctip = table.Column<int>(type: "int", nullable: true),
                    fistur_id = table.Column<int>(type: "int", nullable: true),
                    hrk_car_pro = table.Column<bool>(type: "bit", nullable: true),
                    Kart_ParaBrm = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Kart_Kur = table.Column<double>(type: "float", nullable: true),
                    Islem_ParaBrm = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Islem_Kur = table.Column<double>(type: "float", nullable: true),
                    kdvtip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    kmsec = table.Column<bool>(type: "bit", nullable: true),
                    OdeTip_id = table.Column<int>(type: "int", nullable: true),
                    OdeTip_Ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Genel_Top_Puan = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Genel_Top_Kdv = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Genel_Top_Net = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Prom_Pro = table.Column<bool>(type: "bit", nullable: true),
                    Prom_Kartsiz = table.Column<bool>(type: "bit", nullable: true),
                    KartId = table.Column<int>(type: "int", nullable: true),
                    Prom_Grp1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Prom_Sat__0D0FC9E97C2B8129", x => new { x.id, x.varno, x.promid });
                });

            migrationBuilder.CreateTable(
                name: "Prom_Sat_Hrk",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    varno = table.Column<double>(type: "float", nullable: false),
                    promid = table.Column<double>(type: "float", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    stktip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    stkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    mik = table.Column<double>(type: "float", nullable: true),
                    brmfiy = table.Column<decimal>(type: "decimal(38,14)", nullable: false),
                    depkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    kdvyuz = table.Column<double>(type: "float", nullable: true),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    kayok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    brim = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    iskyuz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    stktip_id = table.Column<int>(type: "int", nullable: true),
                    stk_id = table.Column<int>(type: "int", nullable: true),
                    dep_id = table.Column<int>(type: "int", nullable: true),
                    Kart_ParaBrm = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Kart_Kur = table.Column<double>(type: "float", nullable: true),
                    Islem_ParaBrm = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Islem_Kur = table.Column<double>(type: "float", nullable: true),
                    barkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    otvbrim = table.Column<double>(type: "float", nullable: true),
                    Kaz_Top_Puan = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Tut_isk_Kdvli = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Sat_Brm_Puan = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Sat_Top_Puan = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Kaz_Brm_Puan = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Prom_Sat__0D0FC9E960653484", x => new { x.id, x.varno, x.promid });
                });

            migrationBuilder.CreateTable(
                name: "Prom_Urun_Puan",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Urun_tip_id = table.Column<int>(type: "int", nullable: true),
                    Urun_id = table.Column<int>(type: "int", nullable: true),
                    Grp1 = table.Column<int>(type: "int", nullable: true),
                    Puan_Tip = table.Column<int>(type: "int", nullable: true),
                    Puan_Brm = table.Column<int>(type: "int", nullable: true),
                    Puan_Nakit = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Puan_KK = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Puan_Fis = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Puan_Otomas = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Sil = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    DegisUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DegisTarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlusUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    OlusTarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Puan_Otomas2 = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Prom_Uru__3213E83F81020C5A", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Prom_Urun_Puan_Tip",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    Ad_tr = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ad_en = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Prom_Uru__3213E83F34612C95", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Prom_Urun_Sat_Tip",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    Ad_tr = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ad_en = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Prom_Uru__3213E83F9B9594CA", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PromaksMarketSatisLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firmano = table.Column<int>(type: "int", nullable: true),
                    IslemId = table.Column<int>(type: "int", nullable: true),
                    DetayId = table.Column<int>(type: "int", nullable: true),
                    IslemTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    KasiyerKod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    StokKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StokAd = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Barkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IslemTipId = table.Column<int>(type: "int", nullable: true),
                    Miktar = table.Column<decimal>(type: "decimal(18,8)", nullable: true),
                    Birim = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Fiyat = table.Column<decimal>(type: "decimal(18,8)", nullable: true),
                    Kdv = table.Column<decimal>(type: "decimal(18,8)", nullable: true),
                    Tutar = table.Column<decimal>(type: "decimal(18,8)", nullable: true),
                    KayitTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    StokId = table.Column<int>(type: "int", nullable: true),
                    GuidId = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    Transfer = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Aktar = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    OdemeTip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PromaksM__3214EC075EF9AD28", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rapor_Deger",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kay_Id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Rap_Kod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ack = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: true),
                    Mas_Id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Par_Id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Deger = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Table_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Table_Id = table.Column<int>(type: "int", nullable: true),
                    Grp_No = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Rapor_De__3213E83F1C346519", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Rapor_Grup_Kriter",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rap_Kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    User_Id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Ack = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: true),
                    CarTip_Id = table.Column<int>(type: "int", nullable: true),
                    Mas_Id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Deger_KodIn = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Deger_Tip = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Carpan = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    Hrk_Tip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true, defaultValue: "BAK")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Rapor_Gr__3213E83FEA4CE111", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Rapor_Hrk_Kriter",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rap_Kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Kart_Id = table.Column<int>(type: "int", nullable: true),
                    Kart_Kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    User_Id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Firmano = table.Column<int>(type: "int", nullable: true),
                    Grp_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Rapor_Hr__3213E83F99C9712B", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Rapor_List",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rap_Kod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ack = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Saat = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    FirmaNo = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Remote_Id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Olus_User = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Olus_TarSaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Rapor_Li__3213E83FFE8E4649", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Rapor_Mas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rap_Kod = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: true),
                    User_Id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Ack = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ana_Id = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Ana = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Rapor_Ma__3213E83F4C3847B9", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "raporlar",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    rapgrp = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    rapkod = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    ack = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    yer = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    aktif = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true, defaultValue: "Evet"),
                    kaptip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true, defaultValue: "Açık"),
                    islmkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    master = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    yazildi = table.Column<bool>(type: "bit", nullable: true),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    yazdir = table.Column<byte>(type: "tinyint", nullable: true),
                    hrk_car_pro = table.Column<bool>(type: "bit", nullable: true),
                    hrk_stk_pro = table.Column<bool>(type: "bit", nullable: true),
                    Tip_id = table.Column<int>(type: "int", nullable: true),
                    belge_tip = table.Column<byte>(type: "tinyint", nullable: true),
                    baska_car_fis_aktar = table.Column<byte>(type: "tinyint", nullable: true),
                    satir_esas_brm = table.Column<byte>(type: "tinyint", nullable: true),
                    alis_satis_fiyat_kont = table.Column<byte>(type: "tinyint", nullable: true),
                    kdv_tip = table.Column<byte>(type: "tinyint", nullable: true),
                    Car_Tip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Grs_Stk_Tip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    isk_Stk_Tip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Fat_Grs_alan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Fat_Tah_Ode = table.Column<byte>(type: "tinyint", nullable: true),
                    Kdv_Oran_Yansit = table.Column<byte>(type: "tinyint", nullable: true),
                    Plaka_Limit = table.Column<byte>(type: "tinyint", nullable: true),
                    Plaka_Kont_Devam = table.Column<byte>(type: "tinyint", nullable: true),
                    Yeni_Car_Kart = table.Column<byte>(type: "tinyint", nullable: true),
                    Kart_Oku = table.Column<byte>(type: "tinyint", nullable: true),
                    Yeni_Stk_Kart = table.Column<byte>(type: "tinyint", nullable: true),
                    prom_pro = table.Column<bool>(type: "bit", nullable: true),
                    Prom_Kartsiz = table.Column<bool>(type: "bit", nullable: true),
                    Stk_AdBarkod = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    Karsi_Hes_Grs = table.Column<bool>(type: "bit", nullable: true),
                    Stk_Dep_Dag = table.Column<bool>(type: "bit", nullable: true),
                    car_kod_bosalt = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Tesis_Fiyat = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Plaka_Arama_Yetki = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    IskGiderHrkYansit = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "raptip",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kod = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__raptip__3213E83FB258BD02", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "RehberBarkod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RehberId = table.Column<int>(type: "int", nullable: true),
                    Barkod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Durum = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    OlusturmaTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlusturmaKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DegistirmeTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegistirmeKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SilTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    SilKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    RemoteId = table.Column<int>(type: "int", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RehberGrup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Ad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    OlusturmaTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlusturmaKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DegistirmeTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegistirmeKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SilTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    SilKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RehberGrupDetay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrupId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    StokGrupId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    KomisyonYuzde = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    IndirimYuzde = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    OlusturmaTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlusturmaKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DegistirmeTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegistirmeKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SilTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    SilKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RehberKart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaNo = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Kod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Unvan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CepNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    GrupId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    OlusturmaTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlusturmaKullaniciUnvan = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    DegistirmeTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegistirmeKullaniciUnvan = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    SilTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    SilKullaniciUnvan = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    RemoteId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferStartId = table.Column<int>(type: "int", nullable: true),
                    TransferStopId = table.Column<int>(type: "int", nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    ParaBirim = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Durum = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ResSatHrk",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OlusUser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OlusTarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegisUser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DegisTarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    ResSatId = table.Column<double>(type: "float", nullable: false),
                    StkTipId = table.Column<int>(type: "int", nullable: true),
                    StkId = table.Column<int>(type: "int", nullable: true),
                    Miktar = table.Column<double>(type: "float", nullable: true),
                    BirimFiyat = table.Column<double>(type: "float", nullable: true),
                    KdvYuz = table.Column<double>(type: "float", nullable: true),
                    ParaBirim = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Kur = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    Birim = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Barkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    SatFiyNo = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    IndYuz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    BirimCarpan = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    VarNo = table.Column<int>(type: "int", nullable: true),
                    Recete = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ResSatKasaHrk",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResSatId = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    CariTip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CariKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    GcTip = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Tutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    Kur = table.Column<double>(type: "float", nullable: true),
                    OlusUser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OlusTarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    ParaBirim = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    DegUser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DegTarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    KasaKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    CariTipId = table.Column<byte>(type: "tinyint", nullable: true),
                    CariId = table.Column<int>(type: "int", nullable: true),
                    KasaId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    RemoteId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    VarNo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ResSatMas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OlusUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    OlusTarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegisUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DegisTarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    FirmaNo = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Saat = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    VarNo = table.Column<int>(type: "int", nullable: true),
                    KayOk = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Iade = table.Column<bool>(type: "bit", nullable: true),
                    SatisTop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    IadeTop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    NakitTop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    PosTop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    ParaBirim = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true, defaultValueSql: "((0))"),
                    Kur = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    FisNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DepoKod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IndTop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ResSatRecHrk",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResSatId = table.Column<long>(type: "bigint", nullable: true),
                    ResSatHrkId = table.Column<long>(type: "bigint", nullable: true),
                    StokReceteId = table.Column<int>(type: "int", nullable: true),
                    UretimTipId = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)1, comment: "1=Recete\r\n2=Urun"),
                    UrunId = table.Column<int>(type: "int", nullable: true),
                    StokTipId = table.Column<int>(type: "int", nullable: true),
                    StokTip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    StokId = table.Column<int>(type: "int", nullable: true),
                    StokKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Brm = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Miktar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    BirimFiyat = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    BirimMaliyetFiyat = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    RemoteId = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    OlusturmaKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    OlusturmaTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ResSatRe__3214EC074539DB25", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResVardiKap",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    varno = table.Column<double>(type: "float", nullable: false),
                    varok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    kaptip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    tutar = table.Column<double>(type: "float", nullable: true),
                    cartip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ackfaz = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ResVardiMas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OlusUser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OlusTarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegUser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DegTarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    VarNo = table.Column<int>(type: "int", nullable: false),
                    VarOk = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    FirmaNo = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    VarAd = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PerKod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DepKod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    IadeTop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    NakTesTop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    PosTop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    VeresiTop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    GiderTop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    TahTop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    OdeTop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    KapTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    KapSaat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    SatisTop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    BozukPara = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    NakSatTop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    VarAckFazTip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    GelirTop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    PosCarTop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    KasaKod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Kur = table.Column<double>(type: "float", nullable: true),
                    ParaBirim = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    RemoteId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    IndTop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    YazarKasaNo = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    EntegreAktar = table.Column<DateTime>(type: "datetime", nullable: true),
                    EntegreTip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ResVardiOzet",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    varno = table.Column<double>(type: "float", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    varok = table.Column<int>(type: "int", nullable: false),
                    sil = table.Column<int>(type: "int", nullable: false),
                    tip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    tipack = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    giris = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    cikis = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    bakiye = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    sr = table.Column<double>(type: "float", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ResVardi__76322BA2804EEEE1", x => new { x.id, x.varno });
                });

            migrationBuilder.CreateTable(
                name: "ResVardiRapGoster",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: true),
                    Ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Goster = table.Column<bool>(type: "bit", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Filitre = table.Column<bool>(type: "bit", nullable: true),
                    Filitre_DegerIn = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    Rap_Tip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RezSatHrk",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RezSatid = table.Column<double>(type: "float", nullable: false),
                    Varno = table.Column<double>(type: "float", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    Stktip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Stkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Miktar = table.Column<double>(type: "float", nullable: true),
                    BrmFiyat = table.Column<double>(type: "float", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    kdvyuz = table.Column<double>(type: "float", nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    kayok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    kur = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    brim = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    barkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    satfiyno = table.Column<int>(type: "int", nullable: true),
                    depkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    indyuz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    stktip_id = table.Column<int>(type: "int", nullable: true),
                    stk_id = table.Column<int>(type: "int", nullable: true),
                    gctip = table.Column<byte>(type: "tinyint", nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RezSatHr__8C7138E0796B881E", x => new { x.id, x.Varno, x.RezSatid });
                });

            migrationBuilder.CreateTable(
                name: "sayachrk",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sayachrkid = table.Column<double>(type: "float", nullable: false),
                    sayackod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    varno = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    varok = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    islmtip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    islmtipad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ilkendks = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    sonendks = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    ack = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    yertip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    yerad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    islmid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    belno = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true, defaultValue: ""),
                    ilkmekendks = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    sonmekendks = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    sayac_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__sayachrk__D7980C411B5F2109", x => new { x.id, x.sayachrkid, x.sayackod });
                });

            migrationBuilder.CreateTable(
                name: "sayackart",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    grp1 = table.Column<double>(type: "float", nullable: true),
                    ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    drm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    muhkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    tankod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    satfiytip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    acendks = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    enktur = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sonendks = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    otomaskod = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    grp2 = table.Column<int>(type: "int", nullable: true),
                    grp3 = table.Column<int>(type: "int", nullable: true),
                    acmekenks = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    sonmekendks = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    acmekendks = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Remote_id = table.Column<int>(type: "int", nullable: true),
                    ykkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__sayackar__DFEE6686F7AA6379", x => new { x.id, x.kod });
                });

            migrationBuilder.CreateTable(
                name: "sayimhrk",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sayid = table.Column<double>(type: "float", nullable: false),
                    depkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    stkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    drm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true, defaultValue: "B"),
                    stktip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    sayimmik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    mevcutmik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    saydrm = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValue: "B"),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    brmfiy = table.Column<double>(type: "float", nullable: true),
                    kdvtip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    kdvyuz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    mevata = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    OnlineSayimMiktar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    OnlineSatisMiktar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    OnlineSayimTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    OnlineSayim = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__sayimhrk__EC691CAE34419D04", x => new { x.id, x.sayid });
                });

            migrationBuilder.CreateTable(
                name: "sayimkap",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sayid = table.Column<double>(type: "float", nullable: false),
                    kaptip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    tutar = table.Column<double>(type: "float", nullable: true),
                    ackfaz = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    saymiktip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__sayimkap__EC691CAE80B88959", x => new { x.id, x.sayid });
                });

            migrationBuilder.CreateTable(
                name: "sayimmas",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sayid = table.Column<double>(type: "float", nullable: false),
                    sil = table.Column<int>(type: "int", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    sayack = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    drm = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValue: "B"),
                    depkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    perkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    onaytarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    onaysaat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    sayimmik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    mevcutmik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    mevcuttut = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    sayimtut = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    onayack = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    kdvtip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    brmfiytip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    onayper = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    yertip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    yerad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__sayimmas__D3B4C3736B016595", x => new { x.id, x.sayid, x.sil });
                });

            migrationBuilder.CreateTable(
                name: "sayimstkgrp",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sayid = table.Column<double>(type: "float", nullable: true),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    depkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    stktip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    stkgrp1 = table.Column<double>(type: "float", nullable: true),
                    stkgrp2 = table.Column<double>(type: "float", nullable: true),
                    stkgrp3 = table.Column<double>(type: "float", nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__sayimstk__3213E83F5F6FEF56", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "siparishrk",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sipid = table.Column<double>(type: "float", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sil = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    irid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    kapa = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValue: "B"),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    kdvtip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    cartur = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    carkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    stktip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    stkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    mik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    carpan = table.Column<double>(type: "float", nullable: true),
                    brim = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ustbrim = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    kdvyuz = table.Column<double>(type: "float", nullable: true),
                    kdvtut = table.Column<double>(type: "float", nullable: true),
                    depo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true, defaultValue: ""),
                    grupid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    brmfiy = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    tesmik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    fatid = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__siparish__01F3B79BFF451A8A", x => new { x.id, x.sipid });
                });

            migrationBuilder.CreateTable(
                name: "siparismas",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sipid = table.Column<double>(type: "float", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    kayok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sipad = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    siptip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    siptur = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    sipturad = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    sipseri = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    sipno = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    vadtar = table.Column<DateTime>(type: "datetime", nullable: true),
                    kdvtip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ack = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    kdvtut = table.Column<double>(type: "float", nullable: true),
                    depo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    siptop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    kdvtop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    cartip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    carkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    aktip = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true, defaultValue: "BK"),
                    kaltop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    irtip = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValue: "B"),
                    Durum = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Durum_Ack = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__siparism__01F3B79BCA4E0245", x => new { x.id, x.sipid });
                });

            migrationBuilder.CreateTable(
                name: "sistemtanim",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    kod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    sistemkasa = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    otomas1 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    otomas2 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    mardepo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    pomvardiackfaz = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    pomvarditeskasa = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    marvarditeskasa = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    alsatfiykontrol = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    bacarigiris = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    haricistokgiris = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    yenicarigrp = table.Column<int>(type: "int", nullable: true),
                    varkapislemtariheata = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    varteslimatkasateksatir = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    pommailgonder = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    marmailgonder = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    vadfarkgelgid = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    pom_kapsec = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sistem_ytlstr = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true, defaultValue: "YTL"),
                    sistem_kasakur = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    grp_perpomid = table.Column<int>(type: "int", nullable: true),
                    grp_permarid = table.Column<int>(type: "int", nullable: true),
                    grp_madyagid = table.Column<int>(type: "int", nullable: true),
                    akyakitstokbrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    marketstokbrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    grp_gelirid = table.Column<int>(type: "int", nullable: true),
                    grp_giderid = table.Column<int>(type: "int", nullable: true),
                    grp_madeniyagid = table.Column<int>(type: "int", nullable: true),
                    grp_musid = table.Column<int>(type: "int", nullable: true),
                    grp_satid = table.Column<int>(type: "int", nullable: true),
                    devirtarihsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deviruserad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    marsatgiderkart = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    marsatstkuyrses = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    printrenksiz = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    dbversion = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    iskonto_gid = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cekmaskod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    marketsatpbrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    marsateksistok = table.Column<int>(type: "int", nullable: true),
                    pomvarozet = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    marvardiackfaz = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    adres1 = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: true),
                    adres2 = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: true),
                    sayimtip = table.Column<int>(type: "int", nullable: true),
                    posmaskod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    fisesasbrm = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    alfisesbrm = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    kap = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    grp_hizmet = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    donem_tarih = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    yazbarkont = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    vts_fis_yazdir = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    carimailgonder = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    zrap_carkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    terazikarksay = table.Column<int>(type: "int", nullable: true, defaultValue: 7),
                    fatesasbrm = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    kas_fin_var = table.Column<int>(type: "int", nullable: true),
                    var_tes_tek = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    oto_belgeno = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    muh_entegre = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true, defaultValue: "Yok"),
                    carvadfarkgelgid = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    yedek_dizin = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    marsatf2ekran = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    marpossatkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true, defaultValue: ""),
                    per_maasgidkart = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    grid_secrenk = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    sistem_parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    tel_no = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    fax_no = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    alfatesbrm = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    fisyenfiygelgid = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    hvz_fis_oto = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    ver_fis_kisa = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    fisvad_eksi_izni = table.Column<int>(type: "int", nullable: true),
                    fat_iskonto_kart = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    rap_hrk_bas_tar = table.Column<DateTime>(type: "datetime", nullable: true),
                    hvz_fis_kart_oto = table.Column<byte>(type: "tinyint", nullable: true),
                    lim_asim_sor = table.Column<byte>(type: "tinyint", nullable: true),
                    fis_iskonto_kart = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    vts_oto_var_aktar = table.Column<byte>(type: "tinyint", nullable: true),
                    plaka_kont_dev = table.Column<byte>(type: "tinyint", nullable: true),
                    Para_Ondalik = table.Column<int>(type: "int", nullable: true),
                    plaka_yeni_sor = table.Column<byte>(type: "tinyint", nullable: true),
                    Var_Veresi_Fis = table.Column<int>(type: "int", nullable: true),
                    Var_Alacak_Fis = table.Column<byte>(type: "tinyint", nullable: true),
                    Prom_Depo = table.Column<int>(type: "int", nullable: true),
                    Prom_Fis_Rap = table.Column<int>(type: "int", nullable: true),
                    Var_Hrk_Tar_isle = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    vts_fis_cari_sec = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    var_fis_emtia_isle = table.Column<bool>(type: "bit", nullable: true),
                    Kur_Sor = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    Var_Top_Eposta = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    Muh_PosCarKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Muh_PosGidKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Puan_Yuv_Tip = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    SayimKont = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)1),
                    Kart_Unvan_Kod = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    Kasa_Tarih = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    fat_ver_satir_deg = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    Akaryakit_Tum_Firma = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Pom_Var_Eksi_Stok = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Zrapor_Esas_Brm = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Market_Sube = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    BekoPos_Otomatik = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    mar_kapsec = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    market1FiyatGit = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    Pom_Var_Otomas_Plaka = table.Column<bool>(type: "bit", nullable: true),
                    Var_Pos_Isle = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    Market_Stok_AltGrup = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    FaturaFisIskonto = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    TTS_BankaKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EfaturaSeriNoOto = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    Oto_FisVade = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Oto_FisVadeZaman = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true, defaultValue: "04:30"),
                    Entegre_SubeNo = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    CariAvansTakip = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    TTS_BankaKod2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MarketCikisSifre = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Puan_Plaka_Kont = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    MarketCikisSifreKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BedelsizBarkodKontrol = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Mar_Var_Pos_Isle = table.Column<bool>(type: "bit", nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__sistemta__3213E83FFB743605", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SmsGonderimLog",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    EntegreTip = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    CariTip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    CariKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Aciklama = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Cevap = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Gonderim = table.Column<bool>(type: "bit", nullable: true),
                    OlusturmaTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlusturmaKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DegistirmeTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegistirmeKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SilTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    SilKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    RemoteId = table.Column<int>(type: "int", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tasiyici__3213E83F5920D841_SmsGonderimLog", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SmsSablon",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Ad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Aciklama = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    OlusturmaTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlusturmaKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DegistirmeTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegistirmeKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SilTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    SilKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    RemoteId = table.Column<int>(type: "int", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SoforKart",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Ad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SoyAd = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TcNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    OlusturmaTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlusturmaKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DegistirmeTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegistirmeKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SilTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    SilKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    RemoteId = table.Column<int>(type: "int", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SoforKar__3213E83FA4D121FE", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Stk_Tip",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    kod = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Ack_tr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ack_en = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ack_al = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ack_ru = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Ondalik_Hane = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Stk_Tip__3213E83FE66C22A5", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "stkbrm",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kod = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    ad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Sil = table.Column<bool>(type: "bit", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__stkbrm__DFEE66867B89FB26", x => new { x.id, x.kod });
                });

            migrationBuilder.CreateTable(
                name: "stkdeptrs",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stktrsid = table.Column<double>(type: "float", nullable: false),
                    stktip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    stkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, defaultValue: "00:00:00"),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    varno = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    varok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    girdepkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    cikdepkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    yertip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    yerad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    miktar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    brmfiykdvli = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    kdvyuz = table.Column<double>(type: "float", nullable: true),
                    otv = table.Column<double>(type: "float", nullable: true),
                    kesafet = table.Column<double>(type: "float", nullable: true),
                    belno = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ack = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    stktipad = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    carpan = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    brim = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    girstkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true, defaultValue: ""),
                    girstktip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true, defaultValue: ""),
                    Sil = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    islmtip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    islmtipad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    gircarpan = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    girbrim = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    sayackod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    trs_id = table.Column<int>(type: "int", nullable: true),
                    Barkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Tutar_Kdvli = table.Column<double>(type: "float", nullable: true),
                    gfirmano = table.Column<int>(type: "int", nullable: true),
                    cfirmano = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__stkdeptr__DA4FEDD3F93ACD11", x => new { x.id, x.stktrsid, x.stkod, x.stktip });
                });

            migrationBuilder.CreateTable(
                name: "Stkdeptrsmas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    trs_id = table.Column<int>(type: "int", nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    cfirmano = table.Column<int>(type: "int", nullable: true),
                    gfirmano = table.Column<int>(type: "int", nullable: true),
                    Girdepkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Girdep_id = table.Column<int>(type: "int", nullable: true),
                    Cikdepkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Cikdep_id = table.Column<int>(type: "int", nullable: true),
                    Bel_Seri = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Bel_No = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Ack = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Yertip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Yerad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    sil = table.Column<int>(type: "int", nullable: true),
                    GirDep_Tip = table.Column<int>(type: "int", nullable: true),
                    CikDep_Tip = table.Column<int>(type: "int", nullable: true),
                    Gen_Top = table.Column<double>(type: "float", nullable: true),
                    kayok = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Stkdeptr__3213E83FA6120DEA", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "stkdrm",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stktip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    stkod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    depkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    girenmik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    girenbrmkdvli = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    cikanmik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    cikanbrmkdvli = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__stkdrm__FBBAEBEF8A431A92", x => new { x.id, x.stkod, x.depkod, x.stktip });
                });

            migrationBuilder.CreateTable(
                name: "stkhrk",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stkhrkid = table.Column<double>(type: "float", nullable: false),
                    stktip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    stkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    tabload = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    gctip = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    depkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    islmid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    varno = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    varok = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    islmtip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    islmtipad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    yertip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true, defaultValue: "00:00:00"),
                    yerad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    giren = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    cikan = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    kalan = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    brmfiykdvli = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    kdvyuz = table.Column<double>(type: "float", nullable: true),
                    otv = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    kesafet = table.Column<double>(type: "float", nullable: true),
                    belno = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ack = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    stktipad = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    pro = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    aiademik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    siademik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    brmsatirisktut = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    brmgidertut = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    brmgenelisktut = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    fatid = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    fisid = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    irid = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    marsatid = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sayid = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    pomsatid = table.Column<int>(type: "int", nullable: true),
                    tip_id = table.Column<int>(type: "int", nullable: true),
                    Stk_id = table.Column<int>(type: "int", nullable: true),
                    Barkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    stktip_id = table.Column<int>(type: "int", nullable: true),
                    Promid = table.Column<long>(type: "bigint", nullable: true),
                    Puanid = table.Column<int>(type: "int", nullable: true),
                    Dep_id = table.Column<int>(type: "int", nullable: true),
                    remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    FatDep_id = table.Column<int>(type: "int", nullable: true),
                    Tarihli = table.Column<bool>(type: "bit", nullable: true),
                    Fireid = table.Column<int>(type: "int", nullable: true),
                    FiyTip = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Karsi_KartTip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Karsi_KartKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ResSatId = table.Column<int>(type: "int", nullable: true),
                    DepTrsId = table.Column<int>(type: "int", nullable: true),
                    DepoTip = table.Column<int>(type: "int", nullable: true),
                    DepoId = table.Column<int>(type: "int", nullable: true),
                    MarSatRecHrkId = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    UrunId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    DepTrsHrkId = table.Column<int>(type: "int", nullable: true),
                    ResSatRecHrkId = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__stkhrk__7D2B516CD3A82BDE", x => new { x.id, x.stkhrkid, x.stkod, x.stktip });
                });

            migrationBuilder.CreateTable(
                name: "stkhrktip",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kod = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    gc = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__stkhrkti__3213E83FDB84F3AC", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Stok_Fiyat",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaNo = table.Column<int>(type: "int", nullable: true),
                    Stktip_id = table.Column<int>(type: "int", nullable: true),
                    Stk_id = table.Column<int>(type: "int", nullable: true),
                    FiyTip = table.Column<byte>(type: "tinyint", nullable: true),
                    FiyNo = table.Column<int>(type: "int", nullable: true),
                    Fiyat = table.Column<double>(type: "float", nullable: true),
                    Kdv = table.Column<double>(type: "float", nullable: true),
                    KdvTip = table.Column<byte>(type: "tinyint", nullable: true),
                    ParaBrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Remote_id = table.Column<int>(type: "int", nullable: true),
                    FiyatDegisimTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Stok_Fiy__3213E83F9648F878", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Stok_Recete",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Urun_id = table.Column<int>(type: "int", nullable: true),
                    StkTip_id = table.Column<int>(type: "int", nullable: true, defaultValue: 2),
                    Stk_id = table.Column<int>(type: "int", nullable: true),
                    Brm = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Miktar = table.Column<double>(type: "float", nullable: true),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    SyncStatus = table.Column<byte>(type: "tinyint", nullable: true),
                    RemoteId = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Stok_Rec__3213E83FD138FCCB", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "stokfiyathistory",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true),
                    kaytip = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    tip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    sat1fiy = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    sat1kdv = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    sat1kdvtip = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    sat1pbrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    sat2fiy = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    sat2kdv = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    sat2kdvtip = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    sat2pbrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    sat3fiy = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    sat3kdv = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    sat3kdvtip = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    sat3pbrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    sat4fiy = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    sat4kdv = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    sat4kdvtip = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    sat4pbrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    alsfiy = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    alskdv = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    alskdvtip = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    alspbrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__stokfiya__DFEE66865D549C1D", x => new { x.id, x.kod });
                });

            migrationBuilder.CreateTable(
                name: "StokFiyatLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaNo = table.Column<int>(type: "int", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    StokTipId = table.Column<int>(type: "int", nullable: true),
                    StokId = table.Column<int>(type: "int", nullable: true),
                    SatisFiyat = table.Column<decimal>(type: "decimal(10,5)", nullable: true),
                    AlisFiyat = table.Column<decimal>(type: "decimal(10,5)", nullable: true),
                    TedarikFiyat = table.Column<decimal>(type: "decimal(10,5)", nullable: true),
                    MarjYuzde = table.Column<decimal>(type: "decimal(10,5)", nullable: true),
                    SatisKdv = table.Column<decimal>(type: "decimal(10,5)", nullable: true),
                    AlisKdv = table.Column<decimal>(type: "decimal(10,5)", nullable: true),
                    ParaBrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Remote_id = table.Column<int>(type: "int", nullable: true),
                    OlusUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    OlusTarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DegTarSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__StokFiya__3213E83F18BC3A69", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "stokkart",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    drm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    sil = table.Column<int>(type: "int", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    barkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true, defaultValue: ""),
                    ad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    sat1fiy = table.Column<double>(type: "float", nullable: true),
                    sat1kdv = table.Column<double>(type: "float", nullable: true),
                    sat1kdvtip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    sat2fiy = table.Column<double>(type: "float", nullable: true),
                    sat2kdv = table.Column<double>(type: "float", nullable: true),
                    sat2kdvtip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    alsfiy = table.Column<double>(type: "float", nullable: true),
                    alskdv = table.Column<double>(type: "float", nullable: true),
                    alskdvtip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    kesft = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    brim = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    otv = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    eksat = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    minmik = table.Column<double>(type: "float", nullable: true),
                    muhgrskod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    muhckskod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    brmcarp = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    brmust = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true, defaultValue: ""),
                    ykno = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    grp1 = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    grp2 = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    grp3 = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    alsmik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    satmik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    acmik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    karoran1 = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    karoran2 = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    grpkdvoran = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    sat1pbrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    sat2pbrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    sat3pbrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    sat4pbrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    alspbrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    sat3fiy = table.Column<double>(type: "float", nullable: true),
                    sat3kdv = table.Column<double>(type: "float", nullable: true),
                    sat3kdvtip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    sat4fiy = table.Column<double>(type: "float", nullable: true),
                    sat4kdv = table.Column<double>(type: "float", nullable: true),
                    sat4kdvtip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    alskdvlitoptut = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    satkdvlitoptut = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    alsiademik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    alsiadekdvlitoptut = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    satiademik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    satiadekdvlitoptut = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    ortalsfiykdvli = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    brmust2 = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    brmcarp2 = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    zrapor = table.Column<byte>(type: "tinyint", nullable: true),
                    muh_als_iad_kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    muh_sat_iad_kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    muh_als_isk_kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    muh_sat_isk_kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    muh_als_otv_kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    muh_sat_otv_kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    muh_sat_mal_kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    muhonkod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ozel_kod1 = table.Column<int>(type: "int", nullable: true),
                    ozel_kod2 = table.Column<int>(type: "int", nullable: true),
                    notack = table.Column<string>(type: "varchar(8000)", unicode: false, maxLength: 8000, nullable: true),
                    tip_id = table.Column<int>(type: "int", nullable: true),
                    Puan_Brm = table.Column<byte>(type: "tinyint", nullable: true),
                    Puan_Tip = table.Column<byte>(type: "tinyint", nullable: true),
                    Puan_Nakit = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Puan_KK = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Puan_Fis = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Prom = table.Column<bool>(type: "bit", nullable: true),
                    Prom_Urun = table.Column<bool>(type: "bit", nullable: true),
                    Prom_Sat_Tip = table.Column<byte>(type: "tinyint", nullable: true),
                    Prom_Sat_Puan = table.Column<double>(type: "float", nullable: true),
                    Prom_Kac_Satis = table.Column<int>(type: "int", nullable: true),
                    Puan_Otomas = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Gtip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Epdk_Tur = table.Column<int>(type: "int", nullable: true),
                    YK_Fiyat = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Recete = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Restaurant = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    KarYuzde = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Bildirim = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    BagliCariKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Yerli = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    UretimYerId = table.Column<int>(type: "int", nullable: true),
                    SatisFiyat1DegisimTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    SatisFiyat2DegisimTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    SatisFiyat3DegisimTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    SatisFiyat4DegisimTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlcumBirimId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    OlcumBirimCarpan = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    SatisFiyatDegistir = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    EtiketId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    AlisFiyatDegisimTarih = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__stokkart__C1BF6FD6B2EE7A89", x => new { x.id, x.tip, x.kod, x.drm, x.sil });
                });

            migrationBuilder.CreateTable(
                name: "StokMuhTanim",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaNo = table.Column<int>(type: "int", nullable: true),
                    Stk_id = table.Column<int>(type: "int", nullable: true),
                    MuhOnKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    MuhGrsKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    MuhCksKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    MuhAlsIadeKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    MuhSatIadeKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    olususer = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__StokMuhT__3213E83F1E9D8CB7", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "StokSonKullanim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaNo = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    StokId = table.Column<int>(type: "int", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Miktar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    OlusturmaTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlusturmaKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DegistirmeTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegistirmeKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SilTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    SilKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__StokSonK__3214EC0777118251", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tablelog",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    tablead = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    hrkid = table.Column<double>(type: "float", nullable: true),
                    islemtip = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tablelog__3213E83FBB6B3F6A", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tablo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    tabload = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    alias = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tablo_alan",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    tabloid = table.Column<int>(type: "int", nullable: true),
                    alan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    tip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    alias = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TahsilatOdeme",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true),
                    fatid = table.Column<int>(type: "int", nullable: true),
                    fisid = table.Column<int>(type: "int", nullable: true),
                    cartip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cartip_id = table.Column<int>(type: "int", nullable: true),
                    carkod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    belno = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ack = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    islmtip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    islmhrk = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    karsi_cartip_id = table.Column<int>(type: "int", nullable: true),
                    karsi_cartip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    karsi_carkod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    giren = table.Column<double>(type: "float", nullable: true),
                    cikan = table.Column<double>(type: "float", nullable: true),
                    vadetar = table.Column<DateTime>(type: "datetime", nullable: true),
                    cekid = table.Column<int>(type: "int", nullable: true),
                    gidkod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    gidtutar = table.Column<double>(type: "float", nullable: true),
                    kur = table.Column<double>(type: "float", nullable: true),
                    kesideci = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    hesapno = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ceksenno = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    yertip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    islmtipad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    islmhrkad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    yerad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    varno = table.Column<int>(type: "int", nullable: true),
                    varok = table.Column<int>(type: "int", nullable: true),
                    perkod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    adaid = table.Column<int>(type: "int", nullable: true),
                    olususer = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Genel_Ack = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Grp = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Grp_Tip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Tutar = table.Column<double>(type: "float", nullable: true),
                    bankkod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    drm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    drmad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    bankad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    banksub = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    deguser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    sil = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    ekkomyuz = table.Column<double>(type: "float", nullable: true),
                    extrakomyuz = table.Column<double>(type: "float", nullable: true),
                    bankomyuz = table.Column<double>(type: "float", nullable: true),
                    krekartno = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    gid_id = table.Column<int>(type: "int", nullable: true),
                    karsi_car_id = table.Column<int>(type: "int", nullable: true),
                    car_id = table.Column<int>(type: "int", nullable: true),
                    Kart_ParaBrm = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Kart_Kur = table.Column<double>(type: "float", nullable: true),
                    refno = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Vadeli = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    CekSeriNo_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tahsilat__3213E83FE98F27A1", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Taksit_hrk",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Mas_id = table.Column<int>(type: "int", nullable: true),
                    Sr = table.Column<int>(type: "int", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Tutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Kur = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    parabrm = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    olususer = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    kayok = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Yertip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Yerad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Taksit_h__3213E83FBD3A73BA", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tankkart",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    bagak = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: false),
                    ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    kapsit = table.Column<double>(type: "float", nullable: true),
                    minmik = table.Column<double>(type: "float", nullable: true),
                    drm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    acmik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    alsmik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    satmik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    stktip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    alskdvlitoptut = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    satkdvlitoptut = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Remote_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tankkart__8EEB9CC18401DDC8", x => new { x.id, x.kod, x.bagak, x.firmano });
                });

            migrationBuilder.CreateTable(
                name: "Tarih_Kapat",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaNo = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    drm = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    sil = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    deguser = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tarih_Ka__3213E83F4E701B88", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TasiyiciFirmaKart",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Unvan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Aciklama = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    KurumTip = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    Ad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SoyAd = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    VergiKimlikNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Adres = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AdresIl = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AdresIlce = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OlusturmaTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlusturmaKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DegistirmeTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegistirmeKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SilTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    SilKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    RemoteId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    AdresPostaKod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tasiyici__3213E83F750D7374", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tatiller",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    tar = table.Column<DateTime>(type: "datetime", nullable: true),
                    ack = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tatiller__3213E83FAB116D1A", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tesis",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tesis__3213E83F5571ABB3", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TeslimYerKart",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Unvan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Adres = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AdresIl = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AdresIlce = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OlusturmaTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlusturmaKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DegistirmeTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegistirmeKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SilTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    SilKullaniciUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    RemoteId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    AdresPostaKod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TopluKayit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    IslemTipId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    KartTipId = table.Column<int>(type: "int", nullable: true),
                    KartKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    BelgeNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Aciklama = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    OlusTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlusUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DegisTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegisUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    KayOk = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TopluKay__3214EC0764535F22", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TopluKayitHrk",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopluKayitId = table.Column<int>(type: "int", nullable: true),
                    SiraNo = table.Column<int>(type: "int", nullable: true),
                    KartTipId = table.Column<int>(type: "int", nullable: true),
                    KartUniqId = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    KartKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Tutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Aciklama = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    OlusTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlusUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DegisTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegisUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TopluKay__3214EC076918143F", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TopluVirmanKayit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    KartBA = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true, defaultValue: "B"),
                    KartTipId = table.Column<int>(type: "int", nullable: true),
                    KartKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    BelgeNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OlusTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlusUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DegisTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegisUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    KayOk = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TopluKay__3214EC0764535F22_TopluVirmanKayit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TopluVirmanKayitHrk",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopluKayitId = table.Column<int>(type: "int", nullable: true),
                    SiraNo = table.Column<int>(type: "int", nullable: true),
                    KartTipId = table.Column<int>(type: "int", nullable: true),
                    KartUniqId = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    KartKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Borc = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Alacak = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Aciklama = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    OlusTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlusUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DegisTarihSaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegisUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TopluKay__3214EC076918143F_TopluVirmanKayitHrk", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TTS_BankaTahsilat",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firmano = table.Column<int>(type: "int", nullable: true),
                    Plaka = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OdeTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Saat = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Tutar = table.Column<double>(type: "float", nullable: true),
                    Dosya = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Verid = table.Column<int>(type: "int", nullable: true),
                    CariKod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    FisSeriNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TTS_Bank__3213E83F4C3813BF", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TTS_OdeTip",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Tip = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TTS_OdeT__3213E83FCB8A9E21", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UlkeList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UlkeList__3214EC072F40CEB0", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "userformgrup",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    firmano = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__userform__DFEE6686DC218E91", x => new { x.id, x.kod });
                });

            migrationBuilder.CreateTable(
                name: "userformhak",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    formkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    firmano = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    h1 = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    h2 = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    h3 = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    h4 = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    h5 = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    h6 = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    h7 = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    h8 = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    h9 = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    h10 = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    h11 = table.Column<bool>(type: "bit", nullable: true),
                    h12 = table.Column<bool>(type: "bit", nullable: true),
                    h13 = table.Column<bool>(type: "bit", nullable: true),
                    h14 = table.Column<bool>(type: "bit", nullable: true),
                    h15 = table.Column<bool>(type: "bit", nullable: true),
                    h16 = table.Column<bool>(type: "bit", nullable: true),
                    h17 = table.Column<bool>(type: "bit", nullable: true),
                    h18 = table.Column<bool>(type: "bit", nullable: true),
                    h19 = table.Column<bool>(type: "bit", nullable: true),
                    h20 = table.Column<bool>(type: "bit", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__userform__2E86D38671DA9E7B", x => new { x.id, x.userkod, x.formkod });
                });

            migrationBuilder.CreateTable(
                name: "userformhrk",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    formid = table.Column<double>(type: "float", nullable: true),
                    firmano = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    tan1 = table.Column<int>(type: "int", nullable: true),
                    tan2 = table.Column<int>(type: "int", nullable: true),
                    tan3 = table.Column<int>(type: "int", nullable: true),
                    tan4 = table.Column<int>(type: "int", nullable: true),
                    tan5 = table.Column<int>(type: "int", nullable: true),
                    tan6 = table.Column<int>(type: "int", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__userform__3213E83FD71CBAE3", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "userformlar",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    grupkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    firmano = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    formkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    fromack = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    sira = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__userform__B7DD4CEF0442E7E3", x => new { x.id, x.grupkod });
                });

            migrationBuilder.CreateTable(
                name: "userlog",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: false),
                    firmano = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    usr = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    kayitid = table.Column<double>(type: "float", nullable: false),
                    ack = table.Column<string>(type: "varchar(8000)", unicode: false, maxLength: 8000, nullable: true),
                    ip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    pcadi = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    islem = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    tablo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__userlog__B05752918862AB59", x => new { x.id, x.tarih });
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: false),
                    sifre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    gorev = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    lang = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    gectar = table.Column<DateTime>(type: "datetime", nullable: true),
                    aktif = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    mail = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, defaultValue: ""),
                    pc = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    version = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    printduz = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sisgrstarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    sisckstarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    indsec = table.Column<bool>(type: "bit", nullable: true),
                    indyuzde = table.Column<int>(type: "int", nullable: true),
                    yetki = table.Column<int>(type: "int", nullable: true),
                    vad_gelen = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    firmaid = table.Column<int>(type: "int", nullable: true),
                    mar_dep_kod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    islem_Gun_sure = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    firma_sec = table.Column<byte>(type: "tinyint", nullable: true),
                    Pom_Gec_Sayac_Grs = table.Column<byte>(type: "tinyint", nullable: true),
                    Per_id = table.Column<int>(type: "int", nullable: true),
                    ch_firma_Sec = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    ch_Tum_Kartlar = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    BilgiEkranGosterimTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    KartListGrupYetki = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__users__DFEE6686681932CA", x => new { x.id, x.kod });
                });

            migrationBuilder.CreateTable(
                name: "usrgrid",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    users = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    form = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    grid = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    dosya = table.Column<byte[]>(type: "image", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__usrgrid__E0AB2F4862BF6694", x => new { x.id, x.users });
                });

            migrationBuilder.CreateTable(
                name: "usrsplit",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    users = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    form = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    genis = table.Column<int>(type: "int", nullable: true),
                    panel = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__usrsplit__E0AB2F484ED18BE5", x => new { x.id, x.users });
                });

            migrationBuilder.CreateTable(
                name: "vardikasa",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__vardikas__DFEE6686B44F8340", x => new { x.id, x.kod });
                });

            migrationBuilder.CreateTable(
                name: "veresifarkhrk",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    masterid = table.Column<int>(type: "int", nullable: true),
                    verid = table.Column<int>(type: "int", nullable: true),
                    verhrkid = table.Column<int>(type: "int", nullable: true),
                    tip = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    eski_fiyat = table.Column<double>(type: "float", nullable: true),
                    yeni_fiyat = table.Column<double>(type: "float", nullable: true),
                    eski_vadetar = table.Column<DateTime>(type: "datetime", nullable: true),
                    yeni_vadetar = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__veresifa__3213E83F362F8C92", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "veresihrk",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    varno = table.Column<double>(type: "float", nullable: false),
                    verid = table.Column<double>(type: "float", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    stktip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    stkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    mik = table.Column<decimal>(type: "decimal(10,5)", nullable: true),
                    brmfiy = table.Column<decimal>(type: "decimal(38,14)", nullable: true),
                    depkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    kdvyuz = table.Column<double>(type: "float", nullable: true),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    yenbrmfiyfark = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    kayok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    akfiytip = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true, defaultValue: ""),
                    brim = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    iskyuz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    fiyfarktop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    vadfarktop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    vadfarkcarhrkid = table.Column<int>(type: "int", nullable: true),
                    vadetar = table.Column<DateTime>(type: "datetime", nullable: true),
                    stktip_id = table.Column<int>(type: "int", nullable: true),
                    stk_id = table.Column<int>(type: "int", nullable: true),
                    dep_id = table.Column<int>(type: "int", nullable: true),
                    otvbrim = table.Column<double>(type: "float", nullable: true),
                    Kart_ParaBrm = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Kart_Kur = table.Column<double>(type: "float", nullable: true),
                    Islem_ParaBrm = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Islem_Kur = table.Column<double>(type: "float", nullable: true),
                    barkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Otomas_Id = table.Column<int>(type: "int", nullable: true),
                    Fat_IskYuz = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__veresihr__0E10EA9A3B357DEA", x => new { x.id, x.varno, x.verid });
                });

            migrationBuilder.CreateTable(
                name: "veresimas",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    verid = table.Column<double>(type: "float", nullable: false),
                    varno = table.Column<double>(type: "float", nullable: false),
                    fatid = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    vtsid = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    varok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    kayok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    fisad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fistip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    yertip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    yerad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    seri = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    no = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ykno = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    cartip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    carkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    plaka = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    perkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    adaid = table.Column<int>(type: "int", nullable: true),
                    surucu = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    km = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    toptut = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    ack = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    kmsec = table.Column<int>(type: "int", nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    ototag = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    dataok = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    aktip = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true, defaultValue: "BK"),
                    fatbelno = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    aktar = table.Column<DateTime>(type: "datetime", nullable: true),
                    vadtar = table.Column<DateTime>(type: "datetime", nullable: true),
                    bagid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    marsatid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    kur = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    akid = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    otocarkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    otocarad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    havuzfis = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    havvarno = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    cardno = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    isktop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    istas_ad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    istas_il = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    otomas_id = table.Column<int>(type: "int", nullable: true),
                    otomas_ack = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    fiyfarktop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    vadfarktop = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    brc_carkod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    brc_cartip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    brc_carsec = table.Column<bool>(type: "bit", nullable: true),
                    fis_cariver_id = table.Column<int>(type: "int", nullable: true),
                    vts_oto_aktar = table.Column<bool>(type: "bit", nullable: true),
                    fis_alc_kocan = table.Column<bool>(type: "bit", nullable: true),
                    fis_alc_bagverid = table.Column<int>(type: "int", nullable: true),
                    hrk_car_pro = table.Column<bool>(type: "bit", nullable: true),
                    hrk_stk_pro = table.Column<bool>(type: "bit", nullable: true),
                    gctip = table.Column<int>(type: "int", nullable: true),
                    fistur_id = table.Column<int>(type: "int", nullable: true),
                    fistip_id = table.Column<int>(type: "int", nullable: true),
                    fisrap_id = table.Column<int>(type: "int", nullable: true),
                    car_id = table.Column<int>(type: "int", nullable: true),
                    cartip_id = table.Column<int>(type: "int", nullable: true),
                    kdvtip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Kart_ParaBrm = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Kart_Kur = table.Column<double>(type: "float", nullable: true),
                    Islem_ParaBrm = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Islem_Kur = table.Column<double>(type: "float", nullable: true),
                    remote_id = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    prom_pro = table.Column<bool>(type: "bit", nullable: true),
                    emtia_isle = table.Column<bool>(type: "bit", nullable: true),
                    Top_Mik = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Gec_PerKod = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Alc_CarSec = table.Column<bool>(type: "bit", nullable: true),
                    devir = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    TTS_Tip = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Entegre = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Entegre_Tip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Entegre_Aktar = table.Column<DateTime>(type: "datetime", nullable: true),
                    TTS_OdemeTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    TTS_OdemeTakip = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    YkFisNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Genel_KdvToplam = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Genel_KdvliToplam = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    TransferStartId = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    TransferStopId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    TransferDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    DevirliVadeTarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    OncekiKm = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    ServisFis = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    UTTS = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__veresima__0E10EA9A0B125ED9", x => new { x.id, x.varno, x.verid });
                });

            migrationBuilder.CreateTable(
                name: "VeresiVadeFarkHrk",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarTip = table.Column<int>(type: "int", nullable: true),
                    CarId = table.Column<int>(type: "int", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    VadeOran = table.Column<double>(type: "float", nullable: true),
                    Borc = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Alacak = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    VadeFark = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VeresiVa__3213E83F1BE2DC33", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "veresiyenfiyhrk",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    masterid = table.Column<int>(type: "int", nullable: true),
                    verid = table.Column<int>(type: "int", nullable: true),
                    verhrkid = table.Column<int>(type: "int", nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    eski_fiyat = table.Column<double>(type: "float", nullable: true),
                    yeni_fiyat = table.Column<double>(type: "float", nullable: true),
                    eski_vadetar = table.Column<DateTime>(type: "datetime", nullable: true),
                    yeni_vadetar = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    ack = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    yertip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    yerad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__veresiye__3213E83FA26317D9", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "yazarkasa",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    islmid = table.Column<double>(type: "float", nullable: true),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    varno = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    dosyayer = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    users = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    islemtipi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    yazkasatipi = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    aktar = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true, defaultValue: "-"),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    marsatid = table.Column<int>(type: "int", nullable: true),
                    KasaNo = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    KasiyerNo = table.Column<int>(type: "int", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__yazarkas__3213E83F586C4F66", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "YazarKasa_Satis",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KasaTip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    KasaNo = table.Column<int>(type: "int", nullable: true),
                    Tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    Carpan = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    FisNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    StokId = table.Column<int>(type: "int", nullable: true),
                    StokKod = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Barkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Miktar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    BrimFiyat = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Tutar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Kdv = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Brim = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Remote_Id = table.Column<int>(type: "int", nullable: true),
                    Trans = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    FirmaNo = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    YazarKasaIslemId = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    ZNo = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    VardiyaNo = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    KasiyerKod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true, defaultValueSql: "((0))"),
                    KasiyerUnvan = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    BankaTerminalNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NakitOdeme = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    PosOdeme = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__YazarKas__3213E83F39A24343", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "yazarkasakart",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: false),
                    kod = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    sil = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DepoKod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__yazarkas__2D8940EEF83452E0", x => new { x.id, x.firmano, x.kod });
                });

            migrationBuilder.CreateTable(
                name: "yazkasagrpkart",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    grp = table.Column<int>(type: "int", nullable: true),
                    sil = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__yazkasag__3213E83F700D2644", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "yedek",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    dosyaad = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    ok = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__yedek__3213E83F10CE6896", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "yertipad",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__yertipad__3213E83F1263C7F0", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "yetki",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true),
                    ad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    sysyetki = table.Column<bool>(type: "bit", nullable: true),
                    sil = table.Column<bool>(type: "bit", nullable: true),
                    havuz = table.Column<bool>(type: "bit", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modul = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "yetkibolum",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true),
                    yetkiid = table.Column<int>(type: "int", nullable: true),
                    bolumid = table.Column<int>(type: "int", nullable: true),
                    havuz = table.Column<bool>(type: "bit", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modul = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "yetkifrm",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true),
                    yetkiid = table.Column<int>(type: "int", nullable: true),
                    bolumid = table.Column<int>(type: "int", nullable: true),
                    frmid = table.Column<int>(type: "int", nullable: true),
                    havuz = table.Column<int>(type: "int", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modul = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "yetkikont",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmano = table.Column<int>(type: "int", nullable: true),
                    yetkiid = table.Column<int>(type: "int", nullable: true),
                    bolumid = table.Column<int>(type: "int", nullable: true),
                    frmid = table.Column<int>(type: "int", nullable: true),
                    kontid = table.Column<int>(type: "int", nullable: true),
                    havuz = table.Column<bool>(type: "bit", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modul = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Rap_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "zraporhrk",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    zrapid = table.Column<int>(type: "int", nullable: false),
                    tip = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    kod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    kdvyuz = table.Column<double>(type: "float", nullable: true),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    kayok = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    miktar = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    brmfiy = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__zraporhr__3EF8B5C3E872145B", x => new { x.id, x.zrapid });
                });

            migrationBuilder.CreateTable(
                name: "zrapormas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    zrapid = table.Column<int>(type: "int", nullable: false),
                    firmano = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    ykkod = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    saat = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    carkod = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    cartip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    zraptip = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    yertip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    yerad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    toptut = table.Column<double>(type: "float", nullable: true),
                    pbrim = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    olususer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    deguser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    degtarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    zserino = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    zseri = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    varno = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    kur = table.Column<double>(type: "float", nullable: true, defaultValue: 1.0),
                    ack = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    parabrm = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    kayok = table.Column<byte>(type: "tinyint", nullable: true, defaultValue: (byte)0),
                    Genel_Kdv_Top = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Genel_Ara_Top = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Genel_Top = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    cartip_id = table.Column<int>(type: "int", nullable: true),
                    Nak_Top = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Pos_Top = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Ver_Top = table.Column<double>(type: "float", nullable: true, defaultValue: 0.0),
                    Entegre = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    Entegre_Tip = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Entegre_Aktar = table.Column<DateTime>(type: "datetime", nullable: true),
                    MasId = table.Column<int>(type: "int", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__zraporma__3EF8B5C35E4895FD", x => new { x.id, x.zrapid });
                });

            migrationBuilder.CreateTable(
                name: "ZraporVardiya",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zrapid = table.Column<int>(type: "int", nullable: true),
                    VarTip = table.Column<int>(type: "int", nullable: true),
                    VarNo = table.Column<int>(type: "int", nullable: true),
                    VarAd = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Olustarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    OlusUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DegisTarsaat = table.Column<DateTime>(type: "datetime", nullable: true),
                    DegisUser = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Sil = table.Column<bool>(type: "bit", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ZraporVa__3213E83FDF02CE5B", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "AppSayim_AppSayimId_SiraNo_Index",
                table: "AppSayim",
                columns: new[] { "DeviceId", "AppSayimId", "SiraNo" });

            migrationBuilder.CreateIndex(
                name: "bankakart_uq",
                table: "bankakart",
                column: "kod",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "barkod_idx",
                table: "barkod",
                columns: new[] { "tip", "kod" });

            migrationBuilder.CreateIndex(
                name: "barkod_kod_index",
                table: "barkod",
                column: "kod");

            migrationBuilder.CreateIndex(
                name: "carihrk_cartip_carkod_sil_alacak",
                table: "carihrk",
                columns: new[] { "cartip", "carkod", "sil", "alacak" });

            migrationBuilder.CreateIndex(
                name: "carihrk_cartip_sil",
                table: "carihrk",
                columns: new[] { "cartip", "sil" });

            migrationBuilder.CreateIndex(
                name: "carihrk_islmtip_islmhrk_sil",
                table: "carihrk",
                columns: new[] { "islmtip", "islmhrk", "sil" });

            migrationBuilder.CreateIndex(
                name: "carikart_grp_index",
                table: "carikart",
                columns: new[] { "grp1", "grp2", "grp3" });

            migrationBuilder.CreateIndex(
                name: "carikart_uq",
                table: "carikart",
                column: "kod",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "cekkart_uq_refno",
                table: "cekkart",
                column: "refno",
                unique: true,
                filter: "[refno] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "depokart_uq",
                table: "depokart",
                column: "kod",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__fattip__0D5AD24C",
                table: "fattip",
                column: "kod",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "faturamas_FirmaSeriNo_index",
                table: "faturamas",
                columns: new[] { "firmano", "fatid", "fatseri", "fatno", "sil" });

            migrationBuilder.CreateIndex(
                name: "UQ__fismas__6FD49106",
                table: "fismas",
                column: "fisno",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "gelgidkart_uq",
                table: "gelgidkart",
                column: "kod",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "grup_idx",
                table: "grup",
                column: "sr");

            migrationBuilder.CreateIndex(
                name: "grup_Tabload",
                table: "grup",
                columns: new[] { "tabload", "sil" });

            migrationBuilder.CreateIndex(
                name: "UQ__islemturtip__5FD3FEBE",
                table: "islemturtip",
                column: "tip",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "istkart_uq",
                table: "istkart",
                column: "kod",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "kasakapama_idx",
                table: "kasa_kapa",
                columns: new[] { "firmano", "tarih" });

            migrationBuilder.CreateIndex(
                name: "kasakapama_idx",
                table: "kasa_kapat",
                columns: new[] { "firmano", "tarih" });

            migrationBuilder.CreateIndex(
                name: "kasahrk_index2",
                table: "kasahrk",
                columns: new[] { "firmano", "kaskod", "tarih", "sil" });

            migrationBuilder.CreateIndex(
                name: "kasahrk_index3",
                table: "kasahrk",
                columns: new[] { "firmano", "kaskod", "sil", "tarih", "varno", "islmhrk" });

            migrationBuilder.CreateIndex(
                name: "kasahrk_uq",
                table: "kasahrk",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__kasahrk__3213E83E60268E7E",
                table: "kasahrk",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "kasakart_uq",
                table: "kasakart",
                column: "kod",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "marsathrk_marsatid_index",
                table: "marsathrk",
                columns: new[] { "marsatid", "sil" });

            migrationBuilder.CreateIndex(
                name: "marsathrk_SilGrupIndex1",
                table: "marsathrk",
                column: "sil");

            migrationBuilder.CreateIndex(
                name: "marsathrk_VarnoSilGrupIndex1",
                table: "marsathrk",
                columns: new[] { "varno", "sil" });

            migrationBuilder.CreateIndex(
                name: "marsatmas_marsatid_index",
                table: "marsatmas",
                columns: new[] { "marsatid", "sil" });

            migrationBuilder.CreateIndex(
                name: "marsatmas_varno_index",
                table: "marsatmas",
                column: "varno");

            migrationBuilder.CreateIndex(
                name: "marvardimas_varno_index",
                table: "marvardimas",
                column: "varno");

            migrationBuilder.CreateIndex(
                name: "otomasgenkod_idx",
                table: "otomasgenkod",
                column: "cartip");

            migrationBuilder.CreateIndex(
                name: "otomasgenkod_idx2",
                table: "otomasgenkod",
                column: "kod");

            migrationBuilder.CreateIndex(
                name: "otomasgenkod_index3",
                table: "otomasgenkod",
                column: "plaka");

            migrationBuilder.CreateIndex(
                name: "perkart_uq",
                table: "perkart",
                column: "kod",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "poskart_uq",
                table: "poskart",
                column: "kod",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Prom_Urun_Hrk_Car_id_index",
                table: "Prom_Puan_Hrk",
                column: "Car_id");

            migrationBuilder.CreateIndex(
                name: "Prom_Urun_Hrk_Sil_index",
                table: "Prom_Puan_Hrk",
                column: "Sil");

            migrationBuilder.CreateIndex(
                name: "Prom_Urun_Hrk_Tarih_index",
                table: "Prom_Puan_Hrk",
                column: "Tarih");

            migrationBuilder.CreateIndex(
                name: "Prom_Urun_Hrk_Urn_id_index",
                table: "Prom_Puan_Hrk",
                column: "Stk_id");

            migrationBuilder.CreateIndex(
                name: "Prom_Sat_Baslik_idx",
                table: "Prom_Sat_Baslik",
                column: "yerad");

            migrationBuilder.CreateIndex(
                name: "Prom_Sat_Baslik_idx2",
                table: "Prom_Sat_Baslik",
                column: "varno");

            migrationBuilder.CreateIndex(
                name: "sayackart_uq",
                table: "sayackart",
                column: "kod",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "sayimhrk_Sayid_index",
                table: "sayimhrk",
                columns: new[] { "sayid", "sil" });

            migrationBuilder.CreateIndex(
                name: "sayimhrk_stok_index",
                table: "sayimhrk",
                columns: new[] { "stkod", "stktip" });

            migrationBuilder.CreateIndex(
                name: "sayimmas_Sayid_index",
                table: "sayimmas",
                column: "sayid");

            migrationBuilder.CreateIndex(
                name: "stkbrm_uq",
                table: "stkbrm",
                column: "kod",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_stkhrk_tabloadfisid",
                table: "stkhrk",
                columns: new[] { "tabload", "fisid" });

            migrationBuilder.CreateIndex(
                name: "stkhrk_depo_index",
                table: "stkhrk",
                column: "depkod");

            migrationBuilder.CreateIndex(
                name: "stkhrk_Dev1x",
                table: "stkhrk",
                columns: new[] { "stktip", "depkod", "sil" });

            migrationBuilder.CreateIndex(
                name: "stkhrk_Dev2x",
                table: "stkhrk",
                columns: new[] { "stktip", "stkod", "depkod", "tarih", "sil" });

            migrationBuilder.CreateIndex(
                name: "stkhrk_Dev3x",
                table: "stkhrk",
                columns: new[] { "stktip", "stkod", "depkod", "tarih", "sil", "giren" });

            migrationBuilder.CreateIndex(
                name: "stkhrk_idx3",
                table: "stkhrk",
                columns: new[] { "stktip", "stkod", "firmano", "depkod", "sil" });

            migrationBuilder.CreateIndex(
                name: "stkhrk_idx4",
                table: "stkhrk",
                columns: new[] { "stktip", "stkod", "depkod", "sil" });

            migrationBuilder.CreateIndex(
                name: "stkhrk_idx5",
                table: "stkhrk",
                columns: new[] { "stktip", "stkod", "firmano", "sil" });

            migrationBuilder.CreateIndex(
                name: "stkhrk_idx6",
                table: "stkhrk",
                columns: new[] { "stktip", "stkod", "sil" });

            migrationBuilder.CreateIndex(
                name: "stkhrk_sil_index",
                table: "stkhrk",
                column: "sil");

            migrationBuilder.CreateIndex(
                name: "stkhrk_stktipdepkodsilGrupIndex1",
                table: "stkhrk",
                columns: new[] { "stktip", "depkod", "sil" });

            migrationBuilder.CreateIndex(
                name: "stkhrk_stktipsilGrupIndex1",
                table: "stkhrk",
                columns: new[] { "stktip", "sil" });

            migrationBuilder.CreateIndex(
                name: "stkhrk_stktipsilGrupIndex2",
                table: "stkhrk",
                columns: new[] { "stktip", "sil" });

            migrationBuilder.CreateIndex(
                name: "stkhrk_stktipsilGrupIndex3",
                table: "stkhrk",
                columns: new[] { "stktip", "sil" });

            migrationBuilder.CreateIndex(
                name: "stkhrk_stktipstkodsil",
                table: "stkhrk",
                columns: new[] { "stktip", "stkod", "sil" });

            migrationBuilder.CreateIndex(
                name: "stkhrk_stktipstkodsilGrupIndex1",
                table: "stkhrk",
                columns: new[] { "stktip", "stkod", "sil" });

            migrationBuilder.CreateIndex(
                name: "stkhrk_tarih_index",
                table: "stkhrk",
                columns: new[] { "tarih", "saat" });

            migrationBuilder.CreateIndex(
                name: "stkhrktip_uq",
                table: "stkhrktip",
                column: "kod",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Stok_Fiyat_idx",
                table: "Stok_Fiyat",
                columns: new[] { "Stktip_id", "Stk_id" });

            migrationBuilder.CreateIndex(
                name: "Stok_Fiyat_uq",
                table: "Stok_Fiyat",
                columns: new[] { "FirmaNo", "Stk_id", "FiyTip", "FiyNo" },
                unique: true,
                filter: "[FirmaNo] IS NOT NULL AND [Stk_id] IS NOT NULL AND [FiyTip] IS NOT NULL AND [FiyNo] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "stokkart_grup_index",
                table: "stokkart",
                columns: new[] { "grp1", "grp2", "grp3" });

            migrationBuilder.CreateIndex(
                name: "stokkart_tipkod",
                table: "stokkart",
                columns: new[] { "tip", "kod" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "stokkart_tipsil",
                table: "stokkart",
                columns: new[] { "tip", "sil" });

            migrationBuilder.CreateIndex(
                name: "tankkart_uq",
                table: "tankkart",
                column: "kod",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "userformlar_uq",
                table: "userformlar",
                column: "formkod",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "veresihrk_stktip_sil",
                table: "veresihrk",
                columns: new[] { "stktip", "sil" });

            migrationBuilder.CreateIndex(
                name: "veresihrk_stktip_sil_2",
                table: "veresihrk",
                columns: new[] { "verid", "stktip", "sil" });

            migrationBuilder.CreateIndex(
                name: "veresimas_idx",
                table: "veresimas",
                column: "yerad");

            migrationBuilder.CreateIndex(
                name: "veresimas_idx2",
                table: "veresimas",
                column: "varno");

            migrationBuilder.CreateIndex(
                name: "veresimas_idx3",
                table: "veresimas",
                column: "fistip");

            migrationBuilder.CreateIndex(
                name: "veresimas_sil_aktip",
                table: "veresimas",
                columns: new[] { "sil", "aktip" });

            migrationBuilder.CreateIndex(
                name: "veresimas_verid",
                table: "veresimas",
                column: "verid");

            migrationBuilder.CreateIndex(
                name: "UQ__yertipad__640EA3F6",
                table: "yertipad",
                column: "kod",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ana_menu_hrk");

            migrationBuilder.DropTable(
                name: "ana_menu_mas");

            migrationBuilder.DropTable(
                name: "AppIrsaliyeHrk");

            migrationBuilder.DropTable(
                name: "AppIrsaliyeMas");

            migrationBuilder.DropTable(
                name: "AppRafEitketHrk");

            migrationBuilder.DropTable(
                name: "AppRafEtiketMas");

            migrationBuilder.DropTable(
                name: "AppSayim");

            migrationBuilder.DropTable(
                name: "B2B_PaymentLogs");

            migrationBuilder.DropTable(
                name: "B2B_Payments");

            migrationBuilder.DropTable(
                name: "B2B_Users");

            migrationBuilder.DropTable(
                name: "B2BPosAccounts");

            migrationBuilder.DropTable(
                name: "B2BPosInstallmentRules");

            migrationBuilder.DropTable(
                name: "bankahrk");

            migrationBuilder.DropTable(
                name: "bankakart");

            migrationBuilder.DropTable(
                name: "Banknot_hrk");

            migrationBuilder.DropTable(
                name: "Banknot_Tip");

            migrationBuilder.DropTable(
                name: "barkod");

            migrationBuilder.DropTable(
                name: "BarkodBedelsiz");

            migrationBuilder.DropTable(
                name: "bolum");

            migrationBuilder.DropTable(
                name: "BulutTahsilat");

            migrationBuilder.DropTable(
                name: "Cari_Calisma_Sart");

            migrationBuilder.DropTable(
                name: "Cari_Calisma_Urun_Iskonto");

            migrationBuilder.DropTable(
                name: "Cari_Fat_Urun_Iskonto");

            migrationBuilder.DropTable(
                name: "Cari_Surucu");

            migrationBuilder.DropTable(
                name: "Cari_Tip");

            migrationBuilder.DropTable(
                name: "Cari_Tur");

            migrationBuilder.DropTable(
                name: "carihrk");

            migrationBuilder.DropTable(
                name: "carikart");

            migrationBuilder.DropTable(
                name: "cariteminat");

            migrationBuilder.DropTable(
                name: "cariteminattip");

            migrationBuilder.DropTable(
                name: "cekhrk");

            migrationBuilder.DropTable(
                name: "CekKarne");

            migrationBuilder.DropTable(
                name: "cekkart");

            migrationBuilder.DropTable(
                name: "cektip");

            migrationBuilder.DropTable(
                name: "dagitim_Firma");

            migrationBuilder.DropTable(
                name: "depokart");

            migrationBuilder.DropTable(
                name: "EBelge_Entegrator");

            migrationBuilder.DropTable(
                name: "EBelge_Seri");

            migrationBuilder.DropTable(
                name: "EBelge_Tip");

            migrationBuilder.DropTable(
                name: "EFatura_Brm");

            migrationBuilder.DropTable(
                name: "EFatura_Gelen");

            migrationBuilder.DropTable(
                name: "EFatura_Gelen_Hrk");

            migrationBuilder.DropTable(
                name: "EFatura_Tip");

            migrationBuilder.DropTable(
                name: "emtiasat");

            migrationBuilder.DropTable(
                name: "Entegre");

            migrationBuilder.DropTable(
                name: "entegre_muh_hes_kod");

            migrationBuilder.DropTable(
                name: "epostaayar");

            migrationBuilder.DropTable(
                name: "Evrak_Not");

            migrationBuilder.DropTable(
                name: "Fat_Dep");

            migrationBuilder.DropTable(
                name: "Fat_Grs_Alan_Tip");

            migrationBuilder.DropTable(
                name: "fattip");

            migrationBuilder.DropTable(
                name: "Fatura_Tur");

            migrationBuilder.DropTable(
                name: "faturahrk");

            migrationBuilder.DropTable(
                name: "faturahrk_temp");

            migrationBuilder.DropTable(
                name: "FaturaIadeDetay");

            migrationBuilder.DropTable(
                name: "faturamas");

            migrationBuilder.DropTable(
                name: "faturamas_temp");

            migrationBuilder.DropTable(
                name: "Filitre_Hrk");

            migrationBuilder.DropTable(
                name: "Filitre_Mas");

            migrationBuilder.DropTable(
                name: "Firma");

            migrationBuilder.DropTable(
                name: "fismas");

            migrationBuilder.DropTable(
                name: "frm");

            migrationBuilder.DropTable(
                name: "frmkont");

            migrationBuilder.DropTable(
                name: "gelgidkart");

            migrationBuilder.DropTable(
                name: "genelrap_goster");

            migrationBuilder.DropTable(
                name: "Grafik_Rap_Goster");

            migrationBuilder.DropTable(
                name: "grup");

            migrationBuilder.DropTable(
                name: "Gunlukrap_Goster");

            migrationBuilder.DropTable(
                name: "Harici_Kart");

            migrationBuilder.DropTable(
                name: "Hrk_Grup_Kriter");

            migrationBuilder.DropTable(
                name: "Hrk_Kriter");

            migrationBuilder.DropTable(
                name: "il");

            migrationBuilder.DropTable(
                name: "ilce");

            migrationBuilder.DropTable(
                name: "irsaliyehrk");

            migrationBuilder.DropTable(
                name: "irsaliyemas");

            migrationBuilder.DropTable(
                name: "islemhrktip");

            migrationBuilder.DropTable(
                name: "islemturtip");

            migrationBuilder.DropTable(
                name: "istkart");

            migrationBuilder.DropTable(
                name: "istkhrk");

            migrationBuilder.DropTable(
                name: "kartsumalan");

            migrationBuilder.DropTable(
                name: "karttip");

            migrationBuilder.DropTable(
                name: "kasa_kapa");

            migrationBuilder.DropTable(
                name: "kasa_kapat");

            migrationBuilder.DropTable(
                name: "kasahrk");

            migrationBuilder.DropTable(
                name: "kasakart");

            migrationBuilder.DropTable(
                name: "kdv_oran");

            migrationBuilder.DropTable(
                name: "KDVTevkifat_Tip");

            migrationBuilder.DropTable(
                name: "kriterkayit");

            migrationBuilder.DropTable(
                name: "kurgrs");

            migrationBuilder.DropTable(
                name: "Log_Fatura");

            migrationBuilder.DropTable(
                name: "Log_FaturaHareket");

            migrationBuilder.DropTable(
                name: "Log_MarketSatis");

            migrationBuilder.DropTable(
                name: "Log_MarketSatisHareket");

            migrationBuilder.DropTable(
                name: "Log_UrunFiyatHistory");

            migrationBuilder.DropTable(
                name: "Log_UrunHareket");

            migrationBuilder.DropTable(
                name: "LogAlan");

            migrationBuilder.DropTable(
                name: "Logo_Transfer_Log");

            migrationBuilder.DropTable(
                name: "Mail_Ack");

            migrationBuilder.DropTable(
                name: "markasahrk");

            migrationBuilder.DropTable(
                name: "marsathrk");

            migrationBuilder.DropTable(
                name: "marsatmas");

            migrationBuilder.DropTable(
                name: "MarSatRecHrk");

            migrationBuilder.DropTable(
                name: "marvardikap");

            migrationBuilder.DropTable(
                name: "marvardimas");

            migrationBuilder.DropTable(
                name: "marvardiozet");

            migrationBuilder.DropTable(
                name: "marvardirapgoster");

            migrationBuilder.DropTable(
                name: "Merkez_Kart_Log");

            migrationBuilder.DropTable(
                name: "Mesaj");

            migrationBuilder.DropTable(
                name: "Msg_Ack");

            migrationBuilder.DropTable(
                name: "numarator");

            migrationBuilder.DropTable(
                name: "oto_onl_param");

            migrationBuilder.DropTable(
                name: "Otomas_Satis");

            migrationBuilder.DropTable(
                name: "otomasdosya");

            migrationBuilder.DropTable(
                name: "otomasgenkod");

            migrationBuilder.DropTable(
                name: "otomaskart");

            migrationBuilder.DropTable(
                name: "otomaskarthrk");

            migrationBuilder.DropTable(
                name: "otomasoku");

            migrationBuilder.DropTable(
                name: "otomasonlineoku");

            migrationBuilder.DropTable(
                name: "otomaspumphrk");

            migrationBuilder.DropTable(
                name: "otomaspumptan");

            migrationBuilder.DropTable(
                name: "otomastip");

            migrationBuilder.DropTable(
                name: "OtomasWebServisHrk");

            migrationBuilder.DropTable(
                name: "Ozel_fis_tablo");

            migrationBuilder.DropTable(
                name: "Ozel_Kod");

            migrationBuilder.DropTable(
                name: "para_kur");

            migrationBuilder.DropTable(
                name: "parabrm");

            migrationBuilder.DropTable(
                name: "Parametre");

            migrationBuilder.DropTable(
                name: "Pda_FaturaSayim_Hrk");

            migrationBuilder.DropTable(
                name: "Pda_FaturaSayim_Mas");

            migrationBuilder.DropTable(
                name: "Pda_OffSayim_Hrk");

            migrationBuilder.DropTable(
                name: "Pda_OffSayim_Mas");

            migrationBuilder.DropTable(
                name: "Per_Cari");

            migrationBuilder.DropTable(
                name: "perakendekart");

            migrationBuilder.DropTable(
                name: "perkart");

            migrationBuilder.DropTable(
                name: "permaashrk");

            migrationBuilder.DropTable(
                name: "pomvardikap");

            migrationBuilder.DropTable(
                name: "pomvardimas");

            migrationBuilder.DropTable(
                name: "pomvardiozet");

            migrationBuilder.DropTable(
                name: "pomvardiper");

            migrationBuilder.DropTable(
                name: "pomvardiperada");

            migrationBuilder.DropTable(
                name: "pomvardirapgoster");

            migrationBuilder.DropTable(
                name: "pomvardisayac");

            migrationBuilder.DropTable(
                name: "pomvardistok");

            migrationBuilder.DropTable(
                name: "pomvarditank");

            migrationBuilder.DropTable(
                name: "poshrk");

            migrationBuilder.DropTable(
                name: "poskart");

            migrationBuilder.DropTable(
                name: "Prom_Limit");

            migrationBuilder.DropTable(
                name: "Prom_Puan_Hrk");

            migrationBuilder.DropTable(
                name: "Prom_Puan_Hrk_Tip");

            migrationBuilder.DropTable(
                name: "Prom_Sat_Baslik");

            migrationBuilder.DropTable(
                name: "Prom_Sat_Hrk");

            migrationBuilder.DropTable(
                name: "Prom_Urun_Puan");

            migrationBuilder.DropTable(
                name: "Prom_Urun_Puan_Tip");

            migrationBuilder.DropTable(
                name: "Prom_Urun_Sat_Tip");

            migrationBuilder.DropTable(
                name: "PromaksMarketSatisLog");

            migrationBuilder.DropTable(
                name: "Rapor_Deger");

            migrationBuilder.DropTable(
                name: "Rapor_Grup_Kriter");

            migrationBuilder.DropTable(
                name: "Rapor_Hrk_Kriter");

            migrationBuilder.DropTable(
                name: "Rapor_List");

            migrationBuilder.DropTable(
                name: "Rapor_Mas");

            migrationBuilder.DropTable(
                name: "raporlar");

            migrationBuilder.DropTable(
                name: "raptip");

            migrationBuilder.DropTable(
                name: "RehberBarkod");

            migrationBuilder.DropTable(
                name: "RehberGrup");

            migrationBuilder.DropTable(
                name: "RehberGrupDetay");

            migrationBuilder.DropTable(
                name: "RehberKart");

            migrationBuilder.DropTable(
                name: "ResSatHrk");

            migrationBuilder.DropTable(
                name: "ResSatKasaHrk");

            migrationBuilder.DropTable(
                name: "ResSatMas");

            migrationBuilder.DropTable(
                name: "ResSatRecHrk");

            migrationBuilder.DropTable(
                name: "ResVardiKap");

            migrationBuilder.DropTable(
                name: "ResVardiMas");

            migrationBuilder.DropTable(
                name: "ResVardiOzet");

            migrationBuilder.DropTable(
                name: "ResVardiRapGoster");

            migrationBuilder.DropTable(
                name: "RezSatHrk");

            migrationBuilder.DropTable(
                name: "sayachrk");

            migrationBuilder.DropTable(
                name: "sayackart");

            migrationBuilder.DropTable(
                name: "sayimhrk");

            migrationBuilder.DropTable(
                name: "sayimkap");

            migrationBuilder.DropTable(
                name: "sayimmas");

            migrationBuilder.DropTable(
                name: "sayimstkgrp");

            migrationBuilder.DropTable(
                name: "siparishrk");

            migrationBuilder.DropTable(
                name: "siparismas");

            migrationBuilder.DropTable(
                name: "sistemtanim");

            migrationBuilder.DropTable(
                name: "SmsGonderimLog");

            migrationBuilder.DropTable(
                name: "SmsSablon");

            migrationBuilder.DropTable(
                name: "SoforKart");

            migrationBuilder.DropTable(
                name: "Stk_Tip");

            migrationBuilder.DropTable(
                name: "stkbrm");

            migrationBuilder.DropTable(
                name: "stkdeptrs");

            migrationBuilder.DropTable(
                name: "Stkdeptrsmas");

            migrationBuilder.DropTable(
                name: "stkdrm");

            migrationBuilder.DropTable(
                name: "stkhrk");

            migrationBuilder.DropTable(
                name: "stkhrktip");

            migrationBuilder.DropTable(
                name: "Stok_Fiyat");

            migrationBuilder.DropTable(
                name: "Stok_Recete");

            migrationBuilder.DropTable(
                name: "stokfiyathistory");

            migrationBuilder.DropTable(
                name: "StokFiyatLog");

            migrationBuilder.DropTable(
                name: "stokkart");

            migrationBuilder.DropTable(
                name: "StokMuhTanim");

            migrationBuilder.DropTable(
                name: "StokSonKullanim");

            migrationBuilder.DropTable(
                name: "tablelog");

            migrationBuilder.DropTable(
                name: "tablo");

            migrationBuilder.DropTable(
                name: "tablo_alan");

            migrationBuilder.DropTable(
                name: "TahsilatOdeme");

            migrationBuilder.DropTable(
                name: "Taksit_hrk");

            migrationBuilder.DropTable(
                name: "tankkart");

            migrationBuilder.DropTable(
                name: "Tarih_Kapat");

            migrationBuilder.DropTable(
                name: "TasiyiciFirmaKart");

            migrationBuilder.DropTable(
                name: "tatiller");

            migrationBuilder.DropTable(
                name: "Tesis");

            migrationBuilder.DropTable(
                name: "TeslimYerKart");

            migrationBuilder.DropTable(
                name: "TopluKayit");

            migrationBuilder.DropTable(
                name: "TopluKayitHrk");

            migrationBuilder.DropTable(
                name: "TopluVirmanKayit");

            migrationBuilder.DropTable(
                name: "TopluVirmanKayitHrk");

            migrationBuilder.DropTable(
                name: "TTS_BankaTahsilat");

            migrationBuilder.DropTable(
                name: "TTS_OdeTip");

            migrationBuilder.DropTable(
                name: "UlkeList");

            migrationBuilder.DropTable(
                name: "userformgrup");

            migrationBuilder.DropTable(
                name: "userformhak");

            migrationBuilder.DropTable(
                name: "userformhrk");

            migrationBuilder.DropTable(
                name: "userformlar");

            migrationBuilder.DropTable(
                name: "userlog");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "usrgrid");

            migrationBuilder.DropTable(
                name: "usrsplit");

            migrationBuilder.DropTable(
                name: "vardikasa");

            migrationBuilder.DropTable(
                name: "veresifarkhrk");

            migrationBuilder.DropTable(
                name: "veresihrk");

            migrationBuilder.DropTable(
                name: "veresimas");

            migrationBuilder.DropTable(
                name: "VeresiVadeFarkHrk");

            migrationBuilder.DropTable(
                name: "veresiyenfiyhrk");

            migrationBuilder.DropTable(
                name: "yazarkasa");

            migrationBuilder.DropTable(
                name: "YazarKasa_Satis");

            migrationBuilder.DropTable(
                name: "yazarkasakart");

            migrationBuilder.DropTable(
                name: "yazkasagrpkart");

            migrationBuilder.DropTable(
                name: "yedek");

            migrationBuilder.DropTable(
                name: "yertipad");

            migrationBuilder.DropTable(
                name: "yetki");

            migrationBuilder.DropTable(
                name: "yetkibolum");

            migrationBuilder.DropTable(
                name: "yetkifrm");

            migrationBuilder.DropTable(
                name: "yetkikont");

            migrationBuilder.DropTable(
                name: "zraporhrk");

            migrationBuilder.DropTable(
                name: "zrapormas");

            migrationBuilder.DropTable(
                name: "ZraporVardiya");
        }
    }
}
