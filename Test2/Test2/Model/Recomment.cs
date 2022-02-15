using System;
using System.Collections.Generic;

#nullable disable

namespace Daihoc_FPT_News.Model
{
    public partial class Recomment
    {
        public int Id { get; set; }
        public int SurveySectionId { get; set; }
        public double? MinScore { get; set; }
        public double? MaxScore { get; set; }
        public int Active { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual SurveySection SurveySection { get; set; }
    }
}
