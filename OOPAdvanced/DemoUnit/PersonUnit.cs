using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnit
{
   public class PersonUnit
    {
        private int age;
        private double weight;

        public PersonUnit(int age,double weight)
        {
            this.age = age;
            this.weight = weight;
        }
        public int GetAge { get; private set; }
        public double GetWeight { get; set; }
    }
}
