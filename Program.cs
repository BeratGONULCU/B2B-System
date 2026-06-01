using System.Text;
using AvmB2B.Api.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using AvmB2B.Api.Services;
using AvmB2B.Api.Services.Payments;

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

var builder = WebApplication.CreateBuilder(args);

/* ---------------------------------------------------------- */
/* CONTROLLERS */
/* ---------------------------------------------------------- */

builder.Services.AddControllers();

/* ---------------------------------------------------------- */
/* SERVICES */
/* ---------------------------------------------------------- */

builder.Services.AddScoped<IEncryptionService, AesEncryptionService>();

builder.Services.AddHttpClient<IKuveytTurkPaymentService, KuveytTurkPaymentService>();

builder.Services.AddScoped<AdminDatabaseService>();

builder.Services.AddHostedService<DatabaseScanHostedService>();


Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

/* ---------------------------------------------------------- */
/* DATABASE */
/* ---------------------------------------------------------- */

builder.Services.AddDbContext<PetrolDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("PetrolDb"));
});

/* ---------------------------------------------------------- */
/* CORS */
/* ---------------------------------------------------------- */

var allowedOrigins = builder.Configuration
    .GetSection("AllowedOrigins")
    .Get<string[]>() ?? [];

builder.Services.AddCors(options =>
{
    options.AddPolicy("B2BCors", policy =>
    {
        policy.WithOrigins(allowedOrigins)
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

/* ---------------------------------------------------------- */
/* JWT AUTHENTICATION */
/* ---------------------------------------------------------- */

var jwtKey = builder.Configuration["Jwt:Key"];
var jwtIssuer = builder.Configuration["Jwt:Issuer"];
var jwtAudience = builder.Configuration["Jwt:Audience"];

if (string.IsNullOrWhiteSpace(jwtKey))
{
    throw new Exception("Jwt:Key appsettings içinde bulunamadı.");
}

if (string.IsNullOrWhiteSpace(jwtIssuer))
{
    throw new Exception("Jwt:Issuer appsettings içinde bulunamadı.");
}

if (string.IsNullOrWhiteSpace(jwtAudience))
{
    throw new Exception("Jwt:Audience appsettings içinde bulunamadı.");
}

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = false;

    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,

        ValidIssuer = jwtIssuer,
        ValidAudience = jwtAudience,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey)),

        ClockSkew = TimeSpan.Zero
    };
});

/* ---------------------------------------------------------- */
/* AUTHORIZATION */
/* ---------------------------------------------------------- */

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminOnly", policy =>
        policy.RequireClaim("userType", "Admin"));
});

/* ---------------------------------------------------------- */
/* SWAGGER */
/* ---------------------------------------------------------- */

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "AvmB2B.Api",
        Version = "v1"
    });

    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT token gir. Örnek: Bearer eyJhbGciOi..."
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});

/* ---------------------------------------------------------- */
/* APP BUILD */
/* ---------------------------------------------------------- */

var app = builder.Build();

/* ---------------------------------------------------------- */
/* DATABASE INITIALIZER */
/* ---------------------------------------------------------- */

try
{
    DatabaseInitializer.Initialize(app.Configuration);
}
catch (Exception ex)
{
    app.Logger.LogError(ex, "Database initialization failed.");
    throw;
}

/* ---------------------------------------------------------- */
/* SWAGGER ALWAYS ENABLED */
/* ---------------------------------------------------------- */

app.UseSwagger();

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "AvmB2B.Api v1");
    options.RoutePrefix = "swagger";
});

/* ---------------------------------------------------------- */
/* ROOT REDIRECT */
/* ---------------------------------------------------------- */

app.MapGet("/", () => Results.Redirect("/swagger"));

/* ---------------------------------------------------------- */
/* MIDDLEWARE */
/* ---------------------------------------------------------- */

/*
 NSSM ile exe servis olarak çalışacağı için burada HTTPS redirect kullanmıyoruz.

 Eğer app.UseHttpsRedirection() açık kalırsa:
 - http://localhost:5276/swagger adresi bazen HTTPS'e yönlenir
 - Sertifika yoksa Swagger açılmayabilir
 - Servis ortamında gereksiz hata çıkarabilir

 HTTPS işi domain / reverse proxy / Plesk / IIS tarafında çözülecekse
 burada kapalı kalması daha sağlıklı.
*/

// app.UseHttpsRedirection();

app.UseCors("B2BCors");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();