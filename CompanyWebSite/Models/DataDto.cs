using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyWebSite.Areas.ManagementSystem.Models;

namespace CompanyWebSite.Models
{
    /// <summary>
    /// 传给前端的数据封装
    /// </summary>
    public class DataDto
    {
        public CurrentIndex index { get; set; } = CurrentIndex.Home;
        public object CooperData { get; set; }
        public object Cases { get; set; }
        public SystemInfo SystemInfo { get; set; }
        public object caseDetail { get; set; }
    }
}
