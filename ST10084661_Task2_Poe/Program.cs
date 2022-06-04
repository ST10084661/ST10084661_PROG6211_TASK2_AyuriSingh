using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10084661_Task2_Poe
{
    //notify user delegate
    public delegate void notifyUserDelegate();

    //final available money delegate
    public delegate void FinalAvailableMoneyDelegate();
    class Program
    {
       static void Main(string[] args)
        {
            while (true)
            {
                //object of the class --> Organisingdata
                OraganisingData od = new OraganisingData();

                //object of the class --> DisplayExpenses
                DisplayExpenses de = new DisplayExpenses();

                //object of the class --> FinalAvailableMoney
                FinalAvailableMoney fa = new FinalAvailableMoney();

                //object of the class --> UserInput
                UserInput ui = new UserInput();

                //instantiate delegate
                notifyUserDelegate ud = new notifyUserDelegate(od.notifyUser);

                //instantiate delegate
                FinalAvailableMoneyDelegate fam = new FinalAvailableMoneyDelegate(fa.FinalAvailableMonthlyMoney);

                //calling Loading Screen method from --> LoadingScreen Class
                LoadingScreen.loadScreen();

                //calling inputBasicData method from --> UserInput Class
                ui.inputBasicData();

                //calling enterBasicExpenses method from --> UserInput Class
                ui.enterBasicExpenses();

               //calling rentOrBuy method from --> OrganisingData CLass
                od.rentOrBuy();  
                
                //calling buyCar method from --> Car Class
                Car.buyCar();               
                                             
                //calling dsiplayExpenses method from --> DisplayExpenses Class
                de.displayExpenses();

                //calling RentOrHomeLoanPrint method from --> DisplayExpenses Class
                de.RentOrHomeLoanPrint();

                //calling printCar method from --> Car Class
                Car.printCar();

                //calling finalAvailableMonthlyMoney method from --> FinalAvailableMoney Class
                fam();

                //calling notifyUser method from --> OrganisingData class
                ud();

                //code to prompt user to either exit the program or restart the program 
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\nThank you for you using the budget Planner Application!! " +
                                  "\n\nPress 1 to exit the application or any other number to restart the program");
                int value = Convert.ToInt32(Console.ReadLine());

                //if statement --> if user chose to exit application
                if (value == 1)
                {
                    //exit program
                    System.Environment.Exit(0);
                }

                //else statement --> user chose to restart application
                else
                {
                    //calling Clear method from --> ClearAll class
                    ClearAll.Clear();
                    Console.WriteLine("\n");
                    continue;
                }
                
                //keep console open
                Console.ReadLine();           
      
            }
        }
    }


}

    

