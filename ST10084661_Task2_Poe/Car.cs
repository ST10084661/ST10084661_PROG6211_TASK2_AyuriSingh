using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10084661_Task2_Poe
{
    class Car
    {
        //global variables
        public static String makeAndModel;
        public static double purchasePrice;
        public static double deposit;
        public static double interestRate;
        public static double insurancePremium;
        public static double carPayments;
        public static int choice;

        //constructor variables
        private string makeAndModel1;
        private double purchasePrice1;
        private double deposit1;
        private double interestRate1;
        private double insurancePremium1;

        //paramiterised constructor
        public Car(string makeAndModel1, double purchasePrice1, double deposit1, double interestRate1, double insurancePremium1)
        {
            this.makeAndModel1 = makeAndModel1;
            this.purchasePrice1 = purchasePrice1;
            this.deposit1 = deposit1;
            this.interestRate1 = interestRate1;
            this.insurancePremium1 = insurancePremium1;
        }

        //method --> calculate monthly cost of purchasing a vehicle
        public double calcMonthlyCost()
        {
            //declarations
            double ct = 0;
            double mc = 0;
            double p;

            p = purchasePrice - deposit; //calculate amount due
            interestRate = interestRate / 100; //get interest rate to right format

            ct = p * (1 + (interestRate * 5));
            mc = ct / 60;
            mc += insurancePremium;

            return mc;
        }

        //method --> prompt user to choose whether to buy a car or continue the program
        public static void buyCar()
        {
            //formatting/housekeeping
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n--------------------------------------------------");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nTransportation: ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            //prompt user to find out if they are choosing to buy a car
            Console.Write("\nWill you be buying a car?\nType '1' if Yes or '2' if No: ");
            choice = Convert.ToInt32(Console.ReadLine());

            //if statement --> prompts user to enter car details if they choose to buy a car
            if (choice == 1)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Blue;

                //prompt user for make and model
                Console.Write("\nEnter the car make and model: ");
                makeAndModel = Console.ReadLine();

                //prompt user for price
                Console.Write("\nEnter full purchase price: ");
                purchasePrice = Convert.ToDouble(Console.ReadLine());

                //prompt user for deposit
                Console.Write("\nEnter the deposit: ");
                deposit = Convert.ToDouble(Console.ReadLine());

                //prompt user for interest rate
                Console.Write("\nEnter the interest rate(format: 8.5% -> 8,5): ");
                interestRate = Convert.ToDouble(Console.ReadLine());

                //prompt user for insurance premium
                Console.Write("\nEnter the estimated insurance premium: ");
                insurancePremium = Convert.ToDouble(Console.ReadLine());

                //create object of car
                Car boughtCar = new Car(makeAndModel, purchasePrice, deposit, interestRate, insurancePremium);

                //calculate car monthly cost
                carPayments = boughtCar.calcMonthlyCost();
             }

            //else if statement --> if user chose not to buy car, carPayments is set to 0
            else if (choice == 2)
            {
                carPayments = 0;
            }

            //else statement -->loop back into method if bad input
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("'" + choice + "' is not a valid selection, please try again.");
                buyCar();
            }
        }
        
        //method --> print car details
        public static void printCar()
        {
            //if statement --> printing out their car details if they chose to buy a car
            if (choice == 1)
            {
                // housekeeping/formatting
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n----------------------------------------");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nCAR DETAILS" );

                //printing out summary of car details
                Console.WriteLine("\nMake and Model of car: " + makeAndModel
                                  + "\n\nPurchase Price of car: R" + purchasePrice
                                  + "\n\nDeposit: R" + deposit
                                  + "\n\nInterest Rate: " + interestRate 
                                  + "\n\nInsurance Premium: R" + insurancePremium);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                //printing out monthly repayments for car and rounding two decimal places
                Console.WriteLine("\nMONTHLY CAR COST: R" + Math.Round(carPayments, 2));
            }

        }
    }
}
