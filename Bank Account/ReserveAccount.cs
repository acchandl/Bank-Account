using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class ReserveAccount : BankAccount1
    {

        //fields

        public double reserveBalance;
        public double reserveDeposit;
        public double reserveWithdraw;
       
        
        //properties
     
        public double ReserveBalance
        { 

            get { return this.reserveBalance; }
            set { this.reserveBalance = value; }
        }


        public double ReserveDeposit
        {
            get { return this.reserveDeposit; }
            set { this.reserveDeposit = value; }
        }

        public double ReserveWithdraw
        {
            get { return this.reserveWithdraw; }
            set { this.ReserveWithdraw = value; }
        }

        public override void Negative()
        {
            double tempreserveBalance = Convert.ToInt32(reserveBalance);

            if (tempreserveBalance < 0)
            {
                Console.WriteLine("Warning: Your Reserve Account has been Overdrafted. The fee is $36.50");
                tempreserveBalance -= -36.50;
            }
        }



        //constructors

        public ReserveAccount()
        {
            this.reserveBalance = 23000.00;
            this.reserveDeposit = 0;
            this.reserveWithdraw = 0;
        }



    }
}
