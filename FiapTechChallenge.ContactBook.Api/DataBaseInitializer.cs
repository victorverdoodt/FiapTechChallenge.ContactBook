using FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Default;
using System.Diagnostics;

namespace FiapTechChallenge.ContactBook.Presentation.Api
{
    public class DataBaseInitializer(IServiceProvider serviceProvider, ILogger<DataBaseInitializer> logger) : BackgroundService
    {

        public const string ActivitySourceName = "Migrations";

        private readonly ActivitySource _activitySource = new(ActivitySourceName);

        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            using var scope = serviceProvider.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<IAppDbContext>();

            await InitializeDatabaseAsync(dbContext, cancellationToken);
        }

        private async Task InitializeDatabaseAsync(IAppDbContext dbContext, CancellationToken cancellationToken)
        {

            await Task.Delay(5000);
            using var activity = _activitySource.StartActivity("Migrating database", ActivityKind.Client);

            var sw = Stopwatch.StartNew();

            await dbContext.Initialize(cancellationToken);

            await SeedAsync(dbContext, cancellationToken);

            logger.LogInformation("Database initialization completed after {ElapsedMilliseconds}ms", sw.ElapsedMilliseconds);
        }

        private async Task SeedAsync(IAppDbContext dbContext, CancellationToken cancellationToken)
        {
            logger.LogInformation("Seeding database");
        }

    }
}
