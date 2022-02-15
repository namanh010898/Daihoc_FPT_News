using System;
using System.Collections.Generic;

#nullable disable

namespace Daihoc_FPT_News.Model
{
    public partial class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
            SurveySectionAccountDetails = new HashSet<SurveySectionAccountDetail>();
        }

        public int Id { get; set; }
        public int? QuestionTypeId { get; set; }
        public int Active { get; set; }
        public string Photo { get; set; }
        public double Score { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual QuestionType QuestionType { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<SurveySectionAccountDetail> SurveySectionAccountDetails { get; set; }
    }
}
