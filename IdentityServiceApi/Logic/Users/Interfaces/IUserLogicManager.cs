using Dal.Users.Models;
using Logic.Users.Models;

namespace Logic.Users.Interfaces
{
    public interface IUserLogicManager
    {
        Task<UserDal> GetUserByIdAsync(Guid id);
        Task<bool> CreateUserAsync(UserLogic user);
    }
}
