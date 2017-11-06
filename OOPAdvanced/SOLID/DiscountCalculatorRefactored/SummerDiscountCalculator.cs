using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCalculatorRefactored
{
    public class SummerDiscountCalculator : ICalculateDiscount
    {
        public double Calculate(int amount)
        {
            return amount * 0.15;
        }

        public bool Rule(string ruleName)
        {
            return "summer".Equals(ruleName);
        }
    }
}
