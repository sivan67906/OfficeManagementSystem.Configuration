using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Configuration.Application.DependencyInjection;

public static class ServiceContainer
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });
        return services;
    }
}