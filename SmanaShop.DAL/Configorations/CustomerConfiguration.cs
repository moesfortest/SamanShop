using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SamanShop.Bussiness.Models;
using System.Security.Cryptography.X509Certificates;

namespace SmanaShop.DAL.Configorations
{
    public class CustomerConfiguration:IEntityTypeConfiguration<Customer>
    {

        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");

            builder.HasKey(g => g.NationalCode);

            builder.Property(g => g.NationalCode).ValueGeneratedNever();

            builder.Property(g => g.LastName).HasMaxLength(10);
            builder.Property(g => g.FirstName).HasMaxLength(10); ;
            builder.Property(g => g.Address).HasMaxLength(100); 

            

        }

    }

    //public string FirstName { get; set; }

    //    public string LastName { get; set; }

    //    public long NationalCode { get; set; }

    //    public string Address { get; set; }

    //    public long? PhoneNumber { get; set; }
    }
