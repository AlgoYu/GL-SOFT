using System;

namespace CompanyWebSite.Areas.ManagementSystem.Models
{
    public class ResponseTemplate
    {
        public int Status { get; set; } = 200;
        public string Message { get; set; } = "";
        public object Data { get; set; } = null;
    }
}