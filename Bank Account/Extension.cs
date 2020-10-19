using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    public static class Extension
    {
        public static string NAMoneyFormat(double money, Boolean round)
        {
            string moneyFormat = "";
            if (round == true)
            {
                money = Math.Round(money, 2);
                return moneyFormat;
            }
            return moneyFormat;
        }
    }
}
