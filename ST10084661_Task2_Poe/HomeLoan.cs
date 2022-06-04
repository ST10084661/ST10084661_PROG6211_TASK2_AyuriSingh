using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10084661_Task2_Poe
{
    class HomeLoan : Expenses
    {
        //global variables
        public double purchasePrice;
        public double deposit;
        public double intRate;
        public double repayMonths;
        public double homeLoanRepayments = 0;

        //default constructor
        public HomeLoan()
        {

        }

        //method --> method to calculate monthly repayments
        public override void monthlyRepayments()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;

            //prompts user for purchase price of property 
            Console.Write("\nPlease enter the purchase price of the property: R");
            purchasePrice = Convert.ToDouble(Console.ReadLine());

            //prompts for deposit
            Console.Write("\nPlease enter your deposit: R");
            deposit = Convert.ToDouble(Console.ReadLine());

            //prompts user for interest
            Console.Write("\nPlease Enter the interest rate(format: 8.5% -> 8,5): ");
            intRate = Convert.ToDouble(Console.ReadLine());

            //While loop to keep repeating if the user does not give an appropriate input
            while (true)
            {
                //prompt user for months to repay
                Console.Write("\nPlease enter the number of months to repay (between 240 months and 360 months): ");
                repayMonths = Int32.Parse(Console.ReadLine());
                if (repayMonths >= 240 && repayMonths <= 360)
                {
                    break;
                }
            }

            //declaration of variables
            double principleAmount;
            double years;
            double totalOwed;

            //calculation using compound interest formula. For more information on compound interes, see References in ReadMe File
            principleAmount = purchasePrice - deposit;  //calculates amount due
            intRate = intRate / 100;  //converts percentage to decimal
            years = repayMonths / 12; //calculates amount of months to repay

            totalOwed = principleAmount * (1 + (intRate * years)); //Compound Interest Formula

            homeLoanRepayments = totalOwed / repayMonths;//monthly repayment formula
            homeLoanRepayments = Math.Round(homeLoanRepayments, 2); //round off to 2 decimals

            housePayment = homeLoanRepayments;
        }

        //method --> print home loan accommodation costs
        public void HomeLoanPrint()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            //printing out the total accommodation costs
            Console.WriteLine( "\n-----------------------------------------------" 
                             + "\nYour monthly home loan repayments are: R" 
                             + Math.Round(housePayment, 2)); //round off to two decimals
        }

        //method to check that the likeliness that the loan will be approved
        public void checkApproval()
        {

            if ((UserInput.grossMonthlyIncome / 3) < housePayment) 
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                //prints if loon is unlikely to be approved
                Console.WriteLine("\nALERT: It is unlikely that this home loan will be approved!");
                
            }

        }
    }
}

