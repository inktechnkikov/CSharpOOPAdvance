using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    //the product class!
   public class Vehicle
    {
        private readonly string vehicleType;
        private readonly Dictionary<string, string> parts = new Dictionary<string, string>();

        public Vehicle(string vehicleType)
        {
            this.vehicleType = vehicleType;
        }
        //indexator
        public string this[string key]
        {
            get { return this.parts[key]; }
            set { this.parts[key] = value; }
        }
        public void Show()
        {
            Console.WriteLine("\n-----------------");
            Console.WriteLine("Vehicle type {0}",this.vehicleType);
            Console.WriteLine("Frame {0}",this.parts["Frame"]);
            Console.WriteLine("Engine {0}",this.parts["Engine"]);
            Console.WriteLine("Wheels {0}",this.parts["Wheels"]);
            Console.WriteLine("Doors {0}",this.parts["Doors"]);
        }
    }
}
