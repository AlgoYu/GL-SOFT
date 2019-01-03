namespace CompanyWebSite.Areas.ManagementSystem.Models
{
    public class ColorCase
    {
        public int ColorID { get; set; }
        public virtual Color Color { get; set; }
        public int CaseID { get; set; }
        public virtual Case Case { get; set; }
    }
}