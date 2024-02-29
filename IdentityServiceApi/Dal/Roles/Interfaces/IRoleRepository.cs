using Dal.Roles.Models;

namespace Dal.Roles.Interfaces
{
    public interface IRoleRepository
    {
        Task<RoleDal> GetRoleByNameAsync(string roleName);
        Task<bool> CreateRoleAsync(string roleName);
        Task<bool> ExistsRoleAsync(string roleName);

    }
}
