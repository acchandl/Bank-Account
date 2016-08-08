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
            
            CheckingAccount hutz = new CheckingAccount();
            SavingsAccount lionel = new SavingsAccount();
            ReserveAccount lame = new ReserveAccount();
            string main;





            do
            {
                Console.WriteLine("Welcom to Your Bank! Press One of the Following Numbers to View \n1- Client Information \n2- Account Balance \n3- Deposit Funds \n4- Withdraw Funds \n5- Exit");
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Name: \t \tLionel Hutz \nAccount Number: 004679 \nAccount Types: \tChecking \t \tSavings \t \tReserve");
                    Console.WriteLine();

                }

                if (option == 2)
                {
                    Console.WriteLine("Checking Balance: " + hutz.checkingBalance);
                    Console.WriteLine();
                    Console.WriteLine("Savings Balance: " + lionel.savingsBalance );
                    Console.WriteLine();
                    Console.WriteLine("Reserves Balance: " + lame.reserveBalance);
                }



                if (option == 3)
                {
                    Console.WriteLine("Deposit Funds");
                    Console.WriteLine();
                    Console.WriteLine("Choose From the following: ");
                    Console.WriteLine("1- Checking Account \n2-Savings Account \n3-Reserve Account");
                    int optionDF = int.Parse(Console.ReadLine());
                    if (optionDF == 1)
                    {
                        Console.WriteLine("How much would you like to deposit today?");
                        double cd = double.Parse(Console.ReadLine());
                        Console.WriteLine("Current Daily Deposits: " + (hutz.checkingDeposit + cd));
                        hutz.checkingBalance += cd;

                    }

                    if (optionDF == 2)
                    {
                        Console.WriteLine("How much would you like to deposit today?");
                        double sd = double.Parse(Console.ReadLine());
                        Console.WriteLine("Current Daily Deposits: " + (lionel.savingsDeposits + sd));
                        lionel.savingsBalance += sd;
                    }

                    if (optionDF == 3)
                    {
                        Console.WriteLine("How much would you like to deposit today?");
                        double rd = double.Parse(Console.ReadLine());
                        Console.WriteLine("Current Daily Deposits: " + (lame.reserveDeposit + rd));
                        lame.reserveBalance += rd;
                    }


                }


                if (option == 4)
                {
                    Console.WriteLine("Withdraw Funds");
                    Console.WriteLine();
                    Console.WriteLine("Choose From the following: ");
                    Console.WriteLine("1- Checking Account \n2-Savings Account \n3-Reserve Account");
                    int optionWF = int.Parse(Console.ReadLine());
                    if (optionWF == 1)
                    {
                        Console.WriteLine("How much would you like to withdraw today?");
                        double cw = double.Parse(Console.ReadLine());
                        Console.WriteLine("Current Daily Withdraws: " + (hutz.checkingWithdraw + cw));
                        hutz.checkingBalance -= cw;
                        if (cw > hutz.checkingBalance)
                        {
                            hutz.Negative();
                        }

                    }

                    if (optionWF == 2)
                    {
                        Console.WriteLine("How much would you like to withdraw today?");
                        double sw = double.Parse(Console.ReadLine());
                        Console.WriteLine("Current Daily Withdraws: " + (lionel.savingsWithdraw + sw));
                        lionel.savingsBalance -= sw;
                        if (sw > lionel.savingsBalance)
                        {
                            lionel.Negative();
                        }
                    }

                    if (optionWF == 3)
                    {
                        Console.WriteLine("How much would you like to withdraw today?");
                        double rw = double.Parse(Console.ReadLine());
                        Console.WriteLine("Current Daily Withdraws: " + (lame.reserveWithdraw + rw));
                        lame.reserveBalance -= rw;
                        if (rw > lame.reserveBalance)
                        {
                            lame.Negative();
                        }
                    }


                }



                if (option == 5)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Thank You and Have a Nice Day");
                    Environment.Exit(0);

                }


                Console.WriteLine();
                Console.WriteLine("Do you want to return to the main menu?");
                main = Console.ReadLine().ToUpper();
                Console.Clear();
            }
            while (main == "YES");
















            }
    }
}
