using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmanaShop.DAL.Model
{
    public  class Product
    {

        public   int  ProductID { get; set; }

        public    string ProductName  { get; set; }

        public decimal ProductPrice { get; set; }

        public long ProducCode { get; set; }


    }
}
