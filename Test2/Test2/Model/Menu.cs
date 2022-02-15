using System;
using System.Collections.Generic;

#nullable disable

namespace Daihoc_FPT_News.Model
{
    public partial class Menu
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public int Active { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int Priority { get; set; }
        public int GroupId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
