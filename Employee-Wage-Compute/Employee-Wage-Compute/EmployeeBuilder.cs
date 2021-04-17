using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Compute
{
    public class EmployeeBuilder
    {
        public const int FullTime = 1;                                        //creating a local variable
        public const int PartTime = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] CompanyEmpWageArray;

        public EmployeeBuilder()
        {
            this.CompanyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(string company, int empRatePerHours, int numOfWorkingDays, int maxHrsPerMonth)
        {
            CompanyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHours, numOfWorkingDays, maxHrsPerMonth);
            numOfCompany++;
        }


        public void ComputeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                CompanyEmpWageArray[i].setTotalEmpWage(this.ComputeEmpWage(this.CompanyEmpWageArray[i]));
                Console.WriteLine(this.CompanyEmpWageArray[i].toString());

            }
        }
        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs < companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
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
                Console.WriteLine("Days: " + totalWorkingDays + " Emp Hours: " + empHrs);

            } //END of WHILE LOOP

            return totalEmpHrs * companyEmpWage.empRatePerHours;
        }
    }
}