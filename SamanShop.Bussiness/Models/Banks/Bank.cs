using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamanShop.Bussiness.Models.Banks
{
    public abstract class Bank
    {
        public Decimal Balance { get; set; }

        public string Address { get; set; }


        public int BranchCode { get; set; }




        public  Dictionary<string, decimal> LevelofCustomer { get; set; }


        public abstract bool TransferMoney();
   

        public abstract bool Deposit(decimal ammount);



        public abstract bool Withdraw(decimal ammount);
  
    }
}
