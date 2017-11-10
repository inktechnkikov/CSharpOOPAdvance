using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    class BuilderPatterndemo
    {
        static void Main(string[] args)
        {
            VehicleBuilder vehicleBuilder = new CarBuilder();
            MainVehicleBuilder mainVehicleBuilder = new MainVehicleBuilder();
            mainVehicleBuilder.Construct(vehicleBuilder);
            vehicleBuilder.vehicle.Show();
            vehicleBuilder = new MotorBuilder();
            mainVehicleBuilder.Construct(vehicleBuilder);
            vehicleBuilder.vehicle.Show();
        }
    }
}
