using System;

namespace Employee_Wage_Compute
{
    class Program
    {

        public const int FullTime = 1;                                        //creating a local variable
        public const int PartTime = 2;
        public static int ComputeWage(string company, int empRatePerHours, int numOfWorkingDays, int maxHrsPerMonth)
        {
            //Local Variables
            int empHrs = 0, totalWorkingDays = 1, totalEmpHrs = 0; 

                                       //Generating Random value
            while (totalEmpHrs < maxHrsPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;

                Random random = new Random();
                int empCheck = random.Next(0, 3);                      // assigning Random value to the variable 

                //USING SWITCH STATEMENT
                switch (empCheck)
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
                totalEmpHrs += empHrs; //calculting emp hours
                Console.WriteLine("Days#: " + totalWorkingDays + " Emp Hours: " + empHrs);
                
            } //END of WHILE LOOP

           int totalEmpWage = totalEmpHrs * empRatePerHours;     //calculating emp total wage
            Console.WriteLine("Total Employee wage for Company : " + company+ " is: " + totalEmpWage);
            return totalEmpWage;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage Calculation....");
            ComputeWage("Dmart",20,2,10);
            ComputeWage("Reliance", 10, 4, 20);
        }
    }
}
