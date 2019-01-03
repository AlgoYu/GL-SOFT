using System.Collections.Generic;
using System.Linq;
using CompanyWebSite.Areas.ManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.Areas.ManagementSystem.Controllers
{
    public class ColorController : ManagementSystemControllerBase
    {
        private readonly EFContext _db;

        public ColorController(EFContext db)
        {
            _db = db;
        }

        // GET
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddColor()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UpdateColor(int id)
        {
            var color = _db.Colors.FirstOrDefault(x => x.ID == id);
            return View(color);
        }

        public JsonResult SelectColors(TableRequest request)
        {
            var datas = _db.Colors.WhereIf(request.KeyWord!=null, x=>x.Name.Contains(request.KeyWord)||x.Value.Contains(request.KeyWord)).Select(c => new
            {
                c.ID,
                c.Name,
                c.Value
            });

            TableResponse tableResponse = new TableResponse();
            tableResponse.Total = datas.Count();
            tableResponse.Data = datas.Skip((request.Page - 1) * request.Limit).Take(request.Limit).OrderBy(x=>x.ID).ToList();
            return Json(tableResponse);
        }

        [HttpPost]
        public JsonResult AddColor(Color color)
        {
            _db.Colors.Add(color);
            TableResponse response = new TableResponse();
            response.Total = _db.SaveChanges();
            return Json(response);
        }


        [HttpPost]
        public JsonResult DeleteColors(List<Color> Colors)
        {
            _db.Colors.RemoveRange(Colors);
            TableResponse response = new TableResponse();
            response.Total = _db.SaveChanges();
            return Json(response);
        }

        [HttpPost]
        public JsonResult UpdateColor(Color color)
        {
            _db.Colors.Update(color);
            TableResponse response = new TableResponse();
            response.Total = _db.SaveChanges();
            return Json(response);
        }
    }
}