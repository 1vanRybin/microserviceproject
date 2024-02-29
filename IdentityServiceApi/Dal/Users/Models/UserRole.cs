using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Roles.Models;

namespace Dal.Users.Models
{
    public record UserRole
    {
        public required Guid UserId { get; init; }
        public required UserDal User { get; init; }
        public required Guid RoleId { get; init; }
        public required RoleDal Role { get; init; }
    }
}
