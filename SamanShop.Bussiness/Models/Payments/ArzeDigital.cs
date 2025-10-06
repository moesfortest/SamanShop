using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamanShop.Bussiness.Models.Payments
{
    public class ArzeDigital:Payment
    {
        public   new  bool Pay(decimal amount)
        {

            Money -= amount;
            return true;
        }
    }
}
