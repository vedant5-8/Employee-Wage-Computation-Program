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

                Console.Write("=>");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Attendance.EmployeeAttendance();
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