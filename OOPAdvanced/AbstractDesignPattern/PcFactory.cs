using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignPattern
{
    class PcFactory : IComputerAsbtractFactory
    {
        private string ram;
        private string hdd;
        private string cpu;

        public PcFactory(string ram,string hdd,string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }

        public Computer CreateComputer()
        {
            return new Pc(ram, hdd, cpu);
        }
    }
}
