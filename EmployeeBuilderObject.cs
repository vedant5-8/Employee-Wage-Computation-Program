using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation_Program
{
    public class EmployeeBuilderObject
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmployeeBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void ComputeEmpWage()
        {
            int empHours = 0;
            int totalEmpHours = 0;
            int totalWorkingDays = 0;

            while (totalEmpHours <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(1, 4);

                switch (empCheck)
                {
                    case isFullTime:
                        empHours = 8;
                        break;
                    case isPartTime:
                        empHours = 4;
                        break;
                    default:
                        empHours = 0;
                        break;
                }

                totalEmpHours += empHours;
                Console.WriteLine("Day: " + totalWorkingDays + " Emp Hours: " + empHours);
            }

            totalEmpWage = totalEmpHours * empRatePerHour;
            // Console.WriteLine("Total employee wage for company: " + company + " is " + totalEmpWage);

        }

        public string toString()
        {
            return "Total employee wage for company: " + this.company + " is " + this.totalEmpWage + "\n";
        }

    }
}
