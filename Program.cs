using System;

namespace Employee_Wage_Computation_Program
{
    class Program
    {
        
        static void Main(string[] args)
        {
            EmpWageBuilder IBM = new EmpWageBuilder("IBM", 20, 2, 10);
            EmpWageBuilder Jio = new EmpWageBuilder("Jio", 10, 4, 20);

            IBM.ComputeEmpWage();
            Console.WriteLine(IBM.toString());

            Jio.ComputeEmpWage();
            Console.WriteLine(Jio.toString());
        }
    }
}