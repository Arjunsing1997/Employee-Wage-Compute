using System;

namespace Employee_Wage_Compute
{
    class Program
    {
<<<<<<< HEAD
        const int FullTime = 1;                                        //creating a local variable
        const int PartTime = 2;
        public const int maxWorkingDays = 20;
        public const int empRatePerHour = 20;
        public const int maxWorkingHours = 100;
        static void ComputeWage()
        {
            //Local Variables
            int empHrs = 0, empWage = 0, workingDays = 1, totalEmpWage = 0, totalHrs = 0;

            Random random = new Random();                           //Generating Random value
            while (totalHrs < maxWorkingHours && workingDays < maxWorkingDays)
            {
                workingDays++;
                int employeeCheck = random.Next(0, 3);                      // assigning Random value to the variable 

                //USING SWITCH STATEMENT
                switch (employeeCheck)
=======
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
>>>>>>> UC8-Multi-Company-Wage
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
<<<<<<< HEAD
                empWage = empRatePerHour * empHrs;
                totalHrs += empHrs; //calculting emp hours
                totalEmpWage += empWage; //calculating emp total wage
            } //END of WHILE LOOP

            Console.WriteLine("Employee wage for" + workingDays + " day: " + totalEmpWage);
            Console.WriteLine("Working Hours: " + totalHrs);
            //Console.Read();
=======
                totalEmpHrs += empHrs; //calculting emp hours
                Console.WriteLine("Days#: " + totalWorkingDays + " Emp Hours: " + empHrs);
                
            } //END of WHILE LOOP

           int totalEmpWage = totalEmpHrs * empRatePerHours;     //calculating emp total wage
            Console.WriteLine("Total Employee wage for Company : " + company+ " is: " + totalEmpWage);
            return totalEmpWage;
>>>>>>> UC8-Multi-Company-Wage
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage Calculation....");
<<<<<<< HEAD
            ComputeWage();
=======
            ComputeWage("Dmart",20,2,10);
            ComputeWage("Reliance", 10, 4, 20);
>>>>>>> UC8-Multi-Company-Wage
        }
    }
}