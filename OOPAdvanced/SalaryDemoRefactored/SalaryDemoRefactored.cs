using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryDemoRefactored
{
    class SalaryDemoRefactored
    {
        static void Main(string[] args)
        {
            Salary salary = new Salary(20,30);
            double total =  salary.CalculateSalary();
            PrintTotalSalary printTotalSalary = new PrintTotalSalary();
            printTotalSalary.PrintSalary(total);
        }
    }
}
