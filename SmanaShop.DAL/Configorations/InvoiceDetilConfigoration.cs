using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SamanShop.Bussiness.Models;

namespace SmanaShop.DAL.Configorations
{
    public class InvoiceDetilConfigoration : IEntityTypeConfiguration<InvoiceDetail>
    {
        public void Configure(EntityTypeBuilder<InvoiceDetail> builder)
        {
            builder.ToTable("InvoiceDetil");

            builder.HasKey(g => g.InvoiceDetailID);

            builder.Property(g => g.InvoiceDetailID).ValueGeneratedNever();

            builder.Property(c => c.ProductQuntity);
            builder.Property(c => c.InavoiveDetailPrice);

        }

    }
}
