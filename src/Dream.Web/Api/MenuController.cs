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
    [Route("api/Menu/[action]")]
    public class MenuController : Controller
    {
        public MenuController(IMenuRepository menuRepository)
        {
            MenuRepository = menuRepository;
        }
        private IMenuRepository MenuRepository { get; set; }

        public List<Menu> GetList()
        {
            return MenuRepository.QueryWhere(c => true);
        }
    }
}