using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Dal;

namespace Dal.Users.Models
{
    public record UserDal : BaseEntityDal<Guid>
    {
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string PasswordHash { get; set; }
        public virtual required List<UserRole> UserRoles { get; set; }
    }
}
