namespace FiapTechChallenge.ContactBook.Presentation.Api.Extensions.Startup
{
    public static class DefaultExtension
    {
        public static void AddDefaultSetup(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddExceptionHandler<GlobalExceptionHandler>();
            services.AddProblemDetails();
            services.AddHttpClient();
            services.AddControllers();
        }

        public static void UseDefaultSetup(this IApplicationBuilder app)
        {
            app.UseExceptionHandler();

            app.UseRouting();

            app.UseCors();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
