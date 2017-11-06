using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternV2
{
    class FactoryDesignPatternV2
    {
        static void Main(string[] args)
        {
            Vehicle car = VehicleFactory.GetVehicle("Car", "Electric", 250, 280);
            Vehicle truck = VehicleFactory.GetVehicle("Truck", "Diesel", 140, 200);
            Console.WriteLine("Car "+car.PrintVehicleInfo());
            Console.WriteLine("Truck "+truck.PrintVehicleInfo());
        }
    }
}
