using FiapTechChallenge.ContactBook.Infrastructure.IOC;
using FiapTechChallenge.ContactBook.Presentation.Api.Extensions.Startup;
using Serilog;
using Serilog.Sinks.Grafana.Loki;
using System.Reflection;

namespace FiapTechChallenge.ContactBook.Presentation.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Log.Logger = new LoggerConfiguration()
#if DEBUG
                .MinimumLevel.Information()
#else
                .MinimumLevel.Error()
#endif
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .WriteTo.GrafanaLoki("[https://loki.url.com]",
                        [new LokiLabel { Key = "service_name", Value = Assembly.GetEntryAssembly().GetName().Name }])
                .CreateLogger();

            Log.Information("Starting up");

            try
            {
                var builder = WebApplication.CreateBuilder(args);

                IConfiguration configuration = builder.Configuration;
            
                builder.AddServiceDefaults();
                builder.AddRabbitMQClient("RabbitMQConnection");
                builder.AddDatabaseSetup();
                builder.AddRedisSetup();
                builder.Services.AddTelemetry();
                builder.Services.AddAutoMapperSetup();
                builder.Services.AddSwaggerSetup();
                builder.Services.AddDefaultSetup();
                builder.Services.AddHealthSetup(configuration);
                builder.Services.AddMassTransitSetup();
                RegisterServices(builder.Services, configuration);

                var app = builder.Build();

                app.UseTelemetrySetup();
                app.UseSwaggerSetup();
                app.UseDefaultSetup();

                app.Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Unhandled exception");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        private static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            NativeInjectorBootStrapper.RegisterServices(services, configuration);
        }
    }
}
