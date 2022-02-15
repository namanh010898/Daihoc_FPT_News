using System;
using System.Collections.Generic;

#nullable disable

namespace Daihoc_FPT_News.Models
{
    public partial class SurveyAccount
    {
        public SurveyAccount()
        {
            SurveySectionAccountDetails = new HashSet<SurveySectionAccountDetail>();
            SurveySectionAccounts = new HashSet<SurveySectionAccount>();
        }

        public int Id { get; set; }
        public int AccountId { get; set; }
        public int SurveyId { get; set; }
        public int Active { get; set; }
        public double Score { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Survey Survey { get; set; }
        public virtual ICollection<SurveySectionAccountDetail> SurveySectionAccountDetails { get; set; }
        public virtual ICollection<SurveySectionAccount> SurveySectionAccounts { get; set; }
    }
}
