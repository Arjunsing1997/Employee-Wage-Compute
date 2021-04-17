using System;

namespace Employee_Wage_Compute
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage Calculation....");
            EmployeeBuilder employeeBuilder = new EmployeeBuilder();
            employeeBuilder.addCompanyEmpWage("Dmart", 20, 5, 10);
            employeeBuilder.addCompanyEmpWage("Reliance", 10, 5, 20);
            employeeBuilder.ComputeEmpWage();
        }
    }
}