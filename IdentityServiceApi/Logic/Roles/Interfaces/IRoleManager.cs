using Dal.Roles.Models;

namespace Dal.Users.Interfaces
{
    public interface IRoleManager
    {
        Task<RoleDal> GetRoleByNameAsync(string roleName);
        Task<bool> CreateRoleAsync(string roleName);
        Task<bool> ExistsRoleAsync(string roleName);
    }
}
