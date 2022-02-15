using System;
using System.Collections.Generic;

#nullable disable

namespace Daihoc_FPT_News.Model
{
    public partial class PostTag
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int TagId { get; set; }
        public int Active { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Tag Tag { get; set; }
    }
}
