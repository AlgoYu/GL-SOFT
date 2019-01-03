namespace CompanyWebSite.Areas.ManagementSystem.Models
{
    public class CaseResponse : ResponseTemplate
    {
        public int? IndustryID { get; set; }
        public int? ColorID { get; set; }
        public int? ProductID { get; set; }
        public int? ClientID { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
        public int Total { get; set; }
    }
}