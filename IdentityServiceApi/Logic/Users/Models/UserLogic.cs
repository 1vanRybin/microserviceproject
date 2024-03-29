﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Users.Models;

namespace Logic.Users.Models
{
    public class UserLogic
    {
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string PasswordHash { get; set; }
        public virtual required List<UserRole> UserRoles { get; set; }
    }
}
