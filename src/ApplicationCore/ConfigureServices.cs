using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApplicationCore;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationCoreServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        return services;
    }
}