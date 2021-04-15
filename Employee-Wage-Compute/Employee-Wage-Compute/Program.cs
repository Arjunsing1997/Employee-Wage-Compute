using System;

namespace Employee_Wage_Compute
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage Calculation....");

            int Present = 1;
            Random random = new Random();
            int EmpCheck = random.Next(0, 2);
            Console.WriteLine("EmpCheck: " + EmpCheck);

            if (EmpCheck == Present)
            {
                Console.WriteLine("Employee PRESENT");
            }
            else
            {
                Console.WriteLine("Employee ABSENT");
            }
            Console.Read();
        }
    }
}
