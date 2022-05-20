using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation1
{
    public class EmpWageBuilder
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        public string companyName;
        public int empWagePerHr;
        public int MaxWorkingDays;
        public int MaxWorkingHours;
        Random random = new Random();

        //constructor
        public EmpWageBuilder(string companyName, int empWagePerHr, int MaxWorkingDays, int MaxWorkingHours)
        {
            this.companyName = companyName;
            this.empWagePerHr = empWagePerHr;
            this.MaxWorkingDays = MaxWorkingDays;
            this.MaxWorkingHours = MaxWorkingHours;
        }
        //Instance method
        public void EmpWageCalc()
        {
            int emphr = 0, totalempwage = 0, totalempHr = 0, TotalWorkingDays=0;

            while (TotalWorkingDays < MaxWorkingDays && totalempHr < MaxWorkingHours)
            {
                TotalWorkingDays++;
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case IS_FULL_TIME:
                        emphr = 8;
                        break;
                    case IS_PART_TIME:
                        emphr = 4;
                        break;
                    default:
                        emphr = 0;
                        break;
                }
                totalempHr += emphr;
                //empwage = emphr * empWagePerHr;
                //Console.WriteLine("\nEmployee Daily Wage: {0}", empwage);

            }
            Console.WriteLine("\nCalculation of employee wage at {0}",companyName);
            Console.WriteLine("\nTotal Working Days: " + TotalWorkingDays + "  Total Employee Hours :" + totalempHr);
            totalempwage = totalempHr * empWagePerHr;
            Console.WriteLine("Total employee wage of :{0}", totalempwage);
            

        }
    }
}
