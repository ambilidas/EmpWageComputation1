using System;

namespace EmpWageComputation1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation Program");
            //create seperate objects for each companies
            //EmpWageBuilder company1 = new EmpWageBuilder("Reliance",20,100,100);
            //EmpWageBuilder company2 = new EmpWageBuilder("TATA", 30, 120, 80);
            //EmpWageBuilder company3 = new EmpWageBuilder("Infosys", 45, 90, 70);
            //company1.EmpWageCalc();
            //Console.WriteLine("------------------------------------------------------------");
            //company2.EmpWageCalc();
            //Console.WriteLine("------------------------------------------------------------");
            //company3.EmpWageCalc();
            EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray();
            empWageBuilderArray.addCompanyEmpWage("TATA",30,120,80);
            empWageBuilderArray.addCompanyEmpWage("Infosys", 45, 90, 70);
            empWageBuilderArray.empWageCalc();
        }
    }
}
