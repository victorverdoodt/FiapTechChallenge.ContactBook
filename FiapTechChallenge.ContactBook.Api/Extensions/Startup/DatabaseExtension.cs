using FiapTechChallenge.ContactBook.Domain.Core.Interfaces.Default;
using FiapTechChallenge.ContactBook.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace FiapTechChallenge.ContactBook.Presentation.Api.Extensions.Startup
{
    public static class DatabaseExtension
    {
        public static void AddDatabaseSetup(this WebApplicationBuilder builder)
        {

            builder.AddNpgsqlDbContext<AppDbContext>("database");

            builder.Services.AddScoped<IAppDbContext>(provider => provider.GetService<AppDbContext>());

            builder.Services.AddSingleton<DataBaseInitializer>();
            builder.Services.AddHostedService(sp => sp.GetRequiredService<DataBaseInitializer>());
        }
    }
}
