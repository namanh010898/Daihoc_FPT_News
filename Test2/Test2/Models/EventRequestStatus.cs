using System;
using System.Collections.Generic;

#nullable disable

namespace Daihoc_FPT_News.Models
{
    public partial class EventRequestStatus
    {
        public EventRequestStatus()
        {
            EventRequests = new HashSet<EventRequest>();
        }

        public int Id { get; set; }
        public int Active { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ICollection<EventRequest> EventRequests { get; set; }
    }
}
