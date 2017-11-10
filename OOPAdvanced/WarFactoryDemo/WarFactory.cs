using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarFactoryDemo
{
    class WarFactory
    {
       public static IWarMachine GetMachine(IMachineBuilder machine)
        {
            return machine.BuildMachine();
        }
    }
}
