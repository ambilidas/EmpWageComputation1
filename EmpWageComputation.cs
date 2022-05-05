using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation1
{

    public class EmpWageComputation
    {
        int IS_FULL_TIME = 1;
        Random random = new Random();
        int WAGE_PER_HOUR = 20;
       // int FULL_DAY_HOUR = 8;
        int emphr = 0;
        int empwage = 0;

        public void EmpAttendance()
        {
            int empcheck = random.Next(0, 2);
            if(empcheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
                emphr = 8;
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