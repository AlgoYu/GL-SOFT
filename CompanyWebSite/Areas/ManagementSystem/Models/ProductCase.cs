namespace CompanyWebSite.Areas.ManagementSystem.Models
{
    public class ProductCase
    {
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public int CaseID { get; set; }
        public virtual Case Case { get; set; }
    }
}