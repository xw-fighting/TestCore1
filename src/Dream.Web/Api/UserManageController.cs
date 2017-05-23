using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dream.Model.Models;
using Dream.IRepository.IReposotories;

namespace Dream.Web.Api
{
    [Produces("application/json")]
    [Route("api/UserManage/[action]")]
    public class UserManageController : Controller
    {
        public UserManageController(IUserManageInfoRepository userManageInfoRepository)
        {
            UserManageInfoRepository = userManageInfoRepository;
        }
        public IUserManageInfoRepository UserManageInfoRepository { get; set; }

        public List<UserManageInfo> GetAll()
        {
            return UserManageInfoRepository.QueryWhere(c => true);
        }

        public bool Add(UserManageInfo model)
        {
            UserManageInfoRepository.Add(model);
            return true;
        }
    }
}