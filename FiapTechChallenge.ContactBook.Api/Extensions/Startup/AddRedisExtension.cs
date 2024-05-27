namespace FiapTechChallenge.ContactBook.Presentation.Api.Extensions.Startup
{
    public static class AddRedisExtension
    {
        public static void AddRedisSetup(this WebApplicationBuilder builder)
        {
            builder.AddRedisDistributedCache("cache");
        }
    }
}
