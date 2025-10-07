using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmanaShop.DAL.Model;

namespace SmanaShop.DAL.Configorations
{
    public class ProductConfigoration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");

            builder.HasKey(g => g.ProductID);


            builder.Property(c => c.ProductName).HasMaxLength(50);

            builder.Property(d => d.ProductPrice);


            builder.Property(d => d.ProducCode).IsRequired();

        }
    }
}
