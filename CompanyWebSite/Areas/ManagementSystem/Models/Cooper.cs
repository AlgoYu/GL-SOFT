using System;
using System.ComponentModel;

namespace CompanyWebSite.Areas.ManagementSystem.Models
{
    public class Cooper
    {
        public int ID { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string LinkMan { get; set; }
        public string Contact { get; set; }
        public string Detail { get; set; }
        public DateTime CommitDateTime { get; set; } = DateTime.Now;
        public AlreadyRead AlreadyRead { get; set; } = AlreadyRead.NotRead;
    }

    public enum AlreadyRead
    {
        [Description("还未阅读")]
        NotRead = 0,

        [Description("已经阅读")]
        AlreadyRead = 1
    }
}