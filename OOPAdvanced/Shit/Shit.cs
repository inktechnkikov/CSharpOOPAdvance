using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shit
{
    class Shit
    {
        static void Main(string[] args)
        {
            Car car = new Car(150, 100);
            Console.WriteLine(car.GetCurrentSpeed());
            Console.WriteLine(car.TryAcceleration());
        }
       
    }
}
