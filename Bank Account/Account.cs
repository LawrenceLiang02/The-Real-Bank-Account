using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    abstract class Account : IAccount
    {
        private double startingBalance;
        private double currentBalance;

        protected double totalDeposits;
        protected int numberDeposit;

        protected double totalWithdrawals;
        protected int numberWithdrawals;

        protected double annualInterest;
        protected double monthServiceCharge;

        protected enum accountStatus
        {
            active = 1,
            inactive = 0
        }

        public double getStartingBalance
        {
            get
            {
                return startingBalance;
            }

        }

        public double getCurrentBalance
        {
            get
            {
                return currentBalance;
            }
        }

        public Account(double startingBal, double currentBal, double interest)
        {
            startingBalance = startingBal;
            currentBalance = currentBal;
            annualInterest = interest;
        }

        public virtual void MakeDeposit(double deposit)
        {
            totalDeposits += deposit;
            currentBalance += deposit;
            numberDeposit += 1;
        }

        public virtual void MakeWithdrawl(double withdraw)
        {
            totalWithdrawals -= withdraw;
            numberWithdrawals -= 1;
            currentBalance -= withdraw;
        }

        public void CalculateInterest()
        {
            double monthlyInterestRate = (annualInterest / 12);
            monthlyInterestRate *= currentBalance;
            currentBalance += monthlyInterestRate;
        }

        public double getPercentageChange()
        {
            double percentage = Math.Round(((currentBalance - startingBalance) / startingBalance), 2);
            return percentage;
        }

        public virtual string CloseAndReport()
        {
            currentBalance -= monthServiceCharge;
            CalculateInterest();


            double monthlyInterestRate = (annualInterest / 12);

            string info = string.Format("Previous Balance: {0}\nNew Balance: {1}\nPercentage Changed: {2}\nMonthly Interest Rate: {3}\nMonthly Service Charge: {4}", startingBalance, currentBalance, getPercentageChange(), monthlyInterestRate, monthServiceCharge);

            numberWithdrawals = 0;
            totalWithdrawals = 0;
            numberDeposit = 0;
            totalDeposits = 0;
            monthServiceCharge = 0;
            startingBalance = currentBalance;
            return info;
        }

    }
}
