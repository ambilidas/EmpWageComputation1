using System;

namespace EmpWageComputation1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation Program");
            //create seperate objects for each companies
            EmpWageComputation reliance = new EmpWageComputation();
            Console.WriteLine("\nWage computation for reliance "); 
            reliance.EmpWageCalc(25,22,70);
            Console.WriteLine("\nWage computation for GMart ");
            EmpWageComputation GMart=new EmpWageComputation();
            GMart.EmpWageCalc(30, 25, 100);

        }
    }
}
