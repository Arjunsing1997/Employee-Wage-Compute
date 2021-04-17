using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Compute
{
    class EmployeeBuilder
    {
        public const int FullTime = 1;                                        //creating a local variable
        public const int PartTime = 2;

        //private global variables
        private string company;
        private int empRatePerHours;
        private int numOfWorkingDays;
        private int maxHrsPerMonth;
        private int totalEmpWage;
        public EmployeeBuilder(string company, int empRatePerHours, int numOfWorkingDays, int maxHrsPerMonth)
        {
            this.company = company;
            this.empRatePerHours = empRatePerHours;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrsPerMonth = maxHrsPerMonth;
        }

        public void ComputeWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

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
            Console.WriteLine("Total Employee wage for Company : " + company + " is: " + totalEmpWage);
        }

        public string toString()
        {
            return "Total Emp Wage for Company: " + this.company + " is: " + this.totalEmpWage;
        }
    }
}