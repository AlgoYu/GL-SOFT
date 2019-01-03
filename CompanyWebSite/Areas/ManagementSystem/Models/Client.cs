using System.Collections.Generic;

namespace CompanyWebSite.Areas.ManagementSystem.Models
{
    /**
     * 案例-客户端类
     */
    public class Client
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ClientCase> ClientCases { get; set; }
    }
}