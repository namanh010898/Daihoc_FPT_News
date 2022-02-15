using System;
using System.Collections.Generic;

#nullable disable

namespace Daihoc_FPT_News.Model
{
    public partial class QuestionType
    {
        public QuestionType()
        {
            Questions = new HashSet<Question>();
        }

        public int Id { get; set; }
        public int Active { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}
