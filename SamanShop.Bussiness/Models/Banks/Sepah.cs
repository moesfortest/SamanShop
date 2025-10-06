using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamanShop.Bussiness.Models.Banks
{
    public class Sepah : Bank
    {

        public decimal LongTimeBenefit {  get; set; }
        


        public   decimal CaclulateBene()
        {

            return -1;
        }

        public override bool Deposit(decimal ammount)
        {
            Balance += ammount + 100000;
            return true;
        }

        public override bool TransferMoney()
        {
            throw new NotImplementedException();
        }

        public override bool Withdraw(decimal ammount)
        {
            throw new NotImplementedException();
        }
    }
}
