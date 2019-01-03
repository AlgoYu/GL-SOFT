using System.Collections.Generic;

namespace CompanyWebSite.Areas.ManagementSystem.Models
{
    /**
     * 案例-案例类
     */
    public class Case
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public string Cover { get; set; }

        public virtual ICollection<IndustryCase> IndustryCases { get; set; }
        public virtual ICollection<ColorCase> ColorCases { get; set; }
        public virtual ICollection<ProductCase> ProductCases { get; set; }
        public virtual ICollection<ClientCase> ClientCases { get; set; }
        public virtual ICollection<CaseImage> CaseImages { get; set; }
    }
}