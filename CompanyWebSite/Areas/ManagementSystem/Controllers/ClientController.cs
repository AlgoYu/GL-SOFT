using System.Collections.Generic;
using System.Linq;
using CompanyWebSite.Areas.ManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.Areas.ManagementSystem.Controllers
{
    public class ClientController : ManagementSystemControllerBase
    {
        private readonly EFContext _db;

        public ClientController(EFContext db)
        {
            _db = db;
        }

        // GET
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult SelectClients(TableRequest request)
        {
            var datas = _db.Clients.WhereIf(request.KeyWord!=null,x=>x.Name.Contains(request.KeyWord)).Select(c => new
            {
                c.ID,
                c.Name
            });

            TableResponse tableResponse = new TableResponse();
            tableResponse.Total = datas.Count();
            tableResponse.Data = datas.Skip((request.Page - 1) * request.Limit).Take(request.Limit).OrderBy(x=>x.ID).ToList();
            return Json(tableResponse);
        }

        [HttpPost]
        public JsonResult AddClient(Client client)
        {
            _db.Clients.Add(client);
            TableResponse response = new TableResponse();
            response.Total = _db.SaveChanges();
            return Json(response);
        }


        [HttpPost]
        public JsonResult DeleteClients(List<Client> clients)
        {
            _db.Clients.RemoveRange(clients);
            TableResponse response = new TableResponse();
            response.Total = _db.SaveChanges();
            return Json(response);
        }

        [HttpPost]
        public JsonResult UpdateClient(Client client)
        {
            _db.Clients.Update(client);
            TableResponse response = new TableResponse();
            response.Total = _db.SaveChanges();
            return Json(response);
        }
    }
}