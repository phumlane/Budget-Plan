using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlan_Task1
{
    class Expenses
    {
        // Declaration of variables
        double GMI = 0.0;// Gross Monthly Income variable
        double monthlyTax = 0.0;// Monthly Tax dection Variable
        double groceries, waterAndLight, travelCost, cellPhoneAndTelephone;// monthly expenditures
        double other = 0.0;//Other expenses variable

        public double GrossMonthlyIncome { get; set; }
       
        public double Tax { get; set; }

        public double Grocery { get; set; }

        public double WaterAndLight { get; set; }

        public double Travel { get; set; }

        public double Phones { get; set; }

        public double Other { get; set; }


    }
}
