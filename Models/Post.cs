using System;
using System.ComponentModel.DataAnnotations;

namespace sistation.Models
{
    public class Post
    {
        public int ForumId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}