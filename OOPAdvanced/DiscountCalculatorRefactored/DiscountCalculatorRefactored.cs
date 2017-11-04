using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCalculatorRefactored
{
    class DiscountCalculatorRefactored
    {
        static void Main(string[] args)
        {
            DiscCalculator calculator = new DiscCalculator(new SummerDiscountCalculator());
            calculator.GetDiscount("summer", 100);
            //DiscCalculator calculator = new DiscCalculator();
            //Console.WriteLine(calculator.CalculateDiscount(100, "winter"));
        }
    }
}
