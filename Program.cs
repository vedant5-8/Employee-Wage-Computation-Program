using System;

namespace Employee_Wage_Computation_Program
{
    class Program
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;

        // UC8 - Calculate employee wage for multiple companies.
        public static int ComputeEmpWage(string Company, int EmpRatePerHour, int NumOfWorkDays, int MaxHoursPerMonth)
        {
            int EmpHours;
            int TotalEmpHours = 0;
            int TotalWorkingDays = 0;

            while (TotalEmpHours <= MaxHoursPerMonth && TotalWorkingDays < NumOfWorkDays)
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
            Console.WriteLine("\nTotal employee wage for company {0} is {1}\n",Company, TotalEmpWage);
            return TotalEmpWage;
        }
        static void Main(string[] args)
        {
            ComputeEmpWage("IBM", 20, 5, 25);
            ComputeEmpWage("Jio", 20, 4, 20);
        }
    }
}