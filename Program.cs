using System;

namespace Employee_Wage_Computation_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // UC3 - Add Part time employee and Calculate daily employee wage

            int Is_Part_Time = 1;
            int Is_Full_Time = 2;
            int EmpRatePerHour = 20;

            int EmpHours;
            int EmpWage;

            Random random = new Random();

            int EmpCheck = random.Next(0, 3);

            if (EmpCheck == Is_Part_Time)
            {
                EmpHours = 4;
            }
            else if (EmpCheck == Is_Full_Time)
            {
                EmpHours = 8;
            }
            else
            {
                EmpHours = 0;
            }

            EmpWage = EmpHours * EmpRatePerHour;
            Console.WriteLine("Daily Employee Wage is {0}", EmpWage);
        }
    }
}