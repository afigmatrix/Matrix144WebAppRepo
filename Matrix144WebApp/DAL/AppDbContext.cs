using Matrix144WebApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace Matrix144WebApp.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {     
        }

        public DbSet<Product> Products { get; set; }

    }
}
