using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Dream.Web.Areas.System
{
    public class UserManageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}