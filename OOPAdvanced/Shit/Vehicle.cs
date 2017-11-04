using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shit
{
   public class Vehicle
    {
        private double speed;
        private double acceleration;

        public Vehicle(double speed,double acceleration)
        {
            this.speed = speed;
            this.acceleration = acceleration;
        }
        public double GetCurrentSpeed()
        {
            return this.speed;
        }
       public virtual double TryAcceleration()
        {
            return this.acceleration;
        }
    }
}
