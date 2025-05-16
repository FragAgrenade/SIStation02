using Microsoft.EntityFrameworkCore;
using sistation.Models; 

namespace sistation.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Forum> Forums { get; set; }
        public DbSet<Summary> Summaries { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relacionamento: Post -> User
            modelBuilder.Entity<Post>()
                .HasOne(p => p.User)
                .WithMany(u => u.Posts)
                .HasForeignKey(p => p.UserId);

            // Relacionamento: Post -> Forum
            modelBuilder.Entity<Post>()
                .HasOne(p => p.Forum)
                .WithMany(f => f.Posts)
                .HasForeignKey(p => p.ForumId);

            // Relacionamento: Summary -> User
            modelBuilder.Entity<Summary>()
                .HasOne(s => s.User)
                .WithMany(u => u.Summaries)
                .HasForeignKey(s => s.UserId);
        }
    }
}
