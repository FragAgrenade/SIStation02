using System;

namespace sistation.Models
 {
    public class Quiz
    {
        public int QuizId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int UserId { get; set; }
        public User User { get; set; }
    }
 }