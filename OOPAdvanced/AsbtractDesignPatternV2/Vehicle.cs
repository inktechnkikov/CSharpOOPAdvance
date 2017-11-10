using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsbtractDesignPatternV2
{
  public abstract class Vehicle
    {
        public abstract string GetEngine();
        public abstract string GetHP();
        public abstract string GetMaxSpeed();

        public override string ToString()
        {
            return $"{this.GetEngine()} {this.GetHP()} {this.GetMaxSpeed()}";
        }
    }
}
