using Microsoft.EntityFrameworkCore;

namespace Product.Data
{
    public class ProductContext: DbContext
    {
       public ProductContext(DbContextOptions<ProductContext> options): base(options){}
       public DbSet<Models.Products> Products { get; set; }
    }
}