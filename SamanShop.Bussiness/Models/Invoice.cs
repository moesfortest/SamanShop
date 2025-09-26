using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamanShop.Bussiness.Models
{
    public class Invoice
    {
        public long InvoiceNumber { get; set; }
        public DateTime InvoiceDate { set; get; }
        public decimal WholePrice { get; set; }
        public long CustomerNationalCode { get; set; }

        public List<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
