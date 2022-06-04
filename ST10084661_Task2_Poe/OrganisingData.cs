using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10084661_Task2_Poe
{
    class OraganisingData
    {
        //get and set for typeacc
        public static int typeAcc { get; set; }

        //method --> prompt user to either buy a house or rent property
        public  void rentOrBuy()
        {
            //Object of class --> Rent
            Rent rn = new Rent();

            //object of class --> HomeLoan
            HomeLoan hl = new HomeLoan();

            //formatting/housekeeping
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n--------------------------------------------------" +
                "\n\nAccomodation:");

            //prompt user to find out if they would like to buy a property or rent
            Console.Write("\nWill you be renting or buying a property?\nEnter '1' for Renting or '2' for Buying: ");
            typeAcc = Convert.ToInt32(Console.ReadLine());


            //if statement which depends on users choice
            if (typeAcc == 1)
            {  
                //method from rent
                rn.monthlyRepayments();
            }
            else if (typeAcc == 2)
            {
                //method from home loan
                hl.monthlyRepayments();
            }
            else
            {
                //loop back into method if bad input
                Console.WriteLine("'" + typeAcc + "' is not a valid selection, please try again.");
                rentOrBuy();
            }
        }

        //method --> method to notify user if their total expenses and loan repayments exceed 75% of their income
        public void notifyUser()
        {
            //declarations
            double totalOwed;
            double netIncome;

                      //expenses + house payement (either monthly rent or home loan) +  monthly car payments
            totalOwed = UserInput.ExpensesList.Sum() + Expenses.housePayment + Car.carPayments; 

                     //expenses - tax deducted - totalowed
            netIncome = UserInput.grossMonthlyIncome - UserInput.taxDeducted - totalOwed;

            if (totalOwed >= (netIncome * 0.75))
            {   
                //housekeeping/formatting
                Console.WriteLine(" ");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor= ConsoleColor.Red;
                //printing out if expenses and loan repayments exceed 75% of income
                Console.WriteLine("ALERT: Your total expenses and loan repayments exceed 75% of your income!");
                Console.WriteLine("\n---------------------------------------------------------------\n");
            }
        }

    }
}
