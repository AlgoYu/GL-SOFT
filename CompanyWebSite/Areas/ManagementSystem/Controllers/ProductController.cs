using System.Collections.Generic;
using System.Linq;
using CompanyWebSite.Areas.ManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.Areas.ManagementSystem.Controllers
{
    public class ProductController : ManagementSystemControllerBase
    {
        private readonly EFContext _db;

        public ProductController(EFContext db)
        {
            _db = db;
        }

        // GET
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult SelectProducts(TableRequest request)
        {
            var datas = _db.Products.WhereIf(request.KeyWord!=null,x=>x.Name.Contains(request.KeyWord)).Select(p => new
            {
                p.ID,
                p.Name
            });

            TableResponse tableResponse = new TableResponse();
            tableResponse.Total = datas.Count();
            tableResponse.Data = datas.Skip((request.Page - 1) * request.Limit).Take(request.Limit).OrderBy(x=>x.ID).ToList();
            return Json(tableResponse);
        }

        [HttpPost]
        public JsonResult AddProduct(Product product)
        {
            _db.Products.Add(product);
            TableResponse response = new TableResponse();
            response.Total = _db.SaveChanges();
            return Json(response);
        }


        [HttpPost]
        public JsonResult DeleteProducts(List<Product> products)
        {
            _db.Products.RemoveRange(products);
            TableResponse response = new TableResponse();
            response.Total = _db.SaveChanges();
            return Json(response);
        }

        [HttpPost]
        public JsonResult UpdateProduct(Product product)
        {
            _db.Products.Update(product);
            TableResponse response = new TableResponse();
            response.Total = _db.SaveChanges();
            return Json(response);
        }
    }
}