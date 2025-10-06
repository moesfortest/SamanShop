using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmanaShop.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmanaShop.DAL
{
    public class ProductConfigoration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");

            builder.HasKey(g => g.ProductID);

            builder.Property(g => g.ProductID).ValueGeneratedNever();   

            builder.Property(c => c.ProductName).HasMaxLength(50);

            builder.Property(d => d.ProductPrice);


            builder.Property(d => d.ProducCode).IsRequired();

        }
    }
}
