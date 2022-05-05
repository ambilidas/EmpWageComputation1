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
        public const int NUM_OF_WORKING_DAYS = 20;

        int emphr = 0;
        int empwage = 0;
        int totalempwage=0;
        Random random = new Random();



        public void EmpAttendance()
        {
            
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
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

                empwage = emphr * WAGE_PER_HOUR;
                Console.WriteLine("Employee Daily Wage: {0}", empwage);
                totalempwage += empwage;
            }

        }
        public void EmpWageCalc()
        {
            Console.WriteLine("Total employee wage:{0}",totalempwage);
        }



    }
}