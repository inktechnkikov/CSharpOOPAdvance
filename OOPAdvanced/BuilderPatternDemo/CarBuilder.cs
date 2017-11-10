using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            this.vehicle = new Vehicle("Car");
        }
        public override void BuildFrame()
        {
            this.vehicle["Frame"] = "Car Frame";
        }
        public override void BuildEngine()
        {
            this.vehicle["Engine"] = "Electric";
        }
        public override void BuildWheels()
        {
            this.vehicle["Wheels"] = "4";
        }
        public override void BuildDoors()
        {
            this.vehicle["Doors"] = "4";
        }

    }
}
