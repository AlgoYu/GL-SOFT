using System.Collections.Generic;
using System.Linq;
using CompanyWebSite.Areas.ManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.Areas.ManagementSystem.Controllers
{
    public class CooperTitle : ManagementSystemControllerBase
    {
        private readonly EFContext _db;

        public CooperTitle(EFContext db)
        {
            _db = db;
        }

        // GET
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddCooperTitlePage()
        {
            return View();
        }

        public IActionResult UpdateCooperTitlePage(int id)
        {
            var data = _db.CooperationTitles.FirstOrDefault(x => x.ID == id);
            return View(data);
        }

        [HttpPost]
        public JsonResult AddCooperTitle(CooperationTitle cooperationTitle)
        {
            _db.CooperationTitles.Add(cooperationTitle);
            TableResponse tableResponse = new TableResponse();
            tableResponse.Total = _db.SaveChanges();
            return Json(tableResponse);
        }

        [HttpPost]
        public JsonResult DeleteCooperTitles(List<CooperationTitle> cooperationTitles)
        {
            _db.CooperationTitles.RemoveRange(cooperationTitles);
            TableResponse tableResponse = new TableResponse();
            tableResponse.Total = _db.SaveChanges();
            return Json(tableResponse);
        }

        [HttpPost]
        public JsonResult UpdateCooperTitle(CooperationTitle cooperationTitle)
        {
            _db.CooperationTitles.Update(cooperationTitle);
            TableResponse tableResponse = new TableResponse();
            tableResponse.Total = _db.SaveChanges();
            return Json(tableResponse);
        }

        public JsonResult SelectCooperTitles(TableRequest request)
        {
            var data = _db.CooperationTitles.WhereIf(request.KeyWord != null, x => x.Name.Contains(request.KeyWord));
            TableResponse tableResponse = new TableResponse();
            tableResponse.Total = data.Count();
            tableResponse.Data = data.Skip((request.Page-1)*request.Limit).Take(request.Limit)
                .Select(x => new
                {
                    x.ID,
                    x.Name,
                    x.Type
                })
                .ToList()
                .Select(x => new
                {
                    x.ID,
                    x.Name,
                    Type = x.Type.GetDescription()
                });
            return Json(tableResponse);
        }
    }
}