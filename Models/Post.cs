using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace sistation.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;

        public int UserId { get; set; }
        [ValidateNever]
        public User User { get; set; } = null!;
        public int? ParentPostId { get; set; }
        public int ForumId { get; set; }
        [ValidateNever]
        public Forum Forum { get; set; } = null!;
        [ValidateNever]
        public Post? ParentPost { get; set; }
        [ValidateNever]
        public ICollection<Post> Replies { get; set; } = new List<Post>();
    }
}
