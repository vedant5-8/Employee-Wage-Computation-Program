using System;

namespace Employee_Wage_Computation_Program
{
    public class DailyEmployeeWage
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public const int empWagePerHour = 20;
        public static void CalculateDailyEmployeeWage()
        {
            int empHours;
            int empWage;

            Random random = new Random();
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

            empWage = empHours * empWagePerHour;
            Console.WriteLine("Daily employee wage is " + empWage);
        }
    }
}
