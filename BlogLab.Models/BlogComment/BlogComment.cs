using System;

namespace BlogLab.Models.BlogComment
{
    public class BlogComment : BlogCommentCreate
    {
        public string Username { get; set; }

        public int AppplicationUserId { get; set; }

        public DateTime PublishDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
