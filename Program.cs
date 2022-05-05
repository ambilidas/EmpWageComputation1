using System;

namespace EmpWageComputation1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation Program");
            EmpWageComputation myobj=new EmpWageComputation();
            myobj.EmpAttendance();
        }
    }
}
