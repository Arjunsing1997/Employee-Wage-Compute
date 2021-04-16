using System;

namespace Employee_Wage_Compute
{
    class Program
    {

        const int FullTime = 1;                                        //creating a local variable
        const int PartTime = 2;
        public const int maxWorkingDays = 20;
        public const int empRatePerHour = 20;
        public const int maxWorkingHours = 100;
        static int empHrs = 0;
        static int empWage = 0;
        static int workingDays = 1;
        static int totalEmpWage = 0;
        static int totalHrs = 0;
       static  Random random = new Random();                           //Generating Random value
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage Calculation....");
 
            while (totalHrs < maxWorkingHours && workingDays < maxWorkingDays)
            {
                workingDays++;                    
                EmployeeStatus();                                           //calling method
                CalculateWage();                                //calling method to calculate wage
            } 

            Console.WriteLine("Employee wage for" +workingDays+ " day: " +totalEmpWage);
            Console.WriteLine("Working Hours: " + totalHrs);
        }

        public static void EmployeeStatus()
        {
            int employeeCheck = random.Next(0, 3);                      // assigning Random value to the variable 

            switch (employeeCheck)                                          //USING SWITCH STATEMENT
            {
                case FullTime:
                    empHrs = 8;
                    break;

                case PartTime:
                    empHrs = 4;
                    break;

                default:
                    empHrs = 0;
                    break;
            }
        }
        public static void CalculateWage()
        {
            empWage = empRatePerHour * empHrs; //calculating Employee wage
            totalHrs = totalHrs + empHrs; //calculting emp hours
            totalEmpWage += empWage; //calculating emp total wage

        }
    }
}
