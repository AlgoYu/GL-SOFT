using System.Collections.Generic;

namespace CompanyWebSite.Areas.ManagementSystem.Models
{
    public class CaseAddRequest
    {
        public int? ID { get; set; }
        public List<string> CaseImages { get; set; }
        public List<string> ClientCases { get; set; }
        public List<string> ColorCases { get; set; }
        public string Cover { get; set; }
        public List<string> IndustryCases { get; set; }
        public string Name { get; set; }
        public List<string> ProductCases { get; set; }
    }
}