using System;
using System.Collections.Generic;

#nullable disable

namespace Daihoc_FPT_News.Model
{
    public partial class Survey
    {
        public Survey()
        {
            SurveyAccounts = new HashSet<SurveyAccount>();
            SurveySections = new HashSet<SurveySection>();
        }

        public int Id { get; set; }
        public int Active { get; set; }
        public double Score { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public DateTime? PublishedTime { get; set; }
        public DateTime CreatedTime { get; set; }
        public int SurveyTypeId { get; set; }

        public virtual SurveyType SurveyType { get; set; }
        public virtual ICollection<SurveyAccount> SurveyAccounts { get; set; }
        public virtual ICollection<SurveySection> SurveySections { get; set; }
    }
}
