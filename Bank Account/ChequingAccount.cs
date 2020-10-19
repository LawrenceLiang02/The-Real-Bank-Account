using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class ChequingAccount : Account, IAccount
    {
        public ChequingAccount(double startingBal, double currentBal, double interest) : base(startingBal, currentBal, interest)
        {
        }
        public override void MakeWithdrawl(double withdraw)
        {
            if (getCurrentBalance < 0)
            {
                monthServiceCharge = 15;
            }
            else
            {
                monthServiceCharge = 0;
                base.MakeWithdrawl(withdraw);
            }
        }
        
        public override string CloseAndReport()
        {
            if (numberWithdrawals == 0)
            {
                numberWithdrawals += 1;
                monthServiceCharge += 5 + 0.1;
                return base.CloseAndReport();
            }
            else
            {
                numberWithdrawals += 1;
                monthServiceCharge += 0.1;
                return base.CloseAndReport();
            }
        }

        public override void MakeDeposit(double deposit)
        {
            base.MakeDeposit(deposit);
        }
    }
}
