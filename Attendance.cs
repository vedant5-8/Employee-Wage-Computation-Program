using System;

namespace Employee_Wage_Computation_Program
{
    public class Attendance
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public static void EmployeeAttendance()
        {
            Random random = new Random();

            int empCheck = random.Next(0, 3);

            if (empCheck == isFullTime)
            {
                Console.WriteLine("Employee is present");
            }
            else if (empCheck == isPartTime)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
