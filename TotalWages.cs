using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation_Program
{
    public class TotalWages
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public const int empWagePerHour = 20;
        public const int numberOfWorkingDays = 2;
        public const int maxHoursInMonth = 10;
        public static void CalculateTotalWages()
        {
            int empHours = 0;
            int totalEmpHours = 0;
            int totalWorkingDays = 0;

            while (totalEmpHours <= maxHoursInMonth && totalWorkingDays < numberOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int CheckEmployee = random.Next(0, 3);

                switch (CheckEmployee)
                {
                    case isPartTime:
                        empHours = 4;
                        break;
                    case isFullTime:
                        empHours = 8;
                        break;
                    default:
                        empHours = 0;
                        break;
                }

                totalEmpHours += empHours;
                Console.WriteLine("Days: " + totalWorkingDays + " Employee Hours: " + empHours);
            }

            int totalEmpWage = totalEmpHours * empWagePerHour;
            Console.WriteLine("Total employee wage is " + totalEmpWage);
        }
    }
}
