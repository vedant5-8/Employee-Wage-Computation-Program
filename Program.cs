using System;

namespace Employee_Wage_Computation_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();

            empWageBuilder.AddCompanyEmpWage("IBM", 20, 2, 10);
            empWageBuilder.AddCompanyEmpWage("TCS", 10, 4, 20);
            empWageBuilder.ComputeEmpWage();
            
        }
    }
}