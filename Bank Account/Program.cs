using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savings = new SavingsAccount(5, 5, 1);
            ChequingAccount chequings = new ChequingAccount(5, 5, 1);
            GlobalSavingsAccount global = new GlobalSavingsAccount(5, 5, 1);

            bool menuExit = false;
            bool savingsExit = false;
            bool chequingExit = false;
            bool globalExit = false;

            while (!menuExit) { 
            Console.WriteLine("Bank Menu, select an option.\nA: Savings\nB: Chequing\nC: Global Savings\nQ:Exit");
            string accountOption = Console.ReadLine();

            
            
                switch (accountOption.ToLower())
                {
                    case "a":
                    case "savings":
                        while (!savingsExit)
                        {
                            Console.WriteLine("Savings Menu, select an option.\nA: Deposit\nB: Withdrawl\nC: Close + Report\nR: Return to Bank Menu");
                        string savingsOption = Console.ReadLine();
                            switch (savingsOption.ToLower())
                            {
                                case "a":
                                case "deposit":
                                    Console.WriteLine("Deposit amount:");
                                    string savingsDeposit = Console.ReadLine();
                                    double savingsDep = Convert.ToDouble(savingsDeposit);
                                    savings.MakeDeposit(savingsDep);
                                    savingsExit = false;
                                    break;
                                case "b":
                                case "withdrawl":
                                    Console.WriteLine("Withdraw amount:");
                                    string savingsWithdraw = Console.ReadLine();
                                    double savingsWith = Convert.ToDouble(savingsWithdraw);
                                    savings.MakeWithdrawl(savingsWith);
                                    savingsExit = false;
                                    break;
                                case "c":
                                case "close":
                                    Console.WriteLine(savings.CloseAndReport());
                                    savingsExit = false;
                                    break;
                                case "r":
                                case "return":
                                    savingsExit = true;
                                    break;
                                default:
                                    Console.WriteLine("Please enter a valid key");
                                    savingsExit = false;
                                    break;
                            }
                        }
                        menuExit = false;
                        break;
                    case "b":
                    case "chequing":
                        while (!chequingExit)
                        {
                            Console.WriteLine("Chequings Menu, select an option.\nA: Deposit\nB: Withdrawl\nC: Close + Report\nR: Return to Bank Menu");
                            string chequingOption = Console.ReadLine();
                            switch (chequingOption.ToLower())
                            {
                                case "a":
                                case "deposit":
                                    Console.WriteLine("Deposit amount:");
                                    string chequingDeposit = Console.ReadLine();

                                    double chequingsDep = Convert.ToDouble(chequingDeposit);
                                    chequings.MakeDeposit(chequingsDep);
                                    chequingExit = false;
                                    break;
                                case "b":
                                case "withdrawl":
                                    Console.WriteLine("Withdraw amount:");
                                    string chequingWithdrawl = Console.ReadLine();
                                    double chequingWith = Convert.ToDouble(chequingWithdrawl);
                                    chequings.MakeWithdrawl(chequingWith);
                                    chequingExit = false;
                                    break;
                                case "c":
                                case "close":
                                    Console.WriteLine(chequings.CloseAndReport());
                                    chequingExit = false;
                                    break;
                                case "r":
                                case "return":
                                    chequingExit = true;
                                    break;
                                default:
                                    Console.WriteLine("Please enter a valid key");
                                    chequingExit = false;
                                    break;
                            }
                        }
                        menuExit = false;
                        break;
                    case "c":
                    case "globalsavings":
                        while (!globalExit)
                        {
                            Console.WriteLine("Global Savings Menu, select an option.\nA: Deposit\nB: Withdrawl\nC: Close + Report\nD: Report Balance in USD\nR: Return to Bank Menu");
                            string globalOption = Console.ReadLine();
                            switch (globalOption.ToLower())
                            {
                                case "a":
                                case "deposit":
                                    Console.WriteLine("Deposit amount:");
                                    string globalDeposit = Console.ReadLine();
                                    double globalDep = Convert.ToDouble(globalDeposit);
                                    global.MakeDeposit(globalDep);
                                    globalExit = false;
                                    break;
                                case "b":
                                case "withdrawl":
                                    Console.WriteLine("Withdraw amount:");
                                    string globalWithdrawl = Console.ReadLine();
                                    double globalWith = Convert.ToDouble(globalWithdrawl);
                                    global.MakeWithdrawl(globalWith);
                                    globalExit = false;
                                    break;
                                case "c":
                                case "close":
                                    Console.WriteLine(global.CloseAndReport());
                                    globalExit = false;
                                    break;
                                case "d":
                                case "report":
                                    //Console.WriteLine(global.USValue());
                                    Console.WriteLine("You never specified anything about the rate soooo....");
                                    globalExit = false;
                                    break;
                                case "r":
                                case "return":
                                    globalExit = true;
                                    break;
                                default:
                                    Console.WriteLine("Please enter a valid key");
                                    globalExit = false;
                                    break;
                            }
                        }
                        menuExit = false;
                        break;
                    case "q":
                    case "exit":
                        menuExit = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid key");
                        menuExit = false;
                        break;
                }
            }
        }

    }

}
