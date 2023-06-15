using System;

namespace Employee_Wage_Computation_Program
{
    class Program
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;
        public const int EmpRatePerHour = 20;
        public const int NumOfWorkDaysPerMonth = 20;
        static void Main(string[] args)
        {
            // UC5 - Calculate monthly employee wage.

            int EmpHours;
            int EmpWage;
            int TotalEmpWage = 0;

            for (int day = 1; day <= NumOfWorkDaysPerMonth; day++)
            {
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
                TotalEmpWage += EmpWage;
                Console.WriteLine("Daily Employee Wage is {0}", EmpWage);

            }

            Console.WriteLine("\nTotal employee wage is {0}", TotalEmpWage);

        }
    }
}