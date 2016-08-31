using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    public abstract class BankAccount1
    {

        protected string balance;
        public static double NegativeBalance;
        public static double ZeroBalance;
       
        protected double deposit;
        
      
           
        //properties and fields can be related
        //enter the starting balance..or hard code it 

        public virtual void BankAccount(string checkingBalance, string savingsBalance, string reserveBalance)
        {
            Console.WriteLine("Your Checking Account Balance is: " + checkingBalance + "\nYour Savings Account Balance is: " + savingsBalance
                + "\nYour Reserve Account Balance is: " + reserveBalance);

        }

      

        public virtual void showTotal()
        {
            Console.WriteLine("Checking Account Balance: " );
        }

        public virtual void Negative()
        {
            double tempbalance = Convert.ToInt32(balance);

            if (tempbalance < 0)
            {
                Console.WriteLine("Warning: Your account has been Overdrafted. The fee is $36.50");
                tempbalance -= -36.50;
            } 
        }



        }
}
