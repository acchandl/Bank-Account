using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class SavingsAccount : BankAccount1
    {

        //fields

        public double savingsBalance;
        public double savingsDeposits;
        public double savingsWithdraw;



        //properties
        public double SavingsBalance
        {

            get { return this.savingsBalance; }
            set { this.SavingsBalance = value; }
        }


        public double SavingsDeposit
        {
            get { return this.savingsDeposits; }
            set { this.SavingsDeposit = value; }
        }

        public double SavingsWithdraw
        {
            get { return this.savingsWithdraw; }
            set { this.SavingsWithdraw = value; }
        }


        public override void Negative()
        {
            double tempsavingsBalance = Convert.ToInt32(savingsBalance);

            if (tempsavingsBalance < 0)
            {
                Console.WriteLine("Warning: Your Savings Account has been Overdrafted. The fee is $36.50");
                tempsavingsBalance -= -36.50;
            }
        }



        //constructor

        public SavingsAccount()
        {
        
            this.savingsBalance = 45732.66;
            this.savingsDeposits = 0;
            this.savingsWithdraw = 0;

           
        }



    }
}
