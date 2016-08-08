using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class CheckingAccount : BankAccount1
    {
        //fields
        public double checkingBalance;
        public double checkingDeposit;
        public double checkingWithdraw;


        //Properties

        public double CheckingBalance
        {

            get { return this.checkingBalance; }
            set { this.CheckingBalance = value; }
        }


        public double CheckingDeposit
        {
            get { return this.checkingDeposit; }
            set { this.CheckingDeposit = value; }
        }

        public double CheckingWithdraw
        {
            get { return this.checkingWithdraw; }
            set { this.CheckingWithdraw = value; }
        }



        public override void Negative()
        {
            double tempcheckingBalance = Convert.ToInt32(checkingBalance);

            if (tempcheckingBalance < 0)
            {
                Console.WriteLine("Warning: Your Checking Account has been Overdrafted. The fee is $36.50");
                tempcheckingBalance -= -36.50;
            }
        }

        //constructors

        public CheckingAccount()
        {

            this.checkingBalance = 2500.33;
            this.checkingDeposit = 0;
            this.checkingWithdraw = 0;
        }

      



    }
}
