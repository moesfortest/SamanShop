using Microsoft.EntityFrameworkCore;
using SmanaShop.DAL.Configorations;
using SmanaShop.DAL.Model;

namespace SmanaShop.DAL
{
    public class SamanDbContext:DbContext
    {

      public DbSet<Product> Products { get; set;}

        public SamanDbContext(DbContextOptions<SamanDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceDetilConfigoration());
            modelBuilder.ApplyConfiguration(new InvoiceConfigoration());
            modelBuilder.ApplyConfiguration(new ProductConfigoration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
