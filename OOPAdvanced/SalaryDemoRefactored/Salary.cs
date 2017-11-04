using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryDemoRefactored
{
   public class Salary
    {
        private double perDay;
        private int workDays;

        public Salary(int workDays,double perDay)
        {
            this.workDays = workDays;
            this.perDay = perDay;
        }

        public int WorkDays
        {
            get { return this.workDays; }
           
        }

        public double PerDayTax
        {
            get { return this.perDay; }
           
        }

        public double CalculateSalary()
        {
            return this.WorkDays * this.PerDayTax;
        }
    }
}
