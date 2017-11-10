using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsbtractDesignPatternV2
{
    class VehicleFactory
    {
        public static Vehicle GetVehicle(IVehicleFactory vehicleFactory)
        {
            return vehicleFactory.CreateVehicle();
        }
    }
}
