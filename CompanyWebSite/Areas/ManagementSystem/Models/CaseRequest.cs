namespace CompanyWebSite.Areas.ManagementSystem.Models
{
    public class CaseRequest : RequstTemplate
    {
        public int? IndustryID { get; set; }
        public int? ColorID { get; set; }
        public int? ProductID { get; set; }
        public int? ClientID { get; set; }
    }
}