using System.Collections;

namespace Employee_Wage_Computation_Program
{
    // UC14 - Get total wage when queried by company

    interface IComputeWage
    {
        void AddCompany(string Company, int EmpRatePerHour, int NumOfWorkDays, int MaxHoursPerMonth);
        void ComputeEmpWage();
        void getTotalWageByCompany(string Company);
    }

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

        public void SetTotalEmpWage(int TotalEmpWage)
        {
            this.TotalEmpWage = TotalEmpWage;
        }

        public string TotalWage()
        {
            return "\nTotal employee wage for company " + this.Company + " is " + this.TotalEmpWage + "\n";
        }

    }

    public class EmpWageBuilder : IComputeWage
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;

        private int NumOfCompany = 0;

        private ArrayList companies;
        private Dictionary<string, CompanyEmpWage> companiesDictionary;

        public EmpWageBuilder()
        {
            companies = new ArrayList();
            companiesDictionary = new Dictionary<string, CompanyEmpWage>();
        }

        public void AddCompany(string Company, int EmpRatePerHour, int NumOfWorkDays, int MaxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(Company, EmpRatePerHour, NumOfWorkDays, MaxHoursPerMonth);
            this.companies.Add(companyEmpWage);
            this.companiesDictionary.Add(Company, companyEmpWage);
        }

        public void ComputeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companies)
            {
                companyEmpWage.SetTotalEmpWage(this.ComputeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.TotalWage());
            }
        }

        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        { 
            int TotalEmpHours = 0;
            int TotalWorkingDays = 0;
            int EmpHours = 0;
            int DailyEmpWage;

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

                DailyEmpWage = EmpHours * companyEmpWage.EmpRatePerHour;
                Console.WriteLine("Daily employee wage for Day {0} is {1}", TotalWorkingDays, DailyEmpWage);
            }

            
            return TotalEmpHours * companyEmpWage.EmpRatePerHour;

        }

        public void getTotalWageByCompany(string Company)
        {
            try
            {
                Console.WriteLine("Total wage for {0} company is {1}",
                    Company, this.companiesDictionary[Company].TotalEmpWage);
            }
            catch
            {
                Console.WriteLine("Company \"{0}\" is not present in the list.", Company);
            }
        }

    }
}
