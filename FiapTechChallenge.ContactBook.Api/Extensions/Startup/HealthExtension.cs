using FiapTechChallenge.ContactBook.Infrastructure.Data.Contexts;

namespace FiapTechChallenge.ContactBook.Presentation.Api.Extensions.Startup
{
    public static class HealthExtension
    {
        public static void AddHealthSetup(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHealthChecks()
                .AddDbContextCheck<AppDbContext>(name: "DbContext")
                .AddRedis("connection", name: "Redis");
        }
    }
}
