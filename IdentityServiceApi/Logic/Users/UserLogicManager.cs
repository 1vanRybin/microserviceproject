using System;
using System.Collections.Generic;
using Dal.Roles;
using Dal.Users.Interfaces;
using Dal.Users.Models;
using Logic.Users.Interfaces;
using Logic.Users.Models;


namespace Logic.Users
{
    internal class UserLogicManager : IUserLogicManager
    {
        private readonly IUserRepository _userRepository;
        private readonly IRoleManager _roleManager;

        public UserLogicManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> CreateUserAsync(UserLogic user)
        {
            var roles = new List<string> { "Investor", "Startup" };
            foreach (var role in roles)
            {
                var roleExists = await _roleManager.ExistsRoleAsync(role);
                if (!roleExists)
                {
                    await _roleManager.CreateRoleAsync(role);
                }
            }

            return await _userRepository.CreateUserAsync(new UserDal
            {
                Email = user.Email,
                Username = user.Username,
                PasswordHash = user.PasswordHash,
                UserRoles = user.UserRoles
            });
        }

        public async Task<UserDal> GetUserByIdAsync(Guid id)
        {
            return await _userRepository.GetUserByIdAsync(id);
        }
    }
}
