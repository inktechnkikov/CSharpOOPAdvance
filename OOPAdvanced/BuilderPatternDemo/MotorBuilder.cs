using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    class MotorBuilder : VehicleBuilder
    {
        public MotorBuilder()
        {
            this.vehicle = new Vehicle("Motor");
        }
        public override void BuildDoors()
        {
            this.vehicle["Doors"] = "none";
        }

        public override void BuildEngine()
        {
            this.vehicle["Engine"] = "120cc";
        }

        public override void BuildFrame()
        {
            this.vehicle["Frame"] = "Motor Frame";
        }

        public override void BuildWheels()
        {
            this.vehicle["Wheels"] = "2";
        }
    }
}
