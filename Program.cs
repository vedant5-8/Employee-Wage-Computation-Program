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

        // UC7 - Calculate employee wage using class methods
        public static int ComputeEmpWage()
        {
            int EmpHours;
            int TotalEmpHours = 0;
            int TotalWorkingDays = 0;

            while (TotalEmpHours <= MaxHoursInMonth && TotalWorkingDays < NumOfWorkDaysPerMonth)
            {
                TotalWorkingDays++;

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
                Console.WriteLine("Days: {0} | Employee Hours: {1}", TotalWorkingDays, EmpHours);

            }

            int TotalEmpWage = TotalEmpHours * EmpRatePerHour;
            Console.WriteLine("\nTotal employee wage is {0}", TotalEmpWage);
            return TotalEmpWage;
        }
        static void Main(string[] args)
        {
            ComputeEmpWage();
        }
    }
}