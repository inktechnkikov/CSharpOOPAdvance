using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternDemo
{
    class Pc : Computer
    {
        private string ram;
        private string hdd;
        private string cpu;

        public Pc(string ram,string hdd,string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }
        public override string GetCpu()
        {
            return this.cpu;
        }

        public override string GetHDD()
        {
            return this.hdd;
        }

        public override string GetRam()
        {
            return this.ram;
        }
    }
}
