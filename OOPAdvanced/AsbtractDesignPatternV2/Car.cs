using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsbtractDesignPatternV2
{
    class Car:Vehicle
    {
        private string engine;
        private string hp;
        private string maxspeed;

        public Car(string engine,string hp,string maxspeed)
        {
            this.engine = engine;
            this.hp = hp;
            this.maxspeed = maxspeed;
        }

        public override string GetEngine()
        {
            return this.engine;
        }

        public override string GetHP()
        {
            return this.hp;
        }

        public override string GetMaxSpeed()
        {
            return this.maxspeed;
        }
    }
}
