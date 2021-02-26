using PrisonBack.Domain.Models;
using PrisonBack.Resources.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisonBack.Domain.Repositories
{
    public interface IUserInfoRepository
    {
        UserInfoVM UserInfo(string userName);
    }
}
