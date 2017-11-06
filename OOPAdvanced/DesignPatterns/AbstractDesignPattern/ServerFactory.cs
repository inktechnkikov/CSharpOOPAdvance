using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDesignPattern
{
    class ServerFactory:IComputerAsbtractFactory
    {
        private string ram;
        private string hdd;
        private string cpu;

        public ServerFactory(string ram,string hdd,string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }

        public Computer CreateComputer()
        {
            return new Server(ram, hdd, cpu);
        }
    }
}
