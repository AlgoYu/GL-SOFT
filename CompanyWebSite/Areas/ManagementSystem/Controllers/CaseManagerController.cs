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
    public class CaseManagerController : ManagementSystemControllerBase
    {
        private readonly EFContext _db;

        public CaseManagerController(EFContext db)
        {
            _db = db;
        }

        // GET
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddCase()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult UpdateCase(int id)
        {
            var @case = _db.Cases
                /*包含关系*/
                .Include(x => x.IndustryCases)
                .Include(x => x.ColorCases)
                .Include(x => x.ProductCases)
                .Include(x => x.ClientCases)
                .Include(x=>x.CaseImages)
                /*选择属性*/
                .Select(x => new
                {
                    x.ID,
                    x.Name,
                    x.Cover,
                    Industries = x.IndustryCases.Select(i => i.IndustryID),
                    Colors = x.ColorCases.Select(c => c.ColorID),
                    Products = x.ProductCases.Select(p => p.ProductID),
                    Clients = x.ClientCases.Select(c => c.ClientID),
                    CaseImages = x.CaseImages
                }).FirstOrDefault(x=>x.ID == id);

            return View(@case);
        }

        [HttpGet]
        public JsonResult TableCaseData(int page,int limit)
        {
            var datas = _db.Cases.Skip((page - 1) * limit).Take(limit).Select(x => new
            {
                x.ID,
                x.Cover,
                x.Name
            }).ToList();
            TableResponse response = new TableResponse();
            response.Data = datas;
            return Json(response);
        }


        


        [HttpPost]
        public JsonResult AddCase(CaseAddRequest request)
        {
            TableResponse response = new TableResponse();
            //开启事物
            using (var trans = _db.Database.BeginTransaction())
            {
                try
                {
                    //创建Case对象
                    var @case = new Case()
                    {
                        Cover = request.Cover,
                        Name = request.Name,
                        IndustryCases = new List<IndustryCase>(),
                        ColorCases = new List<ColorCase>(),
                        ProductCases = new List<ProductCase>(),
                        ClientCases = new List<ClientCase>(),
                        CaseImages = new List<CaseImage>()
                    };
                    //先存入Case对象
                    _db.Cases.Add(@case);
                    //保存后会有ID
                    _db.SaveChanges();
                    //存入行业关系
                    request.IndustryCases.ForEach(x =>
                    {
                        @case.IndustryCases.Add(new IndustryCase()
                        {
                            IndustryID = int.Parse(x)
                        });
                    });
                    //存入颜色关系
                    request.ColorCases.ForEach(x =>
                    {
                        @case.ColorCases.Add(new ColorCase()
                        {
                            ColorID = int.Parse(x)
                        });
                    });
                    //存入产品关系
                    request.ProductCases.ForEach(x =>
                    {
                        @case.ProductCases.Add(new ProductCase()
                        {
                            ProductID = int.Parse(x)
                        });
                    });
                    //存入客户端关系
                    request.ClientCases.ForEach(x =>
                    {
                        @case.ClientCases.Add(new ClientCase()
                        {
                            ClientID = int.Parse(x)
                        });
                    });
                    //存入详情图片
                    request.CaseImages.ForEach(x =>
                    {
                        @case.CaseImages.Add(new CaseImage()
                        {
                            Path = x
                        });
                    });
                    response.Total =_db.SaveChanges();
                    trans.Commit();
                }
                catch (Exception e)
                {
                    //若执行失败事物回滚
                    trans.Rollback();
                }
            }
            return Json(response);
        }


        [HttpPost]
        public JsonResult DeleteCases(List<Case> cases)
        {
            _db.Cases.RemoveRange(cases);
            TableResponse response = new TableResponse();
            response.Total = _db.SaveChanges();
            return Json(response);
        }
        /*
         * 更新案例时多对多关系处理
         */
        [HttpPost]
        public JsonResult UpdateCase(CaseAddRequest request)
        {
            TableResponse response = new TableResponse();
            //开启事物
            using (var trans = _db.Database.BeginTransaction())
            {
                try
                {
                    //案例包含的所有关系
                    var @case = _db.Cases
                        .Include(x=>x.CaseImages)
                        .Include(x=>x.IndustryCases)
                        .Include(x=>x.ColorCases)
                        .Include(x=>x.ProductCases)
                        .Include(x=>x.ClientCases)
                        .FirstOrDefault(x => x.ID == request.ID);
                    //清空多对多关系
                    @case.CaseImages.Clear();
                    @case.IndustryCases.Clear();
                    @case.ColorCases.Clear();
                    @case.ProductCases.Clear();
                    @case.ClientCases.Clear();
                    //修改值
                    @case.Cover = request.Cover;
                    @case.Name = request.Name;
                    //存入行业关系
                    request.IndustryCases.ForEach(x =>
                    {
                        @case.IndustryCases.Add(new IndustryCase()
                        {
                            IndustryID = int.Parse(x)
                        });
                    });
                    //存入颜色关系
                    request.ColorCases.ForEach(x =>
                    {
                        @case.ColorCases.Add(new ColorCase()
                        {
                            ColorID = int.Parse(x)
                        });
                    });
                    //存入产品关系
                    request.ProductCases.ForEach(x =>
                    {
                        @case.ProductCases.Add(new ProductCase()
                        {
                            ProductID = int.Parse(x)
                        });
                    });
                    //存入客户端关系
                    request.ClientCases.ForEach(x =>
                    {
                        @case.ClientCases.Add(new ClientCase()
                        {
                            ClientID = int.Parse(x)
                        });
                    });
                    //存入详情图片
                    request.CaseImages.ForEach(x =>
                    {
                        @case.CaseImages.Add(new CaseImage()
                        {
                            Path = x
                        });
                    });
                    _db.Cases.Update(@case);
                    response.Total = _db.SaveChanges();
                    trans.Commit();
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.ToString());
                    //若执行失败事物回滚
                    trans.Rollback();
                }
            }
            return Json(response);
        }
    }
}