using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Dream.Web.Areas.System.Controllers
{
    public class MenuController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}