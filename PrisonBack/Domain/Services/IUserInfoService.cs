using PrisonBack.Resources.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisonBack.Domain.Services
{
    public interface IUserInfoService
    {
       UserInfoVM UserInfo(string userName);
    }
}
