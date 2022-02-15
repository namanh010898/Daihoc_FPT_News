using System;
using System.Collections.Generic;

#nullable disable

namespace Daihoc_FPT_News.Models
{
    public partial class Notification
    {
        public int Id { get; set; }
        public int Active { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public int ViewStatus { get; set; }
        public int IsChecked { get; set; }
    }
}
