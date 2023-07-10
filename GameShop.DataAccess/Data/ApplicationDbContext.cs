using GameShop.Models;
using Microsoft.EntityFrameworkCore;

namespace GameShop.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Platform> Platforms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Platform>().HasData(
                new Platform { Id = 1, Name = "PS5", DisplayOrder = 1 },
                new Platform { Id = 2, Name = "PS4", DisplayOrder = 2 },
                new Platform { Id = 3, Name = "Switch", DisplayOrder = 3 }
                );
        }
    }
}
