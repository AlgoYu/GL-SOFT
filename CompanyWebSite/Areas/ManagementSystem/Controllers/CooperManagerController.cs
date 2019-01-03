using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using CompanyWebSite.Areas.ManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.Areas.ManagementSystem.Controllers
{
    public class CooperManagerController : ManagementSystemControllerBase
    {
        private readonly EFContext _db;

        public CooperManagerController(EFContext db)
        {
            _db = db;
        }

        // GET
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult SelectCoopers(TableRequest request)
        {
            var data = _db.Coopers.WhereIf(request.KeyWord!=null,x=>x.Company.Contains(request.KeyWord)||x.Contact.Contains(request.KeyWord)||x.Detail.Contains(request.KeyWord)||x.Email.Contains(request.KeyWord)||x.LinkMan.Contains(request.KeyWord));
            TableResponse response = new TableResponse();
            response.Total = data.Count();
            response.Data = data.OrderByDescending(x=>x.CommitDateTime).Skip((request.Page - 1) * request.Limit).Take(request.Limit).Select(x=>new
            {
                x.ID,
                ReadStatus = x.AlreadyRead.GetDescription(),
                x.Company,
                x.CommitDateTime,
                x.Contact,
                x.Detail,
                x.Email,
                x.LinkMan
            }).ToList();
            return Json(response);
        }

        [HttpPost]
        public JsonResult DeleteCoopers(List<Cooper> coopers)
        {
            _db.Coopers.RemoveRange(coopers);
            TableResponse response = new TableResponse();
            response.Total = _db.SaveChanges();
            return Json(response);
        }

        [HttpPost]
        public JsonResult UpdateCooper(int id)
        {
            TableResponse response = new TableResponse();
            var data = _db.Coopers.SingleOrDefault(x => x.ID == id);
            if (data!=null)
            {
                data.AlreadyRead = AlreadyRead.AlreadyRead;
            }
            response.Total = _db.SaveChanges();
            return Json(response);
        }
    }
}