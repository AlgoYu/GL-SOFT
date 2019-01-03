using System.Diagnostics;
using System.Linq;
using CompanyWebSite.Areas.ManagementSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.Areas.ManagementSystem.Controllers
{
    [AllowAnonymous]
    public class LoginController : ManagementSystemControllerBase
    {
        private readonly EFContext _db;
        public LoginController(EFContext db)
        {
            this._db = db;
        }

        //登录界面主页
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //验证登录信息
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Check(LoginInfo loginInfo)
        {

            if (loginInfo==null)
            {
                return Json(null);
            }

            LoginResponse loginResponse = new LoginResponse();
            Manager manager = null;
            Debug.WriteLine("登录时ID："+HttpContext.Session.Id);
            if (loginInfo.ValidateCode!=null && HttpContext.Session.GetString("ValidateCode") == loginInfo.ValidateCode)
            {
                manager = _db.Managers.FirstOrDefault(m =>
                    m.ManagerName == loginInfo.LoginName && m.PassWord == loginInfo.Password);
                if (manager!=null)
                {
                    HttpContext.Session.SetString("Token",loginInfo.LoginName);
                    loginResponse.Data = manager;
                    loginResponse.Status = 1;
                }
            }
            return Json(loginResponse);
        }
    }
}