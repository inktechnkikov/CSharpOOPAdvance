using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsbtractDesignPatternV2
{
    class Demo
    {
        static void Main(string[] args)
        {
            Vehicle car = VehicleFactory.GetVehicle(new CarFactory("Binzin", "200", "260"));
            Console.WriteLine(car.ToString());
        }
    }
}
