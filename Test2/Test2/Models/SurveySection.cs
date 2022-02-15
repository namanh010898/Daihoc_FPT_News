using System;
using System.Collections.Generic;

#nullable disable

namespace Daihoc_FPT_News.Models
{
    public partial class SurveySection
    {
        public SurveySection()
        {
            Recomments = new HashSet<Recomment>();
            SurveySectionQuestions = new HashSet<SurveySectionQuestion>();
        }

        public int Id { get; set; }
        public int SurveyId { get; set; }
        public int? SurveySectionId { get; set; }
        public int Active { get; set; }
        public int ProportionScore { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Survey Survey { get; set; }
        public virtual ICollection<Recomment> Recomments { get; set; }
        public virtual ICollection<SurveySectionQuestion> SurveySectionQuestions { get; set; }
    }
}
