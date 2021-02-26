using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PrisonBack.Domain.Services;
using PrisonBack.Resources.ViewModels;

namespace PrisonBack.Controllers
{
    [Route("/api/[controller]")]
    [Authorize]

    public class UserInfoController : Controller
    {
        private readonly IUserInfoService _userInfoService;
        public UserInfoController(IUserInfoService userInfoService)
        {
            _userInfoService = userInfoService;
        }
        [DisableCors]
        [HttpGet]
        public ActionResult<UserInfoVM> UserInfo()
        {
            string userName =  User.Identity.Name;
            return _userInfoService.UserInfo(userName);
        }
    }
}
