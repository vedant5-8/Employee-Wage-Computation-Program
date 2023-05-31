using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation_Program
{
    internal class EmpWageForMultipleCompanies
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;

        public static void computeEmployeeWage(string company, int empRatePerHour, int noOfWorkingDays, int maxHoursPerMonth)
        {

            int empHours = 0;
            int totalEmpHours = 0;
            int totalWorkingDays = 0;

            while (totalEmpHours <= maxHoursPerMonth && totalWorkingDays < noOfWorkingDays)
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

            int totalEmpWage = totalEmpHours * empRatePerHour;
            Console.WriteLine("Total employee wage for company: " + company + " is " + totalEmpWage);

        }
    }
}
