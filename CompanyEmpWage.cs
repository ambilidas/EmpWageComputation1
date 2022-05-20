using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation1
{
    public class CompanyEmpWage
    {
        public string companyName;
        public  int empWagePerHr;
        public  int MaxWorkingDays;
        public int MaxWorkingHours;
        public int totalEmpWage;
        public  CompanyEmpWage(string companyName, int empWagePerHr, int MaxWorkingDays, int MaxWorkingHours)
        {
            this.companyName = companyName;
            this.empWagePerHr = empWagePerHr;
            this.MaxWorkingDays = MaxWorkingDays;
            this.MaxWorkingHours = MaxWorkingHours;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Total employee wage for company " + companyName + " : " + totalEmpWage;
        }
    }
    public class EmpWageBuilderArray
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        int numOfCompany = 0;
        CompanyEmpWage[] CompanyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.CompanyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(string companyName, int empWagePerHr, int MaxWorkingDays, int MaxWorkingHours)
        {
            CompanyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(companyName, empWagePerHr, MaxWorkingDays, MaxWorkingHours);
            numOfCompany++;
        }
        public void empWageCalc()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                CompanyEmpWageArray[i].setTotalEmpWage(this.empWageCalc(this.CompanyEmpWageArray[i]));
                Console.WriteLine(this.CompanyEmpWageArray[i].toString());
            }
        }
        public int empWageCalc(CompanyEmpWage companyEmpWage)
        {
            int emphr = 0, totalempwage = 0, totalempHr = 0, TotalWorkingDays = 0;
            Random random = new Random();


            while (TotalWorkingDays <= companyEmpWage.MaxWorkingDays && totalempHr <= companyEmpWage.MaxWorkingHours)
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
            }
            Console.WriteLine("\nCalculation of employee wage at {0}", companyEmpWage.companyName);
            Console.WriteLine("\nTotal Working Days: " + TotalWorkingDays + "  Total Employee Hours :" + totalempHr);
            return totalempwage = totalempHr * companyEmpWage.empWagePerHr;
        }

    }
}
