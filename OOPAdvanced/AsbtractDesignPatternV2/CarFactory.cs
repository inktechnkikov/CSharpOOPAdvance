using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsbtractDesignPatternV2
{
    class CarFactory:IVehicleFactory
    {
        private string engine;
        private string hp;
        private string maxspeed;

        public CarFactory(string engine,string hp,string maxspeed)
        {
            this.engine = engine;
            this.hp = hp;
            this.maxspeed = maxspeed;
        }

        public Vehicle CreateVehicle()
        {
            return new Car(engine, hp, maxspeed);
        }
    }
}
