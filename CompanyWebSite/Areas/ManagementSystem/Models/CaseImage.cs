namespace CompanyWebSite.Areas.ManagementSystem.Models
{
    /**
     * 案例-案例图片
     */
    public class CaseImage
    {
        public int ID { get; set; }
        public string Path { get; set; }
        public virtual int CaseID { get; set; }
    }
}