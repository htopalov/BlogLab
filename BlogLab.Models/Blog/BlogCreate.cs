using System.ComponentModel.DataAnnotations;

namespace BlogLab.Models.Blog
{
    public class BlogCreate
    {
        public int BlogId { get; set; }

        [Required(ErrorMessage = "Title is required!")]
        [MinLength(10, ErrorMessage = "Title must be between 10 and 50 characters long!")]
        [MaxLength(50, ErrorMessage = "Title must be between 10 and 50 characters long!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content is required!")]
        [MinLength(300, ErrorMessage = "Content must be between 300 and 3000 characters long!")]
        [MaxLength(3000, ErrorMessage = "Content must be between 300 and 3000 characters long!")]
        public string Content { get; set; }

        public int? PhotoId { get; set; }
    }
}
