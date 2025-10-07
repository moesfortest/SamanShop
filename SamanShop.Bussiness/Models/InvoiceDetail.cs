namespace SamanShop.Bussiness.Models
{
    public class InvoiceDetail
    {

        public Guid InvoiceDetailID { get; set; }

        public decimal InavoiveDetailPrice { get; set; }

        public long ProductQuntity { get; set; }


        ///navigation property
        ///
        public long InvoiceNumber
        {
            get; set;

        }


        public Invoice Invoice {  get; set; }
    }
}
