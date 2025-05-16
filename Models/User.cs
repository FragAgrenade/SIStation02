namespace sistation.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

        public ICollection<Post> Posts { get; set; } = new List<Post>();
        public ICollection<Summary> Summaries { get; set; } = new List<Summary>();
    }
}
