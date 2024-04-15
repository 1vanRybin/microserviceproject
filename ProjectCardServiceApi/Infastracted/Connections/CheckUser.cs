using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;
using ProfileConnectionLib.ConnectionServices.DtoModels.CheckUserExists;
using ProfileConnectionLib.ConnectionServices;
using ProfileConnectionLib.ConnectionServices.Interfaces;

namespace Infastracted.Connections
{
    public class CheckUser : ICheckUser
    {
        private readonly IProfileConnectionService _profileConnectionService;
        public CheckUser(IProfileConnectionService profileConnectionService)
        {
            _profileConnectionService = profileConnectionService;
        }
      
        public async Task CheckUserExistAsync(Guid userId)
        {
            await _profileConnectionService.CheckUserExistAsync(new CheckUserExistProfileApiRequest
            {
                UserId = userId
            });
        }
    }
}
