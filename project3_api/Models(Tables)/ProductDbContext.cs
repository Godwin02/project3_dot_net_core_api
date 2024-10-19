using Microsoft.EntityFrameworkCore;

namespace project3_api.Models_Tables_
{
    public class ProductDbContext:DbContext
    {       
        //creating the constructor for our class.
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
        {

        }

        public DbSet<Product_table> Product_Tables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=productDatabase;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
