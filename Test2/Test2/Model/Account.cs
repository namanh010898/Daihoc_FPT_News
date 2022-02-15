using System;
using System.Collections.Generic;

#nullable disable

namespace Daihoc_FPT_News.Model
{
    public partial class Account
    {
        public Account()
        {
            EventRequests = new HashSet<EventRequest>();
        }

        public int Id { get; set; }
        public int AccountTypeId { get; set; }
        public int Active { get; set; }
        public int Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public string Info { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ICollection<EventRequest> EventRequests { get; set; }
    }
}
