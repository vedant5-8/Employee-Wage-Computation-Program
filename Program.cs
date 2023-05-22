using System;
using Employee_Wage_Computation_Program;

namespace EmployeeWageComputationProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your Choice: ");
                Console.WriteLine("1. Check employee is present or not.");
                Console.WriteLine("2. Calculate daily employee wage.");
                Console.WriteLine("3. Calculate monthly employee wage.");

                Console.Write("=>");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Attendance.EmployeeAttendance();
                        break;
                    case 2:
                        DailyEmployeeWage.CalculateDailyEmployeeWage();
                        break;
                    case 3:
                        MonthlyEmployeeWage.CalculateMonthlyEmployeeWage();
                        break;
                    default: 
                        Console.WriteLine("Enter correct choice.");
                        break;
                }
                Console.WriteLine("---------------------------------------");
            }
        }
    }
}