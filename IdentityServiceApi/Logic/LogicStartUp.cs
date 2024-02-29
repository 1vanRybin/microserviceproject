using Logic.Users.Interfaces;
using Logic.Users;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Dal.Users.Interfaces;
using Dal.Roles;

namespace Logic;

public static class LogicStartUp
{
    public static IServiceCollection AddLogic(this IServiceCollection serviceCollection)
    {
        serviceCollection.TryAddScoped<IUserLogicManager, UserLogicManager>();
        serviceCollection.TryAddScoped<IRoleManager, RoleManager>();
        return serviceCollection;
    }
}