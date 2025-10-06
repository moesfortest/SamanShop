using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamanShop.Bussiness.Models.Banks
{
    public class Saderat:Bank
    {

        public  decimal  NimaieeExchnage { get; set; }  


        public  decimal ExportExchnage { get; set; }

        public override bool Deposit(decimal ammount)
        {
            throw new NotImplementedException();
        }

        public decimal  GetImportLoan()
        {
            return 0;
        }

        public override bool TransferMoney()
        {
            throw new NotImplementedException();
        }

        public override bool Withdraw(decimal ammount)
        {
            Balance += ammount;
            return true;    
        }
    }
}
