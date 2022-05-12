using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation1
{

    public class EmpWageComputation
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int WAGE_PER_HOUR = 20;
        public const int MAX_WORKING_DAYS = 20;
        public const int MAX_WORKING_HOURS = 100;

        int emphr = 0;
        int empwage = 0;
        int totalempwage=0;
        int totalempHr = 0;
        int TotalWorkingDays=0;
        Random random = new Random();



        public void EmpWageCalc()
        {
            
            while(TotalWorkingDays< MAX_WORKING_DAYS && totalempHr< MAX_WORKING_HOURS)
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
                empwage = emphr * WAGE_PER_HOUR;
                Console.WriteLine("\nEmployee Daily Wage: {0}", empwage);
               
            }
            Console.WriteLine("\nTotal Working Days: " + TotalWorkingDays + "  Total Employee Hours :" + totalempHr);
            totalempwage = totalempHr * WAGE_PER_HOUR;
            Console.WriteLine("Total employee wage:{0}", totalempwage);

        }
       
    }
}