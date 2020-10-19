using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class GlobalSavingsAccount : SavingsAccount, IAccount, IExchangeable
    {
        public GlobalSavingsAccount(double startingBal, double currentBal, double interest) : base(startingBal, currentBal, interest)
        {

        }
        
        public double USValue(double rate)
        {
            return getCurrentBalance * rate;
        }
    }
}
