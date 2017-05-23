using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Dream.Web.Areas.System.Controllers
{
    public class UserManageController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}