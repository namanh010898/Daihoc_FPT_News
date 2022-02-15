using System;
using System.Collections.Generic;

#nullable disable

namespace Daihoc_FPT_News.Models
{
    public partial class SurveySectionAccountDetail
    {
        public int Id { get; set; }
        public int Active { get; set; }
        public int SurveySectionAccount { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public double Score { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Question Question { get; set; }
        public virtual SurveyAccount SurveySectionAccountNavigation { get; set; }
    }
}
