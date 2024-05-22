using FiapTechChallenge.ContactBook.Infrastructure.IOC;
using FiapTechChallenge.ContactBook.Presentation.Api.Extensions.Startup;

namespace FiapTechChallenge.ContactBook.Presentation.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            IConfiguration configuration = builder.Configuration;

            builder.AddServiceDefaults();
            builder.AddDatabaseSetup();
            builder.Services.AddAutoMapperSetup();
            builder.Services.AddSwaggerSetup();
            builder.Services.AddDefaultSetup();
            builder.Services.AddHealthSetup(configuration);
            RegisterServices(builder.Services, configuration);
            var app = builder.Build();

            app.UseSwaggerSetup();
            app.UseDefaultSetup();

            app.Run();
        }

        private static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            NativeInjectorBootStrapper.RegisterServices(services, configuration);
        }
    }
}
