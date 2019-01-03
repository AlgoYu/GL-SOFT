namespace CompanyWebSite.Areas.ManagementSystem.Models
{
    public class IndustryCase
    {
        public int IndustryID { get; set; }
        public virtual Industry Industry { get; set; }
        public int CaseID { get; set; }
        public virtual Case Case{ get; set; }
    }
}