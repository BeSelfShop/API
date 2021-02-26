using PrisonBack.Domain.Repositories;
using PrisonBack.Domain.Services;
using PrisonBack.Resources.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrisonBack.Services
{
    public class UserInfoService : IUserInfoService
    {
        private readonly IUserInfoRepository _userInfoRepository;
        public UserInfoService(IUserInfoRepository userInfoRepository)
        {
            _userInfoRepository = userInfoRepository;
        }
        public UserInfoVM UserInfo(string userName)
        {
            return _userInfoRepository.UserInfo(userName);
        }
    }
}
