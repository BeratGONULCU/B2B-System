namespace AvmB2B.Api.Services;

public class DatabaseScanHostedService : BackgroundService
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<DatabaseScanHostedService> _logger;

    public DatabaseScanHostedService(
        IServiceProvider serviceProvider,
        ILogger<DatabaseScanHostedService> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);

        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                using var scope = _serviceProvider.CreateScope();
                var service = scope.ServiceProvider.GetRequiredService<AdminDatabaseService>();

                await service.RunScanAsync();

                _logger.LogInformation("Database scan completed.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Database scan failed.");
            }

            await Task.Delay(TimeSpan.FromHours(6), stoppingToken);
        }
    }
}