using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SamanShop.Bussiness.Models;

namespace SmanaShop.DAL.Configorations
{
    public class InvoiceConfigoration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable("Invoice");

            builder.HasKey(g => g.InvoiceNumber);
            builder.Property(g => g.InvoiceNumber).ValueGeneratedNever();
            builder.Property(c => c.InvoiceDate);
            builder.Property(c => c.WholePrice);


            builder.HasMany(inv => inv.InvoiceDetails).
                WithOne(inv => inv.Invoice).
                HasForeignKey(inv => inv.InvoiceNumber).
                OnDelete(DeleteBehavior.Cascade);


            builder.HasOne(t => t.Customer).
                WithOne(t => t.Invoice).
                HasForeignKey<Invoice>(t => t.InvoiceNumber);

        }
   
    }
}
