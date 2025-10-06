//using Microsoft.EntityFrameworkCore;
//using SamanShop.Bussiness.Models;
//using SmanaShop.DAL.Model;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SmanaShop.DAL
//{
//    internal class Class1
//    {
//        //// One-to-many relationship
//        //builder.HasMany(i => i.InvoiceDetails)
//        //       .WithOne(d => d.Invoice)
//        //       .HasForeignKey(d => d.InvoiceId)
//        //       .OnDelete(DeleteBehavior.Cascade);

//        // many  to manyu

//        //public class InvoiceDetailProduct
//        //{
//        //    public int InvoiceDetailId { get; set; }
//        //    public InvoiceDetail InvoiceDetail { get; set; }

//        //    public int ProductId { get; set; }
//        //    public Product Product { get; set; }

//        //    public int Quantity { get; set; }  // optional, e.g., how many of this product
//        //}

//    //        {
//    //    builder.HasKey(x => new { x.InvoiceDetailId, x.ProductId
//    //}); // composite PK

//    //    builder.HasOne(x => x.InvoiceDetail)
//    //           .WithMany(d => d.InvoiceDetailProducts)
//    //           .HasForeignKey(x => x.InvoiceDetailId);

//    //builder.HasOne(x => x.Product)
//    //           .WithMany(p => p.InvoiceDetailProducts)
//    //           .HasForeignKey(x => x.ProductId);
//}
//        //public ICollection<InvoiceDetailProduct> InvoiceDetailProducts { get; set; }

//        //public ICollection<InvoiceDetailProduct> InvoiceDetailProducts { get; set; }


//        //builder.HasOne(x => x.InvoiceDetail)
//        //       .WithMany(d => d.InvoiceDetailProducts)
//        //       .HasForeignKey(x => x.InvoiceDetailId);

//        //builder.HasOne(x => x.Product)
//        //       .WithMany(p => p.InvoiceDetailProducts)
//        //       .HasForeignKey(x => x.ProductId);


//        ////on to on
//        ///
//        //public class Customer
//        //{
//        //    public int CustomerId { get; set; }
//        //    public string FullName { get; set; }
//        //    public long NationalCode { get; set; }

//        //    // One-to-one with InvoiceDetail
//        //    public Invoice Invoice { get; set; }
//        //}

//        //// One-to-one with Customer
//        //public int CustomerId { get; set; }
//        //public Customer Customer { get; set; }


//        //// One-to-one Invoice ↔ Customer
//        //builder.HasOne(i => i.Customer)
//        //       .WithOne(c => c.Invoice)
//        //       .HasForeignKey<Invoice>(i => i.CustomerId);

//    }
//}
