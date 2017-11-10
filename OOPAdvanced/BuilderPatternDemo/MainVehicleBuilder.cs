using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    //The 'Director' class
    class MainVehicleBuilder
    {
        public void Construct(VehicleBuilder builder)
        {
            builder.BuildFrame();
            builder.BuildEngine();
            builder.BuildDoors();
            builder.BuildWheels();
        }
    }
}
