using System.Linq;
using CompanyWebSite.Areas.ManagementSystem.Models;
using CompanyWebSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CompanyWebSite.Controllers
{
    public class NetWorkController : Controller
    {
        private readonly EFContext _db;

        public NetWorkController(EFContext db)
        {
            _db = db;
        }

        // GET
        public IActionResult Index()
        {
            DataDto dataDto = new DataDto();
            //获取合作意向数据
            var cooperData = _db.CooperationTitles.Include(x => x.CooperationContents).Select(x => new
            {
                x.ID,
                CooperationContents = x.CooperationContents.Select(b => new
                {
                    b.Name,
                    b.ID
                }),
                x.Type,
                x.Name
            }).ToList();
            dataDto.CooperData = cooperData;

            //获取案例数据
            var caseData = _db.Cases
                /*筛选条件
                .WhereIf(request.IndustryID != null, x => x.IndustryCases.Any(b => b.IndustryID == request.IndustryID))
                .WhereIf(request.ColorID != null, x => x.ColorCases.Any(b => b.ColorID == request.ColorID))
                .WhereIf(request.ProductID != null, x => x.ProductCases.Any(b => b.ProductID == request.ProductID))
                .WhereIf(request.ClientID != null, x => x.ClientCases.Any(b => b.ClientID == request.ClientID))*/
                /*包含关系*/
                .Include(x => x.IndustryCases)
                .Include(x => x.ColorCases)
                .Include(x => x.ProductCases)
                .Include(x => x.ClientCases)
                /*选择属性*/
                .Select(x => new
                {
                    x.ID,
                    x.Name,
                    x.Cover,
                    Industries = x.IndustryCases.Select(i => new
                    {
                        i.Industry.ID,
                        i.Industry.Name
                    }),
                    Colors = x.ColorCases.Select(c => new
                    {
                        c.Color.ID,
                        c.Color.Name,
                        c.Color.Value
                    }),
                    Products = x.ProductCases.Select(p => new
                    {
                        p.Product.ID,
                        p.Product.Name
                    }),
                    Clients = x.ClientCases.Select(c => new
                    {
                        c.Client.ID,
                        c.Client.Name
                    })
                });
            dataDto.Cases = caseData.OrderBy(x => x.ID).Skip(0).Take(8).ToList();
            //获取系统信息数据
            dataDto.SystemInfo = _db.SystemInfo.SingleOrDefault();
            //当前导航页面
            dataDto.index = CurrentIndex.NetWork;
            return View(dataDto);
        }
    }
}