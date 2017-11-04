using Demo.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class StartUp
    {
        static void Main(string[] args)
        {
            MultifunctionalMachine machine = new MultifunctionalMachine();
            Console.WriteLine(machine.Print());
            Console.WriteLine(machine.BeginScan());
        }
    }
}
