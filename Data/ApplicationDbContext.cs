using Microsoft.EntityFrameworkCore;
using sistation.Models;

namespace sistation.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {  
        }
        public DbSet <User> Users {get;set;}
        public DbSet <Post> Posts {get; set;}
        public DbSet <Forum> Forums {get; set;}
        public DbSet <Summary> Summaries {get; set;}
        public DbSet <Quiz> Quizzes {get; set;}      
     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
            .HasOne(p => p.User)
            .WithMany(u => u.Posts)
            .HasForeignKey(p => p.UserId);
            modelBuilder.Entity<Post>()
            .HasOne(p => p.Forum)
            .WithMany(f => f.Posts)    
            .HasForeignKey(p => p.ForumId);
            modelBuilder.Entity<Summary>()
            .HasOne(s => s.User)
            .WithMany()
            .HasForeignKey(s => s.UserId);
            modelBuilder.Entity<Quiz>()
            .HasOne(q => q.User)
            .WithMany()
            .HasForeignKey(q => q.UserId);
        }
    }
} 