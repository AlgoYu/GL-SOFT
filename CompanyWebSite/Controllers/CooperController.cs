using System.Diagnostics;
using CompanyWebSite.Areas.ManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.Controllers
{
    public class CooperController : Controller
    {
        private readonly EFContext _db;

        public CooperController(EFContext db)
        {
            _db = db;
        }

        // GET
        public JsonResult AddCooper(Cooper cooper)
        {
            _db.Coopers.Add(cooper);
            var total = _db.SaveChanges();
            ResponseTemplate response = new ResponseTemplate();
            response.Data = total;
            return Json(response);
        }
    }
}