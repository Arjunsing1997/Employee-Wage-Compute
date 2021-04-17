using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Compute
{
    public class CompanyEmpWage
    {
        public string company;
        public int empRatePerHours;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHours, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHours = empRatePerHours;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string toString()
        {
            return "Total Emp Wage for company : " + this.company + " is: " + this.totalEmpWage;
        }
    }
}
