using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeFactoryDemo
{
    class Demo
    {
        static void Main(string[] args)
        {
            Coffe coffe = CoffeeFactory.GetCoffe(CoffeType.Cappuccino);
            Console.WriteLine($"Coffee {coffe.GetCoffeContent} {coffe.GetMilkContent}");
        }
    }
}
