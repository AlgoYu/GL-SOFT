using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyWebSite.Areas.ManagementSystem.Models
{
    public class SystemInfo
    {
        /// <summary>
        /// ID字段
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 网站Logo网址
        /// </summary>
        public string LogoUrl { get; set; }
        /// <summary>
        /// QQ号码
        /// </summary>
        public string QQ { get; set; }
        /// <summary>
        /// 微信号
        /// </summary>
        public string WeChat { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 微信二维码地址图片
        /// </summary>
        public string WeChatQR { get; set; }
        /// <summary>
        /// 网站标题
        /// </summary>
        public string SiteTitle { get; set; }
        /// <summary>
        /// 关键字
        /// </summary>
        public string KeyWords { get; set; }
        /// <summary>
        /// 版权
        /// </summary>
        public string Copyright { get; set; }
        /// <summary>
        /// 备案号
        /// </summary>
        public string Record { get; set; }
        /// <summary>
        /// 外部JS
        /// </summary>
        public string ExteriorJs { get; set; }
    }
}
