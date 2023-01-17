using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using Twitter.Domain.Entities;

namespace Twitter.Data.ProgramDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public virtual DbSet<User> Users { get;set; }
        public virtual DbSet<Post> Posts { get;set; }



    }
}
