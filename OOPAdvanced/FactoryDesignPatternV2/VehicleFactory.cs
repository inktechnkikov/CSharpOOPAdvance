using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternV2
{
    class VehicleFactory
    {
        public static Vehicle GetVehicle(string type,string engine,int hp,int maxspeed)
        {
            if ("Car".Equals(type))
            {
                return new Car(engine,hp,maxspeed);
            }
            else if ("Truck".Equals(type))
            {
                return new Truck(engine,hp,maxspeed);
            }
            return null;
        }
    }
}
