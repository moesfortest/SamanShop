namespace SamanShop.Bussiness.Models
{
    public class Customer
    {
   
        public  string  FirstName {  get; set; }

        public string LastName { get; set; }

        public  long  NationalCode {  get; set; }

        public string Address { get; set; }

        public long? PhoneNumber { get; set; }

        public long InvoiceNumber { get; set; }
        public  Invoice Invoice { get; set; }
    }
}
