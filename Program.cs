﻿using System;
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
                Console.WriteLine("4. Calculating Wages till Number of Working Days or Total Working Hours per month is Reached.");
                Console.WriteLine("5. Compute Employee Wage for Multiple Company.");
                Console.WriteLine("6. Exit.");

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
                    case 4:
                        TotalWages.CalculateTotalWages();
                        break;
                    case 5:
                        EmpWageForMultipleCompanies.computeEmployeeWage("IBM", 20, 2, 100);
                        EmpWageForMultipleCompanies.computeEmployeeWage("TCS", 20, 5, 100);
                        break;
                    case 6:
                        Environment.Exit(0);
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