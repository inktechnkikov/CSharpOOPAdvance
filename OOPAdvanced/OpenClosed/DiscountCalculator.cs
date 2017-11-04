using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
   public class DiscountCalculator
    {
        private double discountValue = 0;
        public double CalculateDiscount(int amount,string rule)
        {
            if (rule.Equals("summer"))
            {
                discountValue += amount * 0.15;
            }
            else if (rule.Equals("winter"))
            {
                discountValue += amount * 0.10;
            }
            else if (rule.Equals("christmas"))
            {
                discountValue += amount * 0.30;
            }
            return discountValue;
        }
    }
}
