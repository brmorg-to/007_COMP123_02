using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group7_COMP123_Assignment2
{
    class Employee
    {
        //Declare Fields
        private int employeeUserId;
        private string firstName;
        private string lastName;
        private double basicSalary = 2_000.00;
        private double grossSales;
        private double commissionRate = 0.2;

        //Declare Properties
        public int EmployeeUserId { get { return employeeUserId; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public double BasicSalary { get { return basicSalary; } set { basicSalary = value; } } 
        public double GrossSales { get { return grossSales; } set { grossSales = value; } }
        public double CommissionRate { get { return commissionRate; } set { commissionRate = value; } }

        //Build Methods

        #region Earnings Method
        public double Earnings()
        {
            return (CommissionRate * GrossSales) + BasicSalary;
        }
        #endregion

        #region Employee Constructors
        public Employee() {}
        
        public Employee(int employeeUserId,string firstName, double basicSalary)
        {
            this.employeeUserId = employeeUserId;
            this.firstName = firstName;
            this.basicSalary = basicSalary;

        }

        #endregion

    }
}
