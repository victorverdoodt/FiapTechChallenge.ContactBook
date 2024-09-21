using OpenTelemetry.Logs;
using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;
using Serilog;
using System.Reflection;

namespace FiapTechChallenge.ContactBook.Presentation.Api.Extensions.Startup
{
    public static class OpenTelemetryExtension
    {
        public static void AddTelemetry(this IServiceCollection services)
        {
            services.AddOpenTelemetry()
                .ConfigureResource(b =>
                {
                    b.AddService(Assembly.GetEntryAssembly().GetName().Name);
                })
                //.WithLogging(b =>
                   // b.AddOtlpExporter())
                .WithTracing(b => b
                    .AddAspNetCoreInstrumentation()
                    .AddHttpClientInstrumentation()
                    .AddEntityFrameworkCoreInstrumentation()
                    //.AddOtlpExporter()
                    )
                .WithMetrics(b => b
                    .AddAspNetCoreInstrumentation()
                    .AddHttpClientInstrumentation()
                    .AddRuntimeInstrumentation()
                    .AddPrometheusExporter());

            services.AddSerilog();
        }

        public static void UseTelemetrySetup(this IApplicationBuilder app)
        {
            app.UseSerilogRequestLogging();
            app.UseOpenTelemetryPrometheusScrapingEndpoint();
        }

        public static void AddTelemetryLog(this ILoggingBuilder builder)
        {

            builder.AddOpenTelemetry(options =>
            {
                options.IncludeFormattedMessage = true;
                options.IncludeScopes = true;

                var resBuilder = ResourceBuilder.CreateDefault();
                var serviceName = Assembly.GetEntryAssembly().GetName().Name;
                resBuilder.AddService(serviceName);
                options.SetResourceBuilder(resBuilder);

                //options.AddOtlpExporter();
            });
        }
    }
}
