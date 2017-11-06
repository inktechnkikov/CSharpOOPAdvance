using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryDemo
{
    class SalaryDemo
    {
        static void Main(string[] args)
        {
            Salary salary = new Salary();
            Console.WriteLine(salary.CalculateSalary(2,4.5));
            
           
        }
    }
}
