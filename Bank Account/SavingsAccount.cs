using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class SavingsAccount : Account, IAccount
    {
        accountStatus accountStatus;
        public SavingsAccount(double startingBal, double currentBal, double interest) :base(startingBal, currentBal, interest)
        {
            if (currentBal < 25)
            {
                accountStatus = accountStatus.inactive;
            }
            else
            {
                accountStatus = accountStatus.active;
            }
        }
        public override void MakeWithdrawl(double withdraw)
        {
            if (accountStatus == accountStatus.inactive)
            {
                Console.Write("Account Inactive.");
            }
            else if (accountStatus == accountStatus.active && 25 > getCurrentBalance - withdraw)
            {
                Console.Write("Account falls below $25.");
            }
            else if (accountStatus == accountStatus.active && 25 <= getCurrentBalance - withdraw)
            {
                MakeWithdrawl(withdraw);
            }
        }
        public override void MakeDeposit(double deposit)
        {
            if (accountStatus == accountStatus.inactive && getCurrentBalance + deposit > 25)
            {
                MakeDeposit(deposit);
                accountStatus = accountStatus.active;
            }
            else if (accountStatus == accountStatus.active)
            {
                MakeDeposit(deposit);
            }
        }

        public override string CloseAndReport()
        {
            if (numberWithdrawals > 4)
            {
                monthServiceCharge += 1;
                return CloseAndReport();
            }
            else
            {
                return CloseAndReport();
            }
        }


    }
}
