using System;
using System.Collections.Generic;

#nullable disable

namespace Daihoc_FPT_News.Model
{
    public partial class PostCategory
    {
        public int Id { get; set; }
        public int Active { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public int? PostCount { get; set; }
    }
}
