using System;

namespace Employee_Wage_Compute
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage Calculation....");
            EmployeeBuilder employeeBuilder = new EmployeeBuilder();
            employeeBuilder.addCompanyEmpWage("Dmart", 20, 2, 10);
            employeeBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            employeeBuilder.ComputeEmpWage();
        }
    }
}