using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation1
{

    public class EmpWageComputation
    {
        int IS_PART_TIME = 1;
        int IS_FULL_TIME = 2;
        int WAGE_PER_HOUR = 20;

        int emphr = 0;
        int empwage = 0;

        Random random = new Random();
        
        

        public void EmpAttendance()
        {
            int empcheck = random.Next(0, 3);
            if(empcheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
                emphr = 8;
            }
            else if(empcheck == IS_PART_TIME)
            {
                Console.WriteLine("Employee is part time");
                emphr = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }

        public void EmpWageCalc()
        {
            empwage = emphr* WAGE_PER_HOUR;
            Console.WriteLine("Employee Daily Wage: {0}",empwage);
        }



    }
}