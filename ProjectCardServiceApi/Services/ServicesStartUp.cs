using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using ProfileConnectionLib.ConnectionServices;
using ProfileConnectionLib.ConnectionServices.Interfaces;
using Services.Interfaces;
using Services.Services;

public static class ServiceStartUp
{
    public static IServiceCollection TryAddServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.TryAddScoped<IProjectCardService, ProjectCardService>();
        serviceCollection.TryAddScoped<IProfileConnectionService, ProfileConnectionService>();
        return serviceCollection;
    }

}