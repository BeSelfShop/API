using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrisonBack.Domain.Models;


namespace PrisonBack.Domain.Repositories
{
    public interface IUserPermissionsRepository
    {
        void AddUserPermissions(string username, string prisonName);
    }
}
