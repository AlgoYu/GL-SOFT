using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using CompanyWebSite.Areas.ManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace CompanyWebSite.Areas.ManagementSystem.Controllers
{
    public class SystemInfoController : ManagementSystemControllerBase
    {
        private readonly EFContext _db;

        public SystemInfoController(EFContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 修改系统信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public JsonResult SaveSystemInfo(SystemInfo info)
        {
            if (info.ID == 0)
            {
                _db.SystemInfo.Add(info);
            }
            else
            {
                _db.SystemInfo.Update(info);
            }

            var row = _db.SaveChanges();
            return Json(new ResponseTemplate() {
                Data = row
            });
        }

        [HttpGet]
        public JsonResult GetSystemInfo()
        {
            var data = _db.SystemInfo.SingleOrDefault();
            return Json(new ResponseTemplate() {
                Data = data
            });
        }
    }
}