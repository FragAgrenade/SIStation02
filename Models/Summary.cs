using System;

namespace sistation.Models
 {
    public class Summary
    {
        public int SummaryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int UserId { get; set; }
        public User User { get; set; }
    }
 }