using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCalculatorRefactored
{
    public class SpringDiscountCalculator : ICalculateDiscount
    {
        public double Calculate(int amount)
        {
            return amount * 0.10;
        }

        public bool Rule(string ruleName)
        {
            return "spring".Equals(ruleName);
        }
    }
}
