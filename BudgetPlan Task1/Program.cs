/*@auther:
 * Student Number: 18013284
 * Group Number: group 4
 * Mobile Number: 0788329684
 * Date of last Edit: 12 May 2021
 */


using System;


namespace BudgetPlan_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Expenses income = new Expenses();
            Vehicle car = new Vehicle();
            House house = new House();

            //Getting the user name and surname 
            Console.WriteLine("Hey User, Can you please enter your Name: ");
            person.Name = Console.ReadLine();

            Console.WriteLine("Can you please enter your Surname: ");
            person.Surname = Console.ReadLine();
            //creating an array
            int number = 10;
            double [] incomes;
            incomes = new double[number];



            //Greating the user and prompting the user for income and monthly expenses
                Console.WriteLine("\n*******************************" +
                               "\n   Welcome " + person.Name + " " + person.Surname +
                               "\n*******************************");
                 Console.WriteLine("Can you please enter your monthly income before deduction: ");
                income.GrossMonthlyIncome = Convert.ToDouble(Console.ReadLine());// converting the value entered by the user to double 


                 Console.WriteLine("Can you enter your monthly tax: ");
                 income.Tax = Convert.ToDouble(Console.ReadLine());// converting the value entered by the user to double 


            Console.WriteLine("Can you enter the amount spent on Groceries: ");
                income.Grocery = Convert.ToDouble(Console.ReadLine());// converting the value entered by the user to double 


            Console.WriteLine("Can you enter the amount spent on Water and Light: ");
                income.WaterAndLight = Convert.ToDouble(Console.ReadLine());// converting the value entered by the user to double 


            Console.WriteLine("What is your Travel Cost per Month? ");
                income.Travel = Convert.ToDouble(Console.ReadLine());// converting the value entered by the user to double 



            Console.WriteLine("Can you enter the amount spent on Cell phone and Telephone: ");
                income.Phones = Convert.ToDouble(Console.ReadLine());// converting the value entered by the user to double 


            Console.WriteLine("Can you enter the amount spent on Other expenses: ");
                income.Other = Convert.ToDouble(Console.ReadLine());// converting the value entered by the user to double 
             
            //storing values in an array
                
                incomes[0] = income.Tax;
                incomes[1] = income.Grocery;
                incomes[2] = income.WaterAndLight;
                incomes[3] = income.Travel;
                incomes[4] = income.Phones;
                incomes[5] = income.Other;

            

            //calculating the sum of the values
            double sub = incomes[0] - incomes[1] - incomes[2] - incomes[3] - incomes[4] - incomes[5] - incomes[6];
            double sum =   incomes[1] + incomes[2] + incomes[3] + incomes[4] + incomes[5] + incomes[6];
            //prompting the user to choose between buying and renting
            Console.WriteLine("Are you Renting or Buying the property? \npress '1' for renting and 2 for buying");
            int propertyValue = Convert.ToInt32(Console.ReadLine());

            

            if(propertyValue == 1)
            {
                Console.WriteLine("****************************" +
                             "\n        Renting the House" +
                              "\n****************************");
                //prompting the user for monthly payment
                Console.WriteLine("Can you please Enter the Monthly Rental Amount");
                double rentalAmount = Convert.ToDouble(Console.ReadLine());
                
                //calculating the available Amount
                double availableAmount = sum - rentalAmount;
                incomes[6] = rentalAmount;

                //Displaying the available amount
                Console.WriteLine("The available Amount is: R" +availableAmount);
                Console.WriteLine("*************************" +
                                          "\n  THANK YOU!!!!!" +
                                          "\n*************************");


            }
            else if(propertyValue== 2)
            {
                Console.WriteLine("****************************" +
                              "\n        Buying the House" +
                               "\n*****************************");

                //declaring variables for buying the property
                double purchasePrice, totalDeposite;
                double interestRate;
                int numberOfMonths;

                //prompting the user for the values
                Console.WriteLine("Can you please enter the purchase price");
                purchasePrice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Can you please enter the deposite");
                totalDeposite = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Can you please enter the interest in percentage");              
                interestRate = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Can you please enter the number of months");            
                numberOfMonths = Convert.ToInt32(Console.ReadLine());


                if(numberOfMonths >=250 && numberOfMonths <= 360)
                {
                    //calculating number of years
                    double years = numberOfMonths / 12;

                    //calculating the interest rate
                    double rate = interestRate / 100;

                    //calculating principle value

                    double principle = purchasePrice - totalDeposite;

                    //calculating monthly payments
                    double monthylpayments = (principle * (1 + rate * years));
                    double payment = monthylpayments / numberOfMonths ;

                    house.monthlyPayment = payment;
                    incomes[6] = house.monthlyPayment;

                    Console.WriteLine("\nMonthly Payments: R" + payment);

                    double third = income.GrossMonthlyIncome / 3;

                    if (payment > third)
                    {
                        Console.WriteLine("you don not qualify for the home load");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("The tolal of all expenses is: R" + sum);
                        
                        double availableAmount = sum - payment;
                        Console.WriteLine("\nThe available Amount is: R" + availableAmount);
                        Console.WriteLine("*************************" +
                                           "\n  THANK YOU!!!!!" +
                                           "\n*************************");
                       
                    }
                }
                else
                {
                    //error message
                    Console.WriteLine("number of payments must be between 240 and 360!!");
                    Console.WriteLine("Can you please enter the number of months");
                    numberOfMonths = Convert.ToInt32(Console.ReadLine());

                    //reapiting the same proccess
                    if (numberOfMonths >= 250 && numberOfMonths <= 360)
                    {
                     //calculating number of years
                    double years = numberOfMonths / 12;

                        //calculating the interest rate
                        double rate = interestRate / 100;


                        //calculating principle value

                        double principle = purchasePrice - totalDeposite;

                        //calculating monthly payments
                        double monthylpayments = (principle * (1 + rate * years));
                        double payment = monthylpayments / numberOfMonths;

                        Console.WriteLine("\n Monthly Payments: R" + payment);

                        double third = income.GrossMonthlyIncome / 3;

                        if (payment > third)
                        {
                            Console.WriteLine("you don not qualify for the home load");
                            Console.ReadKey();
                        }
                        else
                        {

                            Console.WriteLine("The tolal of all is: R" + sum);
                            Console.WriteLine("Monthly payments : R" + payment);
                            double availableAmount = sum - payment;
                            Console.WriteLine("\nThe available Amount is: R" + availableAmount);
                            Console.WriteLine("*************************" +
                                               "\n  THANK YOU!!!!!" +
                                               "\n*************************");

                        }


                    }
                    else
                    {
                        Console.WriteLine("program has eneded!!!!!!");
                    }
                }

               

            }

            // buying a vehicle



            Console.WriteLine("Do you want to buy a vehicle? " +
                "\nPress 1 for yes and 2 for no");
            int response = int.Parse(Console.ReadLine());
            if (response == 1)
            {


                Console.WriteLine("****************************" +
                             "\n        Buying a Car "
                              + "\n*****************************");


                Console.WriteLine("Enter the Model or make");
                car.model = Console.ReadLine();
                Console.WriteLine("Enter the Purchase Price");
                car.purchasePrice = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Total Deposit");
                car.totalDeposit = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Interest Rate");
                car.interestRate = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Estimated insurance premium");
                car.insurancePremium = double.Parse(Console.ReadLine());

                int years = 5;
                double months = years * 12;


                double rate = car.interestRate / 100;

                double principle = car.purchasePrice - car.totalDeposit;

               double payments = (principle * (1 + rate * years));


                double monthlyPayments = payments / months;

                car.monthlyPayments = monthlyPayments + car.insurancePremium;

                incomes[7] = car.monthlyPayments;
                Console.WriteLine("\n************************" +
                    "\n         Car" +
                    "\n*************************");
                Console.WriteLine("\nModel of the Car: " + car.model);

                Console.WriteLine("Payments excluding insurance is R" + monthlyPayments);

                Console.WriteLine("Monthly Payments for the car incuding insurance is: R" + car.monthlyPayments);



                
            }
            else if (response == 2) { 
            
            }

            double totalExpense = sum + house.monthlyPayment + car.monthlyPayments;

            double perc = (income.GrossMonthlyIncome / 100) * 75;
            if(totalExpense > perc)
            {
                Console.WriteLine("the total Expenses exceed 75% of your income");
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine(incomes[i]);
                }
            }
            else
            {
                for(int i = 0; i < number; i++)
                {
                    for(int j=i; j < number; j++)
                    {
                        if(incomes[i] < incomes[j])
                        {
                            double temp = incomes[i];
                            incomes[i] = incomes[j];
                            incomes[j] = temp;
                        }
                    }
                    Console.WriteLine( "\nExpenses in descending order:");
                    Console.WriteLine(incomes[i]);
                }
            }



                




            Console.ReadKey();

        }

        


    }
}
