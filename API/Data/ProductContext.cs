using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ProductContext(DbContextOptions options):base(options)
        {
            
        }
    }
}