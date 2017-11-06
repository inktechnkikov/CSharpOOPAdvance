using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCalculatorRefactored
{
   public interface ICalculateDiscount
    {
        bool Rule(string ruleName);
        double Calculate(int amount);
    }
}
