using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shit
{
    public class Car : Vehicle
    {
        public Car(double speed, double acceleration)
            : base(speed, acceleration)
        {

        }

        public override double TryAcceleration()
        {
            return base.TryAcceleration() * 2;
        }
    }
}
