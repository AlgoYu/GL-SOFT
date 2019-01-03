using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyWebSite.Areas.ManagementSystem.Models;

namespace CompanyWebSite.Models
{
    //传输给前端的数据
    public class DataDto
    {
        public object CooperData { get; set; }
        public object Cases { get; set; }
        public SystemInfo SystemInfo { get; set; }
        public object caseDetail { get; set; }
    }
}
