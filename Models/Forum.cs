using System;
using System.Collections.Generic;

namespace sistation.Models
{
    public class Forum
    {
        public int ForumId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}