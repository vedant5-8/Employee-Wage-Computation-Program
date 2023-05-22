using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation_Program
{
    public class MonthlyEmployeeWage
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public const int empWagePerHour = 20;
        public static void CalculateMonthlyEmployeeWage()
        {
            int workingDaysPerMonth = 20;
            int empHours;
            int empWage;

            Random random = new();
            int checkAttendance = random.Next(0, 3);

            switch (checkAttendance)
            {
                case isPartTime:
                    Console.WriteLine("Part time employee is present.");
                    empHours = 4;
                    break;
                case isFullTime:
                    Console.WriteLine("Full time employee is present");
                    empHours = 8;
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    empHours = 0;
                    break;
            }

            empWage = (empHours * empWagePerHour) * workingDaysPerMonth;
            Console.WriteLine("Monthly employee wage is " + empWage);
        }
    }
}
