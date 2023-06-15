using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation_Program
{
    // UC10 - Calculate employee wage of multiple companies using Array.

    public class CompanyEmpWage
    {
        public string Company;
        public int EmpRatePerHour;
        public int NumOfWorkDays;
        public int MaxHoursPerMonth;
        public int TotalEmpWage;

        public CompanyEmpWage(string Company, int EmpRatePerHour, int NumOfWorkDays, int MaxHoursPerMonth)
        {
            this.Company = Company;
            this.EmpRatePerHour = EmpRatePerHour;
            this.NumOfWorkDays = NumOfWorkDays;
            this.MaxHoursPerMonth = MaxHoursPerMonth;
        }

        public void setTotalEmpWage(int TotalEmpWage)
        {
            this.TotalEmpWage = TotalEmpWage;
        }

        public string toString()
        {
            return "\nTotal employee wage for company " + this.Company + " is " + this.TotalEmpWage + "\n";
        }

    }

    public class EmpWageBuilder
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;

        private int NumOfCompany = 0;
        private CompanyEmpWage[] CompanyEmpWageArray;

        public EmpWageBuilder()
        {
            this.CompanyEmpWageArray = new CompanyEmpWage[10];
        }

        public void AddCompany(string Company, int EmpRatePerHour, int NumOfWorkDays, int MaxHoursPerMonth)
        {
            CompanyEmpWageArray[this.NumOfCompany] = new CompanyEmpWage(Company, EmpRatePerHour, NumOfWorkDays, MaxHoursPerMonth);
            NumOfCompany++;
        }

        public void ComputeEmpWage()
        {
            for(int i = 0; i < NumOfCompany; i++)
            {
                CompanyEmpWageArray[i].setTotalEmpWage(this.ComputeEmpWage(this.CompanyEmpWageArray[i]));
                Console.WriteLine(this.CompanyEmpWageArray[i].toString());
            }
        }

        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int EmpHours;
            int TotalEmpHours = 0;
            int TotalWorkingDays = 0;

            while (TotalEmpHours <= companyEmpWage.MaxHoursPerMonth && TotalWorkingDays < companyEmpWage.NumOfWorkDays)
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

            return TotalEmpHours * companyEmpWage.EmpRatePerHour;

        }

    }
}
