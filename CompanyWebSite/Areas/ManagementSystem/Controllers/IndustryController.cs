using System.Collections.Generic;
using System.Linq;
using CompanyWebSite.Areas.ManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CompanyWebSite.Areas.ManagementSystem.Controllers
{
    public class IndustryController : ManagementSystemControllerBase
    {
        private readonly EFContext _db;


        public IndustryController(EFContext db)
        {
            _db = db;
        }

        // GET
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult SelectIndustries(TableRequest request)
        {
            var datas = _db.Industries.WhereIf(request.KeyWord != null, x => x.Name.Contains(request.KeyWord)).Select(x => new
            {
                x.ID,
                x.Name
            });

            TableResponse tableResponse = new TableResponse();
            tableResponse.Total = datas.Count();
            tableResponse.Data = datas.Skip((request.Page - 1) * request.Limit).Take(request.Limit).OrderBy(x=>x.ID).ToList();
            return Json(tableResponse);
        }

        [HttpPost]
        public JsonResult AddIndustry(Industry industry)
        {
            _db.Industries.Add(industry);
            TableResponse response = new TableResponse();
            response.Total = _db.SaveChanges();
            return Json(response);
        }


        [HttpPost]
        public JsonResult DeleteIndustries(List<Industry> industries)
        {
            _db.Industries.RemoveRange(industries);
            TableResponse response = new TableResponse();
            response.Total = _db.SaveChanges();
            return Json(response);
        }

        [HttpPost]
        public JsonResult UpdateIndustry(Industry industry)
        {
            _db.Industries.Update(industry);
            TableResponse response = new TableResponse();
            response.Total = _db.SaveChanges();
            return Json(response);
        }
    }
}