using Dal.Users.Interfaces;
using Dal.Roles.Interfaces;
using Dal.Roles.Models;

namespace Dal.Roles
{
    internal class RoleManager : IRoleManager
    {
        private readonly IRoleRepository _roleRepository;

        public RoleManager(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<bool> CreateRoleAsync(string roleName)
        {
           return await _roleRepository.CreateRoleAsync(roleName);
        }

        public async Task<RoleDal> GetRoleByNameAsync(string roleName)
        {
            return await _roleRepository.GetRoleByNameAsync(roleName);
        }
        public async Task<bool> ExistsRoleAsync(string roleName)
        {
            return await _roleRepository.ExistsRoleAsync(roleName);
        }
    }
}
