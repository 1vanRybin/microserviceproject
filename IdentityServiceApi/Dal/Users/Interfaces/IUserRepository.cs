using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Users.Models;

namespace Dal.Users.Interfaces
{
    public interface IUserRepository
    {
        Task<UserDal> GetUserByIdAsync(Guid id);
        Task<bool> CreateUserAsync(UserDal user);
    }
}
