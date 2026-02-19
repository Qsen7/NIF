using Microsoft.EntityFrameworkCore;

namespace Product_and_Sklad.Models
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Sklad> Skladove { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("Data source=.;database=ProductSklad555;integrated security=true;trustservercertificate=true");
        }
    }
}
