using Core.Entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Data
{
    public class App_DbContext:DbContext
    {
        public App_DbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}