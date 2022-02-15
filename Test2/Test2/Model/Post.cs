using System;
using System.Collections.Generic;

#nullable disable

namespace Daihoc_FPT_News.Model
{
    public partial class Post
    {
        public Post()
        {
            EventRequests = new HashSet<EventRequest>();
        }

        public int Id { get; set; }
        public int PostTypeId { get; set; }
        public int PostAccountId { get; set; }
        public int PostCategoryId { get; set; }
        public int PostLayoutId { get; set; }
        public int PostPublishStatusId { get; set; }
        public int PostCommentStatusId { get; set; }
        public int Active { get; set; }
        public string Url { get; set; }
        public string Photo { get; set; }
        public string Video { get; set; }
        public int? ViewCount { get; set; }
        public int? CommentCount { get; set; }
        public int? LikeCount { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public DateTime? PublishedTime { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? OpenTime { get; set; }
        public DateTime? ClosedTime { get; set; }
        public string EventAddress { get; set; }
        public string FileUrl { get; set; }

        public virtual ICollection<EventRequest> EventRequests { get; set; }
    }
}
