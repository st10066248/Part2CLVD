using Part2CLVD.Models;
using Microsoft.EntityFrameworkCore;

namespace Part2CLVD.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { 
        
        
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; } 
    }
}
