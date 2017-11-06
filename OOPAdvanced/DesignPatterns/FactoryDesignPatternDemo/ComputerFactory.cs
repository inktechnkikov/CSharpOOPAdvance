using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternDemo
{
    class ComputerFactory
    {
        public static Computer GetComputer(string type,string ram,string hdd,string cpu)
        {
            if ("Pc".Equals(type))
            {
                return new Pc(ram, hdd, cpu);
            }
            else if ("Server".Equals(type))
            {
                return new Server(ram, hdd, cpu);
            }
            return null;
        }
    }
}
