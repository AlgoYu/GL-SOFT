using System.Collections.Generic;

namespace CompanyWebSite.Areas.ManagementSystem.Models
{
    /**
     * 案例-行业类
     */
    public class Industry
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<IndustryCase> IndustryCases { get; set; }
    }
}