using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Configurations;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>( options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            options.LogTo(Console.WriteLine, LogLevel.Warning);
        });

        return services;
    }
}