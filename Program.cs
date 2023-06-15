using System;

namespace Employee_Wage_Computation_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // UC1- Check employee is present or not

            int Is_Full_Time = 1;

            Random random = new Random();

            int EmpCheck = random.Next(0, 2);

            if (EmpCheck == Is_Full_Time)
            {
                Console.WriteLine("Employee is Present.");
            }
            else
            {
                Console.WriteLine("Employee is Absent.");
            }

        }
    }
}