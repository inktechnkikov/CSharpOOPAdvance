using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternV2
{
    class Truck : Vehicle
    {
        private string engine;
        private int hp;
        private int maxspeed;
        public Truck(string engine,int hp,int maxspeed)
        {
            this.engine = engine;
            this.hp = hp;
            this.maxspeed = maxspeed;
        }
        public string GetEngine()
        {
            return this.engine;
        }

        public int GetHP()
        {
            return this.hp;
        }

        public int GetMaxSpeed()
        {
            return this.maxspeed;
        }

        public string PrintVehicleInfo()
        {
            return $"Engine {this.GetEngine()} HP {this.GetHP()} MaxSpeed {this.GetMaxSpeed()}";
        }
    }
}
