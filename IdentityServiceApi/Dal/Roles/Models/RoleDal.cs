using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Dal;
using Dal.Users.Models;

namespace Dal.Roles.Models
{
    public record RoleDal : BaseEntityDal<Guid>
    {
        public required string Name { get; init; }
        public virtual required List<UserRole> UserRoles { get; init; }
    }
}
