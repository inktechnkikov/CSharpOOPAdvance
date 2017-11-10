using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarFactoryDemo
{
    class Demo
    {
        static void Main(string[] args)
        {
            IWarMachine airfighter = WarFactory.GetMachine(new AirFighterFactory(10, 20, 100, 40));
            Console.WriteLine(airfighter.GetMachineParams());
            IWarMachine tank = WarFactory.GetMachine(new GroundVehicleFactory(50, 80, 120, 15));
            Console.WriteLine(tank.GetMachineParams());
        }
    }
}
