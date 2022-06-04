using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10084661_Task2_Poe
{
    class UserInput
    {
        //global variables
        public static double grossMonthlyIncome , taxDeducted ;

        //public expenses list
        public static List<double> ExpensesList = new List<double>();

        //method --> prompt user to input gross monthly income and tax deducted
        public void inputBasicData()
        {   
            //header
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please enter the following values:");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;

            //prompt user for gross monthly income
            Console.Write("\nEnter your gross monthly income before deductions: R");
            grossMonthlyIncome = Convert.ToDouble(Console.ReadLine());

            //prompt user for monthly tax deducted
            Console.Write("\nEnter your estimated monthly tax deducted costs: R");
            taxDeducted = Convert.ToDouble(Console.ReadLine());
        }

        //method --> prompt user to enter expenses
        public void enterBasicExpenses()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            //formatting/housekeeping
            Console.WriteLine("\n-------------------------------------------------------------------------" +
                "\nPlease enter your estimated monthly expenditures in each of the following categories:");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;

            //prompt user groceries cost
            Console.Write("\nEnter total groceries costs: R");
            ExpensesList.Add(Convert.ToDouble(Console.ReadLine()));

            //prompt user for water and lights cost
            Console.Write("\nEnter total water and lights costs: R");
            ExpensesList.Add(Convert.ToDouble(Console.ReadLine()));

            //prompt user for travel costs
            Console.Write("\nEnter total travel costs(including fuel): R");
            ExpensesList.Add(Convert.ToDouble(Console.ReadLine()));

            //prompt use for phone costs
            Console.Write("\nEnter total cell phone and telephone costs: R");
            ExpensesList.Add(Convert.ToDouble(Console.ReadLine()));

            //prompt user for other costs
            Console.Write("\nEnter total other expenses: R");
            ExpensesList.Add(Convert.ToDouble(Console.ReadLine()));
        }


    }
}
