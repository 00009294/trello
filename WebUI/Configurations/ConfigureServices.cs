using Infrastructure.Configurations;

namespace WebUI.Configurations
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddAllServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddInfrastructureServices(configuration);

            return services;
        }
    }
}
