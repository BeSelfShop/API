using PrisonBack.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrisonBack.Auth;
using PrisonBack.Domain.Models;
using PrisonBack.Domain.Repositories;

namespace PrisonBack.Persistence.Repositories
{
    public class UserPermissionRepository : BaseRepository, IUserPermissionsRepository
    {
        public UserPermissionRepository(AppDbContext context) : base(context)
        {

        }


        public void AddUserPermissions(string username, string prisonName)
        {
            if (prisonName != null)
            {
               var prison = _context.Prisons.FirstOrDefault(p => p.PrisonName == prisonName);
                UserPermission userPermission = new UserPermission();
                userPermission.IdPrison = prison.Id;
                userPermission.UserName = username;
                _context.Add(userPermission);
                _context.SaveChanges();
            }
           
        }
    }
}
