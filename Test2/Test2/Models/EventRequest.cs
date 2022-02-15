using Daihoc_FPT_News.Model;
using System;

#nullable disable

namespace Daihoc_FPT_News.Models
{
    public partial class EventRequest
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int AccountId { get; set; }
        public int Active { get; set; }
        public int EventRequestStatusId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Account Account { get; set; }
        public virtual EventRequestStatus EventRequestStatus { get; set; }
        public virtual Post Post { get; set; }
    }
}
