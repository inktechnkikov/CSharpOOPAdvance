using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternDemo
{
    class FactoryDesignPatternDemo
    {
        static void Main(string[] args)
        {
            Computer pc = ComputerFactory.GetComputer("Pc", "8 GB", "2 TB", "Intel I7");
            Computer server = ComputerFactory.GetComputer("Server", "32 GB", "6 TB", "Intel Xeon");

            Console.WriteLine($"Pc Configuration {pc}");
            Console.WriteLine($"Server Configuration {server}");
        }
    }
}
