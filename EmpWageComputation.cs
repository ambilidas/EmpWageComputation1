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
        


        public void EmpAttendance()
        {
            int empcheck = random.Next(0, 2);
            if(empcheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }



    }
}