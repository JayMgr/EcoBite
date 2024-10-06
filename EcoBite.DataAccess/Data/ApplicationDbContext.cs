using EcoBiteBook.Models;
using Microsoft.EntityFrameworkCore;

namespace EcoBiteBook.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Fooditem> Fooditems { get; set; }
        public DbSet<Inventory> Inventories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fooditem>().HasData(
                new Fooditem { FooditemId = 1, Name = "Rice", Description = "Available", ExpirationDate = "29 days" },
                new Fooditem { FooditemId = 2, Name = "Burger", Description = "Availabel", ExpirationDate = "5 days" }
                );
            modelBuilder.Entity<Inventory>().HasData(
                  new Inventory
                  {
                      InventoryId = 1,
                      Quantity = 50,
                      DateAdded = DateTime.Now
                  },
            new Inventory
            {
                InventoryId = 2,
                Quantity = 30,
                DateAdded = DateTime.Now.AddDays(-1)
            },
            new Inventory
            {
                InventoryId = 3,
                Quantity = 100,
                DateAdded = DateTime.Now.AddDays(-2)
            }
        );
               
        }
    }
}
