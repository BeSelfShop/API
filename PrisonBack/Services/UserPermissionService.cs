using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrisonBack.Domain.Models;
using PrisonBack.Domain.Services;
using PrisonBack.Domain.Repositories;

namespace PrisonBack.Services
{
    public class UserPermissionService : IUserPermissionsService
    {
        private readonly IUserPermissionsRepository _userPermissionsRepository;

        public UserPermissionService(IUserPermissionsRepository userPermissionsRepository)
        {
            _userPermissionsRepository = userPermissionsRepository;
        }
        public void AddUserPermissions(string username, string prisonName)
        {
            _userPermissionsRepository.AddUserPermissions(username, prisonName);
        }
    }
}
