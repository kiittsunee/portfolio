using System.ComponentModel.DataAnnotations;

namespace Portfolio
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Content { get; set; }
    }

    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }

    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        public int Rating { get; set; }
    }
}
