namespace sistation.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;

        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int ForumId { get; set; }
        public Forum Forum { get; set; } = null!;
    }
}
