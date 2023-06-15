using System;

namespace Employee_Wage_Computation_Program
{
    class Program
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;
        public const int EmpRatePerHour = 20;
        public const int NumOfWorkDaysPerMonth = 20;
        public const int MaxHoursInMonth = 100;
        static void Main(string[] args)
        {
            // UC6 - Calculate Wages till number of working days or total working hours per months is reached

            int EmpHours;
            int EmpWage;
            int TotalEmpHours = 0;
            int TotalWorkingDays = 0;

            while (TotalEmpHours <= MaxHoursInMonth && TodalWorkingDays < NumOfWorkDaysPerMonth)
            {
                TodalWorkingDays++;

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

                TotalEmpHours += EmpHours;
                Console.WriteLine("Days: {0} | Employee Hours: {1}",TotalWorkingDays, EmpHours);

            }

            int TotalEmpWage = TotalEmpHours * EmpRatePerHour;
            Console.WriteLine("\nTotal employee wage is {0}", TotalEmpWage);

        }
    }
}