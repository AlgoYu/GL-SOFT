namespace CompanyWebSite.Areas.ManagementSystem.Models
{
    public class ClientCase
    {
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
        public int CaseID { get; set; }
        public virtual Case Case { get; set; }
    }
}