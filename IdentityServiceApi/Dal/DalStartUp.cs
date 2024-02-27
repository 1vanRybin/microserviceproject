using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Dal.Users;
using Dal.Users.Interfaces;

namespace Dal;

public static class DalStartUp
{
    public static IServiceCollection AddDal(this IServiceCollection serviceCollection)
    {
        serviceCollection.TryAddScoped<IUserRepository, UserRepository>();
        return serviceCollection;
    }
}