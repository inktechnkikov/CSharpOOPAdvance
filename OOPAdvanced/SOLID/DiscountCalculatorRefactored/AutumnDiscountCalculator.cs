using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCalculatorRefactored
{
    public class AutumnDiscountCalculator : ICalculateDiscount
    {
        public double Calculate(int amount)
        {
            return amount * 0.8;
        }

        public bool Rule(string ruleName)
        {
            return "autumn".Equals(ruleName);
        }
    }
}
