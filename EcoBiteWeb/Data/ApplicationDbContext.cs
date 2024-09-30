using EcoBiteWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace EcoBiteWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Fooditem> Fooditems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fooditem>().HasData(
                new Fooditem { FooditemId = 1, Name = "Rice", Description = "Available", ExpirationDate = "29 days" },
                new Fooditem { FooditemId = 2, Name = "Burger", Description = "Availabel", ExpirationDate = "5 days" }
                );
        }
    }
}
