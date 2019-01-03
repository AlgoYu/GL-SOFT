using System.Collections.Generic;

namespace CompanyWebSite.Areas.ManagementSystem.Models
{
    /**
     * 案例-产品类
     */
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ProductCase> ProductCases { get; set; }
    }
}