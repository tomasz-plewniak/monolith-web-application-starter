using ApplicationCore.TodoItems;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApplicationCore;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationCoreServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddScoped<ITodoItemsService, TodoItemsService>();
        
        return services;
    }
}