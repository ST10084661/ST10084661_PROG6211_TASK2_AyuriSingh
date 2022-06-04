using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ST10084661_Task2_Poe
{
    public delegate void loadingDelegate(int wait);
    class LoadingScreen
    {
        //method --> pause screen and welcome message
        public static void loadScreen()
        {
            loadingDelegate ld = (wait) =>
            {
                Console.WriteLine("Loading...");
                //loops through counting down from num
                for (int i = wait; i > 0; i--)
                {
                    //outputs number
                    Console.Write(i + "\t ");
                    //pauses for 1 second each loop
                    Thread.Sleep(1000); 
                }
                Console.WriteLine("\n\n\tWelcome to the budget planner app!" +
                    "\n---------------------------------------------------\n");
                //final pause
                Thread.Sleep(1000);
            };
            ld(5);

            
        }
    }
}
