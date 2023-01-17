using Microsoft.EntityFrameworkCore;
using Twitter.Domain.Entities;

namespace Twitter.Data.ProgramDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<User> Users { get;set; }
        public virtual DbSet<Post> Posts { get;set; }

    }
}
