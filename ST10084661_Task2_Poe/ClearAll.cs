using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10084661_Task2_Poe
{
    class ClearAll
    {
        //method --> clear all values
        public static void Clear()
        {
            //Clear all values and set them to null in UserInput
            UserInput.grossMonthlyIncome = 0;
            UserInput.taxDeducted = 0;
            UserInput.ExpensesList.Clear();

            //Clear all values and set them to 0 in Car
            Car.makeAndModel = null;
            Car.purchasePrice = 0;
            Car.deposit = 0;
            Car.interestRate = 0;
            Car.insurancePremium = 0;
            Car.carPayments = 0;

            //Clear all values and set them to null in Rent
            Rent.housePayment = 0;

            //Clear all values and set them to null in HomeLoan
            HomeLoan.housePayment = 0;

            //Clear all values and set them to null in FinalAvailableMoney
            FinalAvailableMoney.finalAvailableMoney = 0;

            //Clear all values and set them to null in OrganisingData
            OraganisingData.typeAcc = 0;

        }
    }
}
