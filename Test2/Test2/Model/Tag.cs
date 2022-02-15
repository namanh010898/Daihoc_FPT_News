using System;
using System.Collections.Generic;

#nullable disable

namespace Daihoc_FPT_News.Model
{
    public partial class Tag
    {
        public Tag()
        {
            PostTags = new HashSet<PostTag>();
        }

        public int Id { get; set; }
        public int Active { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public int? PostCount { get; set; }

        public virtual ICollection<PostTag> PostTags { get; set; }
    }
}
