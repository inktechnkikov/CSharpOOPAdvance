using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCalculatorRefactored
{
    public class WinterDiscountCalculator : ICalculateDiscount
    {
        public double Calculate(int amount)
        {
            return amount * 0.20;
        }

        public bool Rule(string ruleName)
        {
            return "winter".Equals(ruleName);
        }
    }
}
