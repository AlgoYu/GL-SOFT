namespace CompanyWebSite.Areas.ManagementSystem.Models
{
    /**
     * 合作意向表内容类
     */
    public class CooperationContent
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CooperationTitleID { get; set; }
        public CooperationTitle CooperationTitle { get; set; }
    }
}