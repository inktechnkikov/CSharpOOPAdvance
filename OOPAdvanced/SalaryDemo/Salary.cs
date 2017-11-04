using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryDemo
{
   public class Salary
    {
        public int numberOfDays;

        public double perDayRate;

        public Salary()
        {
          
        }
        public double CalculateSalary(int numOfDays,double perDayRate)
        {
            return numOfDays * perDayRate;
        }
        public void PrintSalary()
        {
            Console.WriteLine(this.numberOfDays * this.perDayRate);
        }
    }
}
