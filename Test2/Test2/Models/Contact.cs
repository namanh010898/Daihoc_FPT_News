using System;
using System.Collections.Generic;

#nullable disable

namespace Daihoc_FPT_News.Models
{
    public partial class Contact
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public int Active { get; set; }

        public virtual Account Account { get; set; }
    }
}
