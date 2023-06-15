using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation_Program
{
    // UC9 - Calculate total employee wage and save employee wage by company.
    public class EmpWageBuilder
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;

        private string Company;
        private int EmpRatePerHour;
        private int NumOfWorkDays;
        private int MaxHoursPerMonth;
        private int TotalEmpWage;

        public EmpWageBuilder(string Company, int EmpRatePerHour, int NumOfWorkDays, int MaxHoursPerMonth)
        {
            this.Company = Company;
            this.EmpRatePerHour = EmpRatePerHour;
            this.NumOfWorkDays = NumOfWorkDays;
            this.MaxHoursPerMonth = MaxHoursPerMonth;
        }

        public void ComputeEmpWage()
        {
            int EmpHours;
            int TotalEmpHours = 0;
            int TotalWorkingDays = 0;

            while (TotalEmpHours <= this.MaxHoursPerMonth && TotalWorkingDays < this.NumOfWorkDays)
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

            TotalEmpWage = TotalEmpHours * this.EmpRatePerHour;

        }

        public string toString()
        {
            return "\nTotal employee wage for company " + this.Company + " is " + this.TotalEmpWage + "\n";
        }

    }
}
