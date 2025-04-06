namespace sistation.Models
{
    public class Quiz
    {
        public int Id { get; set; }

        public string Description { get; set; } = string.Empty;

        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
