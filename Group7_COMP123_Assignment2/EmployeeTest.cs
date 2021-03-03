using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Group7_COMP123_Assignment2
{
    class EmployeeTest
    {
        static void Main(string[] args)
        {
            //Creation of the First Employee object.
            Employee firstEmployee = new Employee();

            //User's inputs for second Employee Object.
            Write("Please inform employee's First Name: ");
            string fname = ReadLine();

            Write("Please inform employee's Last Name: ");
            string lname = ReadLine();
            
            Write("Please inform employee's Base Salary: ");
            double baseSalary = Convert.ToDouble(ReadLine());

            bool testVar = false;
            double grossSales = 0;
            double commissionRate = 0;
            while (!testVar)
            {
                try
                {
                    Write("Please inform employee's Gross Sales: ");
                    grossSales = Convert.ToDouble(ReadLine());
                    while (grossSales <= 0)
                    {
                        Write("Gross Sales cannot be negative. Please enter a valid amount: ");
                        grossSales = Convert.ToDouble(ReadLine());
                    }

                    Write("Please inform employee's Commission Rate between 0.1 and 1.0: ");
                    commissionRate = Convert.ToDouble(ReadLine());
                    while (commissionRate < 0.1 || commissionRate > 1.0)
                    {
                        Write("Please enter a number between 0.1 and 1.0: ");
                        commissionRate = Convert.ToDouble(ReadLine());
                    }

                    testVar = true;
                }
                catch (Exception e)
                {
                    WriteLine($"\nError: {e.Message}\n");
                }

            }

           

            //Create Second Employee object and assign values to fields.
            Employee secondEmployee = new Employee(10, fname, baseSalary);
            secondEmployee.CommissionRate = commissionRate;
            secondEmployee.GrossSales = grossSales;
            secondEmployee.LastName = lname;

            //Calculate total Earnings.
            double earnings = secondEmployee.Earnings();

            //Output Employee's basic information and total earnings.
            WriteLine($"\nEmployee {secondEmployee.LastName}, {secondEmployee.FirstName}, ID# {secondEmployee.EmployeeUserId}" +
                $" has total earnings of {earnings:c}");

            //GithubTest


        }
    }
}
