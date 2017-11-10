using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeFactoryDemo
{
   public class CoffeeFactory
    {
        public static Coffe GetCoffe(CoffeType coffeType)
        {
            switch (coffeType)
            {
                case CoffeType.Regular:
                    return new Coffe(0, 150);
                case CoffeType.Double:
                    return new Coffe(0, 200);
                case CoffeType.Macchiato:
                    return new Coffe(200, 100);
                case CoffeType.Cappuccino:
                    return new Coffe(100, 100);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
