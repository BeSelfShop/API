using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrisonBack.Domain.Models;

namespace PrisonBack.Domain.Services
{
    public interface IUserPermissionsService
    {
        void AddUserPermissions(string username, string prisonName);
    }
}
