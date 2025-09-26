using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamanShop.Bussiness.Models.Banks
{
    public class Saman:Bank
    {

        public Saman()
        {
            LevelofCustomer = new Dictionary<string, decimal>();
            LevelofCustomer.Add("A",5000000);
            LevelofCustomer.Add("B", 2000000);
            LevelofCustomer.Add("C", 5000000);
            LevelofCustomer.Add("D", 2000000);
        }

        public  decimal   FeeonInternationATM { get; set; }

        public int  SwiftCode { get; set; }


        public  decimal CaclulateFee()
        {

            return 10;
        }

        public override bool Deposit(decimal ammount)
        {
            Balance += ammount +-100000;
            return true;
        }

        public override bool TransferMoney()
        {
            throw new NotImplementedException();
        }

        


        public override bool Withdraw(decimal ammount)
        {


            var customerBalance = 1000000;

            var validBalance = LevelofCustomer.TryGetValue("D", out decimal Value);
            return true; ;

        }
    }
}
