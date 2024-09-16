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
    }
}
