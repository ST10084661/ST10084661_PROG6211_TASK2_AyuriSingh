using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ST10084661_Task2_Poe
{
    class DisplayExpenses
    {
        //method --> display expenses in descending order
        public void displayExpenses()
        {
            //formatting/housekeeping
            Thread.Sleep(500);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n-------------------------" 
                              + "\n\nEXPENSES:\n ");

            //foreach to output expenses ordered in descending order
            int count = 1;
            foreach (double d in UserInput.ExpensesList.OrderByDescending(d => d))
            {
                Console.WriteLine(count + ": R" + d.ToString("F"));

                //housekeeping/formatting
                Console.WriteLine("--------------------");
                count++;
            }
        }

        //method --> if else statement for printing either rent amount or home loan amount
        public  void RentOrHomeLoanPrint()
        {
            //object of Rent class
            Rent rn = new Rent();

            //object of Home Loan class
            HomeLoan hl = new HomeLoan();

            if (OraganisingData.typeAcc == 1)
            {
                //printing rent accommodation costs
                rn.rentPrint();
            }

            else if(OraganisingData.typeAcc == 2)
            {
                //printing home loan accommodation costs
                hl.HomeLoanPrint();
                hl.checkApproval();
            }
        }
    }
}
