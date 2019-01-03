using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyWebSite.Areas.ManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.Areas.ManagementSystem.Controllers
{
    public class ManagerController : ManagementSystemControllerBase
    {
        public IActionResult Index()
        {
            var name = HttpContext.Session.GetString("Token");
            ViewData["name"] = name;
            return View();
        }

        [HttpPost]
        public ResponseTemplate Logout()
        {
            HttpContext.Session.Remove("Token");
            return new ResponseTemplate()
            {
                Message = "您已安全退出"
            };
        }
    }
}