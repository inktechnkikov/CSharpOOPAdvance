using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternDemo
{
   public abstract class Computer
    {
        public abstract string GetRam();
        public abstract string GetHDD();
        public abstract string GetCpu();

        public override string ToString()
        {
            return $"Ram {this.GetRam()} HDD {this.GetHDD()} CPU {this.GetCpu()}";
        }
    }
}
