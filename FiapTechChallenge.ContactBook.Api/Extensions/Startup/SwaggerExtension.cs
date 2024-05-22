namespace FiapTechChallenge.ContactBook.Presentation.Api.Extensions.Startup
{
    public static class SwaggerExtension
    {
        public static void AddSwaggerSetup(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public static void UseSwaggerSetup(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
    }
}
