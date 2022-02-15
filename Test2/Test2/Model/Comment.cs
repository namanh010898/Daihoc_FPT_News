using System;
using System.Collections.Generic;

#nullable disable

namespace Daihoc_FPT_News.Model
{
    public partial class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int AccountId { get; set; }
        public int Active { get; set; }
        public int Approve { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Text { get; set; }
        public string Website { get; set; }
        public int IsChecked { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
