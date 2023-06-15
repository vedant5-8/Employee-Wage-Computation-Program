using System;

namespace Employee_Wage_Computation_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();

            empWageBuilder.AddCompany("IBM", 20, 2, 10);
            empWageBuilder.AddCompany("TCS", 10, 4, 20);
            empWageBuilder.ComputeEmpWage();

            Console.WriteLine("Enter company name: ");
            string company = Console.ReadLine();

            empWageBuilder.getTotalWageByCompany(company);
        }
    }
}