using Domain.Interfaces;
using Infastracted.Connections;
using Infastracted.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using ProfileConnectionLib;

namespace Infastracted;

public static class InfrastuctureStartUp
{
    public static IServiceCollection TryAddInfrastucture(this IServiceCollection serviceCollection, IConfigurationManager configurationManager)
    {
        serviceCollection.TryAddScoped<IStoreProjectCard, ProjectCardRepository>();
        serviceCollection.TryAddScoped<ICheckUser, CheckUser>();
        serviceCollection.TryAddProfileLib();

        var connectionString = configurationManager.GetConnectionString("DefaultConnection");
        serviceCollection.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(connectionString));
        return serviceCollection;
    }

    public static IServiceCollection TryAddApplicationContext(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddDbContext<ApplicationDbContext>();
        return serviceCollection;
    }
}