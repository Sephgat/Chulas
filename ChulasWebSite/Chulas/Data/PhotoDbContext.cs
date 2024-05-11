using Chulas.Models;
using Microsoft.EntityFrameworkCore;

namespace Chulas.Data
{
    public class PhotoDbContext : DbContext
    {
        public PhotoDbContext(DbContextOptions<PhotoDbContext> options) : base(options) { }

        public DbSet<PhotoModel> Photos { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<SpecialItem> SpecialItems { get; set; }
    }

}

