using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ST10084661_Task2_Poe
{
    class FinalAvailableMoney
    {
        //global variable
        public static double finalAvailableMoney;

        //method --> calculate final available money for a month
        public void FinalAvailableMonthlyMoney()
        {

            //formatting/housekeeping
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n--------------------------------------------------");

            {
                //calculation: gross monthly income - tax deducted - Expenses - house payment(either rent amount or monthly home loan amount - car payments)
                finalAvailableMoney = UserInput.grossMonthlyIncome - UserInput.taxDeducted - UserInput.ExpensesList.Sum() - Expenses.housePayment - Car.carPayments;

                //returns final amount
                Console.WriteLine("After all deductions you will have: R" + finalAvailableMoney.ToString("F")
                + "\n\n--------------------------------------------------------------");
            }; 
        }
    }
}
