using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCalculatorRefactored
{
   
   public class DiscCalculator
    {
        private double discountValue = 0;
        private ICalculateDiscount calculateDiscount;
        public DiscCalculator(ICalculateDiscount calculateDiscount)
        {
            this.calculateDiscount = calculateDiscount;
        }
        public void GetDiscount(string rule, int amount)
        {
            string currentRule = Convert.ToString(calculateDiscount.Rule(rule));
            discountValue = calculateDiscount.Calculate(amount);
            Console.WriteLine($"The discount is {discountValue}");
        }
        //private List<ICalculateDiscount> discountService = new List<ICalculateDiscount>();
        //public DiscCalculator()
        //{
        //    this.discountService.Add(new AutumnDiscountCalculator());
        //    this.discountService.Add(new SpringDiscountCalculator());
        //    this.discountService.Add(new SummerDiscountCalculator());
        //    this.discountService.Add(new WinterDiscountCalculator());
        //}
        //public double CalculateDiscount(int amount, string rule)
        //{
        //    discountValue = discountService.Find(i => i.Rule(rule)).Calculate(amount);
        //    return discountValue;
        //}
    }
}
