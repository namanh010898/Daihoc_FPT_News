using System;
using System.Collections.Generic;

#nullable disable

namespace Daihoc_FPT_News.Models
{
    public partial class Subcribe
    {
        public int Id { get; set; }
        public int Active { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
