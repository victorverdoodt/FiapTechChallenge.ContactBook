using FiapTechChallenge.ContactBook.Application.Mappers;

namespace FiapTechChallenge.ContactBook.Presentation.Api.Extensions.Startup
{
    public static class AutoMapperExtension
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DefaultProjectionProfile));
        }
    }
}
