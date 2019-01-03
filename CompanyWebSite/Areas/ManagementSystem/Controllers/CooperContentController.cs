using System.Collections.Generic;
using System.Linq;
using CompanyWebSite.Areas.ManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CompanyWebSite.Areas.ManagementSystem.Controllers
{
    public class CooperContentController : ManagementSystemControllerBase
    {
        private readonly EFContext _db;

        public CooperContentController(EFContext db)
        {
            _db = db;
        }

        // GET
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddCooperContentPage()
        {
            var data = _db.CooperationTitles.ToList();
            return View(data);
        }

        public IActionResult UpdateCooperContentPage(int id)
        {
            var data = new
            {
                CooperationTitles = _db.CooperationTitles.Select(x=>new
                {
                    x.ID,
                    x.Name
                }).ToList(),
                CooperContent = _db.CooperationContents.FirstOrDefault(x => x.ID == id)
            };
            return View(data);
        }

        public JsonResult AddCooperContent(CooperationContent cooperationContent)
        {
            _db.CooperationContents.Add(cooperationContent);
            TableResponse tableResponse = new TableResponse();
            tableResponse.Total = _db.SaveChanges();
            return Json(tableResponse);
        }

        public JsonResult DeleteCooperContents(List<CooperationContent> cooperationContents)
        {
            _db.CooperationContents.RemoveRange(cooperationContents);
            TableResponse tableResponse = new TableResponse();
            tableResponse.Total = _db.SaveChanges();
            return Json(tableResponse);
        }

        public JsonResult UpdateCooperContent(CooperationContent cooperationContent)
        {
            _db.CooperationContents.Update(cooperationContent);
            TableResponse tableResponse = new TableResponse();
            tableResponse.Total = _db.SaveChanges();
            return Json(tableResponse);
        }

        public JsonResult SelectCooperContents(TableRequest request)
        {
            var data = _db.CooperationContents.Include(x=>x.CooperationTitle).WhereIf(request.KeyWord != null, x => x.Name.Contains(request.KeyWord));
            TableResponse tableResponse = new TableResponse();
            tableResponse.Total = data.Count();
            tableResponse.Data = data.Skip((request.Page - 1) * request.Limit).Take(request.Limit).Select(x=>new
            {
                x.ID,
                CooperationTitleName = x.CooperationTitle.Name,
                x.Name
            });
            return Json(tableResponse);
        }
    }
}