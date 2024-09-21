using MassTransit;

namespace FiapTechChallenge.ContactBook.Presentation.Api.Extensions.Startup
{
    public static class AddMassTransitExtension
    {
        public static void AddMassTransitSetup(this IServiceCollection services)
        {
            services.AddMassTransit(x =>
            {
                x.SetKebabCaseEndpointNameFormatter();

                x.UsingRabbitMq((context, cfg) =>
                {
                    var configuration = context.GetRequiredService<IConfiguration>();
                    var host = configuration.GetConnectionString("RabbitMQConnection");
                    cfg.Host(host);
                    cfg.ConfigureEndpoints(context);
                });
            });
        }
    }
}
