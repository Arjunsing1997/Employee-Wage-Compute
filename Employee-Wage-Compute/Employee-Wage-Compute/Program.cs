using System;

namespace Employee_Wage_Compute
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage Calculation....");
            EmployeeBuilder Dmart = new EmployeeBuilder("Dmart", 20, 4, 10);  //company name, emp rate per hour,max days,max hours
            EmployeeBuilder Reliance = new EmployeeBuilder("Reliance", 10, 4, 20);
            Dmart.ComputeWage();
            Console.WriteLine(Dmart.toString());
            Reliance.ComputeWage();
            Console.WriteLine(Reliance.toString());
        }
    }
}