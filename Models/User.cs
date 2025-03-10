using System;
using System.Collections.Generic;

namespace sistation.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; } 
        public DateTime CreatedAt = DateTime.UtcNow;
        public ICollection<Post> Posts { get; set; } = new List<Post>() ;
    }
}