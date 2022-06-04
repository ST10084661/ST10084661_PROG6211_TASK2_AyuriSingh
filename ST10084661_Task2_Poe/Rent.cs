using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10084661_Task2_Poe
{    class Rent : Expenses
    {
        //global variable
        public double rentAmount;

        //default constructor
        public Rent()
        {

        }

        //method --> set monthly repayments
        public override void monthlyRepayments()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            //prompting user to enter rental amount
            Console.Write("\nEnter the monthly rental amount: ");
            rentAmount = Convert.ToDouble(Console.ReadLine());
            housePayment = rentAmount;        
        }

        //method --> print rent accommodation costs
        public void rentPrint()
        {
            // housekeeping/formatting
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n----------------------------------------");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            //printing out the total accommodation costs
            Console.WriteLine("\nYour Accommodation Costs: R" + housePayment);       
        }
    }
}
