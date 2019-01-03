using System.Collections.Generic;
using System.ComponentModel;

namespace CompanyWebSite.Areas.ManagementSystem.Models
{
    /**
     * 合作意向标题类
     */
    public class CooperationTitle
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public CooperationType Type { get; set; } = CooperationType.SingleChoice;
        public virtual List<CooperationContent> CooperationContents{ get; set; }
    }

    public enum CooperationType
    {
        [Description("多选")]
        MultipleChoice = 1,

        [Description("单选")]
        SingleChoice = 2
    }
}