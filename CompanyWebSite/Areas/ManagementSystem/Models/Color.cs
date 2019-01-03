using System.Collections.Generic;

namespace CompanyWebSite.Areas.ManagementSystem.Models
{
    /**
     * 案例-颜色类
     */
    public class Color
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public virtual ICollection<ColorCase> ColorCases { get; set; }
    }
}