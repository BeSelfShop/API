using AutoMapper;
using PrisonBack.Domain.Repositories;
using PrisonBack.Persistence.Context;
using PrisonBack.Resources.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisonBack.Persistence.Repositories
{
    public class UserInfoRepository : BaseRepository, IUserInfoRepository
    {

        public UserInfoRepository(AppDbContext context) : base(context)
        {

        }

        public UserInfoVM UserInfo(string userName)
        {
            var user = _context.Users.FirstOrDefault(x => x.UserName == userName);
            UserInfoVM userInfoVM = new UserInfoVM();
            userInfoVM.Name = user.Name;
            userInfoVM.Forname = user.Forname;
            return userInfoVM;
        }
    }
}
