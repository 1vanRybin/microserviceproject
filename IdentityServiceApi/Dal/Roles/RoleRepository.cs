using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Roles.Interfaces;
using Dal.Roles.Models;
using Dal.Users;
using Dal.Users.Models;
using Microsoft.EntityFrameworkCore;

namespace Dal.Roles
{
    internal class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _context;

        public RoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<RoleDal> GetRoleByNameAsync(string roleName)
        {
            var role = await _context.Roles.SingleOrDefaultAsync(r => r.Name == roleName);
            if(role is not null)
            {
                return role;
            }

            throw new Exception("Такой роли не существует.");
        }

        public async Task<bool> CreateRoleAsync(string roleName)
        {
            var role = new RoleDal {
                Id = new Guid(),
                Name = roleName,
                UserRoles = new()
            };

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var dbSet = _context.Roles;
                    await dbSet.AddAsync(role);
                    await _context.SaveChangesAsync();

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }
        public async Task<bool> RoleExistsAsync(string roleName)
        {
            return await _context.Roles.SingleOrDefaultAsync(r => r.Name == roleName) is not null;
        }
    }
}
