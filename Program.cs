using System;

namespace Employee_Wage_Computation_Program
{
    class Program
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;
        public const int EmpRatePerHour = 20;
        static void Main(string[] args)
        {
            // UC4 - Calculate daily employee wage with switch case statement

            int EmpHours;
            int EmpWage;

            Random random = new Random();

            int EmpCheck = random.Next(0, 3);

            switch (EmpCheck)
            {
                case Is_Part_Time:
                    EmpHours = 4;
                    break;
                case Is_Full_Time:
                    EmpHours = 8;
                    break;
                default:
                    EmpHours = 0;
                    break;
            }

            EmpWage = EmpHours * EmpRatePerHour;
            Console.WriteLine("Daily Employee Wage is {0}", EmpWage);
        }
    }
}