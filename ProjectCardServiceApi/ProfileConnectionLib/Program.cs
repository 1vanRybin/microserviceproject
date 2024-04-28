using Core.HttpLogic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using ProfileConnectionLib.ConnectionServices;
using ProfileConnectionLib.ConnectionServices.Interfaces;

namespace ProfileConnectionLib;

public static class ProfileLibStartUp
{
    public static IServiceCollection TryAddProfileLib(this IServiceCollection serviceCollection)
    {
        serviceCollection.TryAddScoped<IProfileConnectionService, ProfileConnectionService>();
        serviceCollection.AddHttpRequestService();
        return serviceCollection;
    }
}
