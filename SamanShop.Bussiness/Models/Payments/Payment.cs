using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SamanShop.Bussiness.Models.Payments
{
    public class Payment
    {
        public decimal Money { get; set; }




        public Dictionary<string, Payment> payMentWay { get; set; }

        public Payment()
        {



  

            payMentWay =new Dictionary<string, Payment>();

            payMentWay.Add("Paypal", new  PayPal());
            payMentWay.Add("CardToCard", new CardToCard());
            payMentWay.Add("ArzeDigital", new ArzeDigital());
        }

        public virtual bool  Pay(decimal  amount)
        {

            Money -= amount;
            return true;    
        }


        public    int  Add(int x  , int  y, Func<int, int, int> method)
        {

            var result = method(12, 13);
            return result;
        }
    }
}
