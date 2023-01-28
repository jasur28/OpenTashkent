using Microsoft.EntityFrameworkCore;
using OpenTashkent.Models;

namespace OpenTashkent.Data
{
    public class CustomDbContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public CustomDbContext(DbContextOptions<CustomDbContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
